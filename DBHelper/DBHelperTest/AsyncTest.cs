using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using DAL;
using System.Collections.Generic;
using DBUtil;
using System.Threading;
using System.Threading.Tasks;
using Utils;

namespace DBHelperTest
{
    [TestClass]
    public class AsyncTest
    {
        #region 变量
        private BsOrderDal m_BsOrderDal = ServiceHelper.Get<BsOrderDal>();
        #endregion

        #region 测试异步查询订单集合
        [TestMethod]
        public async Task TestQueryAsync()
        {
            var task = m_BsOrderDal.GetListAsync(0, null, DateTime.MinValue, DateTime.Now.AddDays(1));
            List<BS_ORDER> list = await task;

            foreach (BS_ORDER item in list)
            {
                Console.WriteLine(ModelToStringUtil.ToString(item));
            }
        }
        #endregion

    }
}
