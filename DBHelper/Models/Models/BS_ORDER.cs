using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 订单表
    /// </summary>
    [Serializable]
    public partial class BS_ORDER
    {

        /// <summary>
        /// 主键
        /// </summary>
        [IsId]
        [IsDBField]
        public string ID { get; set; }

        /// <summary>
        /// 订单时间
        /// </summary>
        [IsDBField]
        public DateTime ORDER_TIME { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [IsDBField]
        public decimal? AMOUNT { get; set; }

        /// <summary>
        /// 下单用户
        /// </summary>
        [IsDBField]
        public long ORDER_USERID { get; set; }

        /// <summary>
        /// 订单状态(0草稿 1已下单 2已付款 3已发货 4完成)
        /// </summary>
        [IsDBField]
        public int STATUS { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [IsDBField]
        public string REMARK { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [IsDBField]
        public string CREATE_USERID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [IsDBField]
        public DateTime CREATE_TIME { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        [IsDBField]
        public string UPDATE_USERID { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [IsDBField]
        public DateTime? UPDATE_TIME { get; set; }

    }
}
