using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 订单明细表
    /// </summary>
    [Serializable]
    public partial class BS_ORDER_DETAIL
    {

        /// <summary>
        /// 主键
        /// </summary>
        [IsId]
        [IsDBField]
        public string ID { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [IsDBField]
        public string ORDER_ID { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [IsDBField]
        public string GOODS_NAME { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [IsDBField]
        public int QUANTITY { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [IsDBField]
        public decimal PRICE { get; set; }

        /// <summary>
        /// 物品规格
        /// </summary>
        [IsDBField]
        public string SPEC { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [IsDBField]
        public int? ORDER_NUM { get; set; }

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
