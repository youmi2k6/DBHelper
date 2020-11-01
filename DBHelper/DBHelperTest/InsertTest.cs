using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using DAL;
using System.Collections.Generic;
using DBUtil;
using Utils;

namespace DBHelperTest
{
    [TestClass]
    public class InsertTest
    {
        #region 变量
        private BsOrderDal m_BsOrderDal = ServiceHelper.Get<BsOrderDal>();
        private SysUserDal m_SysUserDal = ServiceHelper.Get<SysUserDal>();
        #endregion

        #region 测试添加订单
        [TestMethod]
        public void TestInsertOrder()
        {
            string userId = "10";

            BS_ORDER order = new BS_ORDER();
            order.ORDER_TIME = DateTime.Now;
            order.AMOUNT = 0;
            order.ORDER_USERID = 10;
            order.STATUS = 0;
            order.CREATE_USERID = userId;

            List<BS_ORDER_DETAIL> detailList = new List<BS_ORDER_DETAIL>();
            BS_ORDER_DETAIL detail = new BS_ORDER_DETAIL();
            detail.GOODS_NAME = "电脑";
            detail.QUANTITY = 3;
            detail.PRICE = 5100;
            detail.SPEC = "台";
            detail.CREATE_USERID = userId;
            detail.ORDER_NUM = 1;
            detailList.Add(detail);

            detail = new BS_ORDER_DETAIL();
            detail.GOODS_NAME = "鼠标";
            detail.QUANTITY = 12;
            detail.PRICE = (decimal)50.68;
            detail.SPEC = "个";
            detail.CREATE_USERID = userId;
            detail.ORDER_NUM = 2;
            detailList.Add(detail);

            detail = new BS_ORDER_DETAIL();
            detail.GOODS_NAME = "键盘";
            detail.QUANTITY = 11;
            detail.PRICE = (decimal)123.66;
            detail.SPEC = "个";
            detail.CREATE_USERID = userId;
            detail.ORDER_NUM = 3;
            detailList.Add(detail);

            m_BsOrderDal.Insert(order, detailList);
        }
        #endregion

        #region 测试添加两个订单
        /// <summary>
        /// 测试新增两条订单记录
        /// </summary>
        [TestMethod]
        public void TestInsertTwoOrder()
        {
            TestInsertOrder();
            TestInsertOrder();
        }
        #endregion

        #region 测试添加用户
        [TestMethod]
        public void TestInsertUser()
        {
            SYS_USER user = new SYS_USER();
            user.USER_NAME = "testUser";
            user.REAL_NAME = "测试插入用户";
            user.PASSWORD = "123456";
            user.CREATE_USERID = "1";
            m_SysUserDal.Insert(user);
        }
        #endregion

    }
}
