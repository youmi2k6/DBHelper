using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using DAL;
using System.Collections.Generic;
using DBUtil;
using Utils;
using System.Threading.Tasks;

namespace DBHelperTest
{
    [TestClass]
    public class UpdateTest
    {
        #region 变量
        private BsOrderDal m_BsOrderDal = ServiceHelper.Get<BsOrderDal>();
        private SysUserDal m_SysUserDal = ServiceHelper.Get<SysUserDal>();
        private Random _rnd = new Random();
        #endregion

        #region 测试修改订单
        [TestMethod]
        public void TestUpdateOrder()
        {
            string userId = "10";

            BS_ORDER order = m_BsOrderDal.Get("991de30a46ad4599919b56d1a13d100c");
            order.REMARK = "订单已修改";
            order.UPDATE_USERID = userId;

            order.DetailList.Clear(); //删除全部明细

            //删除某条明细
            //for (int i = order.DetailList.Count - 1; i >= 0; i--)
            //{
            //    if (order.DetailList[i].GOODS_NAME == "鼠标")
            //    {
            //        order.DetailList.RemoveAt(i);
            //    }
            //}

            foreach (BS_ORDER_DETAIL oldDetail in order.DetailList)
            {
                oldDetail.UPDATE_USERID = userId;
            }

            BS_ORDER_DETAIL detail = new BS_ORDER_DETAIL();
            detail.GOODS_NAME = "桌子" + _rnd.Next(1, 100);
            detail.QUANTITY = 10;
            detail.PRICE = (decimal)78.89;
            detail.SPEC = "张";
            detail.CREATE_USERID = userId;
            detail.ORDER_NUM = 4;
            order.DetailList.Add(detail);

            detail = new BS_ORDER_DETAIL();
            detail.GOODS_NAME = "椅子" + _rnd.Next(1, 100);
            detail.QUANTITY = 20;
            detail.PRICE = (decimal)30.23;
            detail.SPEC = "把";
            detail.CREATE_USERID = userId;
            detail.ORDER_NUM = 5;
            order.DetailList.Add(detail);

            m_BsOrderDal.Update(order, order.DetailList);
        }
        #endregion

        #region 测试修改用户
        [TestMethod]
        public void TestUpdateUser()
        {
            string userId = "10";
            SYS_USER user = m_SysUserDal.Get(userId);
            if (user != null)
            {
                user.UPDATE_USERID = "1";
                user.REMARK = "测试修改用户" + _rnd.Next(1, 100);
                m_SysUserDal.Update(user);
                Console.WriteLine("用户 ID=" + user.ID + " 已修改");
            }
            else
            {
                Console.WriteLine("用户 ID=" + userId + " 不存在");
            }
        }
        #endregion

        #region 测试修改用户(异步)
        [TestMethod]
        public async Task TestUpdateUserAsync()
        {
            string userId = "10";
            SYS_USER user = m_SysUserDal.Get(userId);
            if (user != null)
            {
                user.UPDATE_USERID = "1";
                user.REMARK = "测试修改用户" + _rnd.Next(1, 100);
                var task = m_SysUserDal.UpdateAsync(user);
                await task;
                Console.WriteLine("用户 ID=" + user.ID + " 已修改");
            }
            else
            {
                Console.WriteLine("用户 ID=" + userId + " 不存在");
            }
        }
        #endregion

    }
}
