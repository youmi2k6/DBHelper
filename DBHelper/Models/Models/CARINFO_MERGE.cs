using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class CARINFO_MERGE
    {

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public long? ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? MODIFY_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string LICENSE_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_PLATE_COLOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string BRAND { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string MODEL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string PASSENGER_LEVEL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_COLOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ENG_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string FRAME_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_IDENTITY_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? SEAT_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? CAR_TONNAGE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string FUEL_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? ENG_POWER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? LEAVE_FACTORY_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? BUY_CAR_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? SETTLE_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? WHEELBASE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? CAR_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? CAR_HEIGHT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? CAR_WIDTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string DRIVING_WAY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string TRANSFORM_LICENSE_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string OWNER_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string BUSINESS_LICENSE_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string GRANT_ORG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? BEGIN_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? END_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string BUSINESS_SCOPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_OPERATE_SITUATION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CAR_TECHNOLOGY_LEVEL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? DRIVE_RECORDER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? LOCATOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? FUEL_EXAM_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? FIRST_GRANT_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ANCHORED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ADMINISTRATIVE_DIVISION_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ORG_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string OWNER_ADDRESS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ECONOMIC_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string LEGAL_REPRESENTATIVE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ID_CARD_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string PHONE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string TELEPHONE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string OWNER_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string OWNER_ABBREVIATION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CHECK_COMPANY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string VEHICLE_NO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CHECK_PERSON { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string MANAFACTURE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string PRODUCT_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string VHCL_COMPANY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string VHCL_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CHASSIS_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string DRIVE_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string TYRE_SIZE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ENGINE_TYPE1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? TOTAL_MASS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? TRALIER_MASS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? WHEEL_MASS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? TRUCK_VOL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? SEAT_SUM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? WIDTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? HIGH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? BOX_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? BOX_WIDTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? BOX_HIGH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public int? CURB_WEIGHT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? SIZE_EXCEED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? BOARD_EXCEED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? CURB_WEIGHT_EXCEED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CHECK_COM_OPTION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string MANAGER_COM_PERSON { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string MANAGER_COM_OPTION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public DateTime? TEST_DATE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string IS_TRANS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string DISTRICT_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string ENGINE_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string TELEPHONE_1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string CHECK_STATE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public decimal? SEAT_EXCEED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string VHCL_COLOR { get; set; }

    }
}
