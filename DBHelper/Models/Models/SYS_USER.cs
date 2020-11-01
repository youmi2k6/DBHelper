using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Serializable]
    public partial class SYS_USER
    {

        /// <summary>
        /// 主键
        /// </summary>
        [IsId]
        [IsDBField]
        public long ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [IsDBField]
        public string USER_NAME { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [IsDBField]
        public string REAL_NAME { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [IsDBField]
        public string PASSWORD { get; set; }

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
