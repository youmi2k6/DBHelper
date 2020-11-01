using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtil
{
    /// <summary>
    /// 分页SQL工厂
    /// </summary>
    public class PageSqlFactory
    {
        #region CreatePageSql
        public static string CreatePageSql(string dbType, string sql, string orderby, int pageSize, int currentPage, int totalRows)
        {
            StringBuilder sb = new StringBuilder();
            int startRow = 0;
            int endRow = 0;
            switch (dbType)
            {
                case "oracle":
                    #region 分页查询语句
                    startRow = pageSize * (currentPage - 1);
                    endRow = startRow + pageSize;

                    sb.Append("select * from ( select row_limit.*, rownum rownum_ from (");
                    sb.Append(sql);
                    if (!string.IsNullOrWhiteSpace(orderby))
                    {
                        sb.Append(" ");
                        sb.Append(orderby);
                    }
                    sb.Append(" ) row_limit where rownum <= ");
                    sb.Append(endRow);
                    sb.Append(" ) where rownum_ >");
                    sb.Append(startRow);
                    #endregion
                    break;
                case "mssql":
                    #region 分页查询语句
                    startRow = pageSize * (currentPage - 1) + 1;
                    endRow = startRow + pageSize - 1;

                    sb.Append(string.Format(@"
                            select * from 
                            (select ROW_NUMBER() over({1}) as rowNumber, t.* from ({0}) t) tempTable
                            where rowNumber between {2} and {3} ", sql, orderby, startRow, endRow));
                    #endregion
                    break;
                case "mysql":
                    #region 分页查询语句
                    startRow = pageSize * (currentPage - 1);

                    sb.Append("select * from (");
                    sb.Append(sql);
                    if (!string.IsNullOrWhiteSpace(orderby))
                    {
                        sb.Append(" ");
                        sb.Append(orderby);
                    }
                    sb.AppendFormat(" ) row_limit limit {0},{1}", startRow, pageSize);
                    #endregion
                    break;
                case "sqlite":
                    #region 分页查询语句
                    startRow = pageSize * (currentPage - 1);

                    sb.Append(sql);
                    if (!string.IsNullOrWhiteSpace(orderby))
                    {
                        sb.Append(" ");
                        sb.Append(orderby);
                    }
                    sb.AppendFormat(" limit {0} offset {1}", pageSize, startRow);
                    #endregion
                    break;
                case "access":
                    #region 分页查询语句
                    endRow = pageSize * currentPage;
                    startRow = pageSize * currentPage > totalRows ? totalRows - pageSize * (currentPage - 1) : pageSize;
                    string[] orderbyArr = string.Format("{0} asc", orderby.Trim()).Split(' ');

                    sb.AppendFormat(@"
                            select * from(
                            select top {4} * from 
                            (select top {3} * from ({0}) order by {1} asc)
                            order by {1} desc
                            ) order by {1} {2}", sql, orderbyArr[0], orderbyArr[1], endRow, startRow);
                    #endregion
                    break;
            }

            return sb.ToString();
        }
        #endregion

    }
}
