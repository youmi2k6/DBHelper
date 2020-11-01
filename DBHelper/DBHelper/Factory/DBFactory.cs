using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtil
{
    /// <summary>
    /// 数据库工厂
    /// </summary>
    public static class DBFactory
    {
        #region 创建 DbConnection
        /// <summary>
        /// 创建 DbConnection
        /// </summary>
        public static DbConnection CreateConnection(string dbType, string connectionString)
        {
            DbConnection conn = null;

            switch (dbType)
            {
                case "oracle":
                    conn = new OracleConnection(connectionString);
                    break;
                case "mssql":
                    conn = new SqlConnection(connectionString);
                    break;
                case "mysql":
                    conn = new MySqlConnection(connectionString);
                    break;
                case "sqlite":
                    conn = new SQLiteConnection(connectionString);
                    break;
                case "access":
                    conn = new OleDbConnection(connectionString);
                    break;
            }

            return conn;
        }
        #endregion

        #region 创建获取最大编号SQL
        /// <summary>
        /// 创建获取最大编号SQL
        /// </summary>
        public static string CreateGetMaxIdSql(string dbType, string key, Type type)
        {
            string sql = null;
            switch (dbType)
            {
                case "oracle":
                    sql = string.Format("SELECT Max({0}) FROM {1}", key, type.Name);
                    break;
                case "mssql":
                    sql = string.Format("SELECT Max({0}) FROM {1}", key, type.Name);
                    break;
                case "mysql":
                    sql = string.Format("SELECT Max({0}) FROM {1}", key, type.Name);
                    break;
                case "sqlite":
                    sql = string.Format("SELECT Max(cast({0} as int)) FROM {1}", key, type.Name);
                    break;
                case "access":
                    sql = string.Format("SELECT Max({0}) FROM {1}", key, type.Name);
                    break;
            }
            return sql;
        }
        #endregion

    }
}
