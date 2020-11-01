using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 订单表
    /// </summary>
    public partial class BS_ORDER
    {
        /// <summary>
        /// 订单明细集合
        /// </summary>
        public List<BS_ORDER_DETAIL> DetailList { get; set; }

        /// <summary>
        /// 下单用户姓名
        /// </summary>
        public string OrderUserRealName { get; set; }
    }
}
