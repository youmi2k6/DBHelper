using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// 平台_摄像机表
    /// </summary>
    [Serializable]
    public partial class PT_CAMERA_INFO
    {

        /// <summary>
        /// 资产ID
        /// </summary>
        [IsDBField]
        public string ASSET_ID { get; set; }

        /// <summary>
        /// 20位：中心编码、 行业编码、设备类型、网络标识、设备序号，与联网平台/共享平台国标编码一致。（天网：CAMEAR_NO 摄像头编号，项目部提供的编号，点位编码+摄像机编码的组合）
        /// </summary>
        [IsDBField]
        public string CAMERA_NO { get; set; }

        /// <summary>
        /// 点位编码
        /// </summary>
        [IsDBField]
        public string POSITION_CODE { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:所属点位ID）
        /// </summary>
        [IsDBField]
        public string POSITION_ID { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:摄像头名称）
        /// </summary>
        [IsDBField]
        public string CAMERA_NAME { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:所属机构）
        /// </summary>
        [IsDBField]
        public long? ORG_ID { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:安装详细地址）
        /// </summary>
        [IsDBField]
        public string ADDRESS { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:IP地址）
        /// </summary>
        [IsDBField]
        public string CAMERA_IP { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:经度）
        /// </summary>
        [IsDBField]
        public string LONGITUDE { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:纬度）
        /// </summary>
        [IsDBField]
        public string LATITUDE { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:摄像机SN号：设备发现接口取得的）
        /// </summary>
        [IsDBField]
        public string SN { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:摄像机型号）
        /// </summary>
        [IsDBField]
        public string CAMERA_MODEL { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:生产厂商）
        /// </summary>
        [IsDBField]
        public string MANUFACTURER { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:供应商）
        /// </summary>
        [IsDBField]
        public string SUPPLIER { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:摄像头状态1 在线0离线）
        /// </summary>
        [IsDBField]
        public string CAMERA_STATE { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:添加人）
        /// </summary>
        [IsDBField]
        public string ADD_ID { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:添加时间）
        /// </summary>
        [IsDBField]
        public DateTime ADD_TIME { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:修改人）
        /// </summary>
        [IsDBField]
        public string MODIFY_ID { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:修改时间）
        /// </summary>
        [IsDBField]
        public DateTime? MODIFY_TIME { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:像机用户名）
        /// </summary>
        [IsDBField]
        public string USER_NAME { get; set; }

        /// <summary>
        /// (天网业务字段,与资产重复:像机密码）
        /// </summary>
        [IsDBField]
        public string PASS_WORD { get; set; }

        /// <summary>
        /// 机箱安装形式：1、立杆；2、借杆；3、壁挂；4、落地；99、其他。单选
        /// </summary>
        [IsDBField]
        public int? CASE_INSTALL_TYPE { get; set; }

        /// <summary>
        /// 行政区域，按照标准(GB/T2260-2007）
        /// </summary>
        [IsDBField]
        public string AREA_CODE { get; set; }

        /// <summary>
        /// 监控点位类型：1.一类视频监控点；2.二类视频监控点； 3.三类视频监控点； 4 公安内部视频监控点；9.其他点位。
        /// </summary>
        [IsDBField]
        public string MONITOR_TYPE { get; set; }

        /// <summary>
        /// 点位俗称
        /// </summary>
        [IsDBField]
        public string POINT_NAME { get; set; }

        /// <summary>
        /// IPV6地址
        /// </summary>
        [IsDBField]
        public string CAMERA_IP6 { get; set; }

        /// <summary>
        /// 子网掩码
        /// </summary>
        [IsDBField]
        public string SUBNET_MASK { get; set; }

        /// <summary>
        /// 网关
        /// </summary>
        [IsDBField]
        public string GATEWAY { get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [IsDBField]
        public string MAC_ADDRESS { get; set; }

        /// <summary>
        /// ONU SN码
        /// </summary>
        [IsDBField]
        public string ONU_SN { get; set; }

        /// <summary>
        /// 1.球机；3.固定枪机；5.卡口枪机；99.其他；100.高点监控；101.半高点球机（天网：CAMERA_TYPE,摄像机类型）
        /// </summary>
        [IsDBField]
        public string CAMERA_TYPE { get; set; }

        /// <summary>
        /// 1.车辆卡口；2.人员卡口；3.微卡口；99.其他；100.综合治理枪机；101.综合治理球机；102.人像识别枪机（后智能）；103.虚拟卡口；104.高空枪机；105.高空球机；106.半高空球机；107.视频结构化（后智能）；108.全景拼接；109.枪球联动（球）；110.枪球联动（枪）；111.高倍高点球机；112.高倍高点云台枪机；113.机房摄像机（天网：CAMERA_USE）
        /// </summary>
        [IsDBField]
        public string CAMERA_FUN_TYPE { get; set; }

        /// <summary>
        /// 补光属性：1.无补光；2.红外补光；9.其他补光；10.外置白光补光；11.内置白光补光（雪亮微卡口选这个）；12.LED频闪补光（雪亮的部分实体卡口选这个）
        /// </summary>
        [IsDBField]
        public int? FILL_LIGTH_ATTR { get; set; }

        /// <summary>
        /// 摄像机编码格式：1.MPEG-4； 2.H.264； 3.SVAC； 4.H.265?
        /// </summary>
        [IsDBField]
        public int? CAMERA_ENCODE_TYPE { get; set; }

        /// <summary>
        /// 取电方式： 1.电业局供电；2.企事业单位；3.居民用电专供；4.临街商铺专供；5.交警取电；6.其他
        /// </summary>
        [IsDBField]
        public int? POWER_TAKE_TYPE { get; set; }

        /// <summary>
        /// 取电长度：单位为米，小数点后一位
        /// </summary>
        [IsDBField]
        public string POWER_TAKE_LENGTH { get; set; }

        /// <summary>
        /// 是否有拾音器，1表示是，2表示否（天网：否带语音0：不带 1：带语音告警设备）
        /// </summary>
        [IsDBField]
        public int? SOUND_ALARM { get; set; }

        /// <summary>
        /// 摄像机分辨率：1.QCIF；2.CIF；3.4CIF；4.D1；5.720P；6.1080P；7.4K及以上（天网：分辨率）
        /// </summary>
        [IsDBField]
        public string RESOLUTION { get; set; }

        /// <summary>
        /// 摄像机软件版本
        /// </summary>
        [IsDBField]
        public string SOFT_VERSION { get; set; }

        /// <summary>
        /// 镜头参数,(天网：镜头参数)
        /// </summary>
        [IsDBField]
        public string LENS_PARAM { get; set; }

        /// <summary>
        /// 是否有云台（天网：是否有云台，1 有，0无）
        /// </summary>
        [IsDBField]
        public int? IS_HAVE_CONSOLE { get; set; }

        /// <summary>
        /// 摄像机安装方式：1、立杆；2、借杆；3、壁挂；4.其他（天网：安装方式）
        /// </summary>
        [IsDBField]
        public string INSTALL_WAY { get; set; }

        /// <summary>
        /// 走线方式：1、地埋；2、飞线；3、沿墙敷设；4、其他（天网：走线方式）
        /// </summary>
        [IsDBField]
        public string LINEAR_WAY { get; set; }

        /// <summary>
        /// 资源存储位置：分局雪亮机房名称（存在哪个机房），外场定义(天网：资源存储位置)
        /// </summary>
        [IsDBField]
        public string RESOURCE_PLACE { get; set; }

        /// <summary>
        /// 重点监控对象：1、第一道防控圈；2、第二道防控圈；3、第三道防空圈；4、第四道防控圈；5、第五道防控圈；6、第六道防控圈；99、其他（天网：重点监控对象）
        /// </summary>
        [IsDBField]
        public string IMPORT_WATCH { get; set; }

        /// <summary>
        /// 摄像机位置类型：1.省际检查站、2.党政机关、3.车站码头、4.中心广场、5.体育场馆、6.商业中心、7.宗教场所、8.校园周边、9.治安复杂区域、10.交通干线、11-医院周边、12-金融机构周边、13-危险物品场所周边、14-博物馆展览馆、15-重点水域、航道、96.市际公安检查站；97.涉外场所；98.边境沿线；99.旅游景区。新增：100.高速路口、101.高速路段、102.城市高点、103.拥堵路段、104.旅馆周边、105.网吧周边、106.公园周边、107.娱乐场所、108.新闻媒体单位周边、109.电信邮政单位周边、110.机场周边、111.铁路沿线、112.火车站周边、113.汽车站周边、114.港口周边、115.城市轨道交通站、116.公交车站周边、117.停车场（库）、118.地下人行通道、119.隧道、120.过街天桥、121.省/市/县（区）际道路主要出入口、122.收费站通道、123.高速公路卡口卡点、124.国道卡口卡点、125.省道上的（治安）卡口卡点、126.大型桥梁通行区域、127.隧道通行区域、128.大型能源动力设施周边、129.城市（水/电/燃气/燃油/热力）能源供应单位周边、130.文博单位（博物馆/纪念馆/展览馆/档案馆/重点文物保护）、131.国家重点建设工程工地、132.居民小区、133.高架上下匝道、134.加油站、135.人脸重点区域、136.黄标车卡点、137.采血点附近。多选各参数以“ /” 分隔
        /// </summary>
        [IsDBField]
        public string POSITION_TYPE { get; set; }

        /// <summary>
        /// 社区名称（天网：COMMUNITY 社区名称）
        /// </summary>
        [IsDBField]
        public string COMMUNITY { get; set; }

        /// <summary>
        /// 街道（天网：STREET 街道）
        /// </summary>
        [IsDBField]
        public string STREET { get; set; }

        /// <summary>
        /// 照射具体位置：1、出入口；2、背街小巷；3、人行道；4、非机动车道；5、主干道路段；6、交叉路口
        /// </summary>
        [IsDBField]
        public string WATCH_SPEC_LOCATION { get; set; }

        /// <summary>
        /// 所在道路位置：**路东、**路南、**路北、**路西
        /// </summary>
        [IsDBField]
        public string ROAD_DIRECTION { get; set; }

        /// <summary>
        /// 辖区边界属性：属于边界资源，如**派出所与**派出所边界，**分局与**分局边界  (天网：辖区边界（多个以逗号分割）)
        /// </summary>
        [IsDBField]
        public string FOUL_LINE { get; set; }

        /// <summary>
        /// 分局：1.瑶海分局、2.庐阳分局、3.蜀山分局、4.包河分局、5.高新分局、6.新站分局、7.经开分局
        /// </summary>
        [IsDBField]
        public string FEN_JU { get; set; }

        /// <summary>
        /// 派出所
        /// </summary>
        [IsDBField]
        public string POLICE_STATION { get; set; }

        /// <summary>
        /// 监视方位：1-东、2-西、3-南、4-北、5-东南、6-东北、7-西南、8-西北、9.全向（要求厂商定位准确）（天网：CAMERA_DIRECTION）
        /// </summary>
        [IsDBField]
        public string CAMERA_DIRECTION { get; set; }

        /// <summary>
        /// 架设高度：1、3.5m；2、4.6m；3、5.3m；4、6m；5、6.8；6、其他（外场定义）
        /// </summary>
        [IsDBField]
        public string INSTALL_HEIGHT { get; set; }

        /// <summary>
        /// 横臂1：1、0.5m；2、1m；3、1.5m；4、2m；5、7m（外场定义）
        /// </summary>
        [IsDBField]
        public string CROSS_ARM1 { get; set; }

        /// <summary>
        /// 横臂2：1、0.5m；2、1m；3、1.5m；4、2m；5、7m（外场定义）
        /// </summary>
        [IsDBField]
        public string CROSS_ARM2 { get; set; }

        /// <summary>
        /// 安装位置：1.室外；2.室内
        /// </summary>
        [IsDBField]
        public int? INDOOR_OR_NOT { get; set; }

        /// <summary>
        /// 摄像机特写照片：建设好之后，拍的摄像机场景照片（照片名称需与文件夹名称一致）
        /// </summary>
        [IsDBField]
        public string SPECIAL_PHOTO_PATH { get; set; }

        /// <summary>
        /// 勘察照片
        /// </summary>
        [IsDBField]
        public string LOCATION_PHOTO_PATH { get; set; }

        /// <summary>
        /// 摄像机照射照片
        /// </summary>
        [IsDBField]
        public string REAL_PHOTO_PATH { get; set; }

        /// <summary>
        /// 联网属性：0 已联网； 1 未联网
        /// </summary>
        [IsDBField]
        public int? NETWORK_PROPERTIES { get; set; }

        /// <summary>
        /// 采用公安组织机构代码(由GA/T 380规定)，公安机关建设单位或者社会资源接入后的使用单位，注明到所属辖区公安机关派出所
        /// </summary>
        [IsDBField]
        public string POLICE_AREA_CODE { get; set; }

        /// <summary>
        /// 安装负责人：外场定义
        /// </summary>
        [IsDBField]
        public string INSTALL_PERSION { get; set; }

        /// <summary>
        /// 年、月、日（外场定义）（上线时间)
        /// </summary>
        [IsDBField]
        public DateTime? INSTALL_TIME { get; set; }

        /// <summary>
        /// 建设期数：1.一期；2.二期；3.三期；4.四期；5.五期；6.支网；99、其他。单选（字段可以由数据字典维护）
        /// </summary>
        [IsDBField]
        public int? BUILD_PERIOD { get; set; }

        /// <summary>
        /// 项目名称：
        /// </summary>
        [IsDBField]
        public string PROJECT_NAME { get; set; }

        /// <summary>
        /// ，待确认
        /// </summary>
        [IsDBField]
        public string MANAGER_UNIT { get; set; }

        /// <summary>
        /// ，待确认
        /// </summary>
        [IsDBField]
        public string MANAGER_UNIT_TEL { get; set; }

        /// <summary>
        /// 、自定义
        /// </summary>
        [IsDBField]
        public string MAINTAIN_UNIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [IsDBField]
        public string MAINTAIN_UNIT_TEL { get; set; }

        /// <summary>
        /// 30天、90天
        /// </summary>
        [IsDBField]
        public int? RECODE_SAVE_TYPE { get; set; }

        /// <summary>
        /// 1.在用；2.维修；3.拆除默认在用
        /// </summary>
        [IsDBField]
        public int? DEVICE_STATE { get; set; }

        /// <summary>
        /// 1.公安机关； 2.环保部门;3.文博部门;4.医疗部门;5.旅游管理;6.新闻广电;7.食品医药监督管理部门;8.教育管理部门;9.检察院;10.法院;11.金融部门;12.交通部门;13.住房和城乡建设部门;14.水利部门;15.林业部门;16.安全生产监督部门;17.市政市容委;18.国土局,可扩展， 多选各参数以“ /” 分隔
        /// </summary>
        [IsDBField]
        public string INDUSTRY_OWN { get; set; }

        /// <summary>
        /// 是否已注册到汇聚平台
        /// </summary>
        [IsDBField]
        public int? IS_REGISTER_IMOS { get; set; }

        /// <summary>
        /// 是否有Wifi模块：0，否；1，是
        /// </summary>
        [IsDBField]
        public int? IS_WIFI { get; set; }

        /// <summary>
        /// 闪光灯
        /// </summary>
        [IsDBField]
        public int? IS_FLASH { get; set; }

        /// <summary>
        /// 天网业务字段（摄像头的字母形式编号，项目部提供的编号，如：YH-HC-）0001-1011,提供给运维系统展示使用
        /// </summary>
        [IsDBField]
        public string CAMERA_NO_STR { get; set; }

        /// <summary>
        /// 天网业务字段（摄像机VCN编码：可能需要与摄像机编号对应）
        /// </summary>
        [IsDBField]
        public string CAMERA_VCN_CODE { get; set; }

        /// <summary>
        /// 天网业务字段，域编码
        /// </summary>
        [IsDBField]
        public string FIELD_NO { get; set; }

        /// <summary>
        /// 重点监控单位，照射具体单位名称（如兴园小学）（天网业务字段，重点单位）
        /// </summary>
        [IsDBField]
        public string KEY_UNIT { get; set; }

        /// <summary>
        /// 天网业务字段，单位类型
        /// </summary>
        [IsDBField]
        public string UNIT_TYPE { get; set; }

        /// <summary>
        /// 天网业务字段，显示等级
        /// </summary>
        [IsDBField]
        public decimal? SHOW_LEVEL { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机协议类型：设备发现接口取得的
        /// </summary>
        [IsDBField]
        public string PROTOCOL_TYPE { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机端口号
        /// </summary>
        [IsDBField]
        public string CAMERA_PORT { get; set; }

        /// <summary>
        /// 天网业务字段，接口类型
        /// </summary>
        [IsDBField]
        public string INTERFACE_TYPE { get; set; }

        /// <summary>
        /// 天网业务字段，通道
        /// </summary>
        [IsDBField]
        public string CHANNEL { get; set; }

        /// <summary>
        /// 天网业务字段，使用对象
        /// </summary>
        [IsDBField]
        public string USER_OBJECT { get; set; }

        /// <summary>
        /// 天网业务字段，施工图URL
        /// </summary>
        [IsDBField]
        public string IMG_PATH { get; set; }

        /// <summary>
        /// 天网业务字段，描述
        /// </summary>
        [IsDBField]
        public string CAMERA_DESC { get; set; }

        /// <summary>
        /// 天网业务字段，是否已注册VCN
        /// </summary>
        [IsDBField]
        public int? IS_REGISTER_VCN { get; set; }

        /// <summary>
        /// 天网业务字段，是否删除
        /// </summary>
        [IsDBField]
        public int IS_DEL { get; set; }

        /// <summary>
        /// 天网业务字段，排序值
        /// </summary>
        [IsDBField]
        public int? ORDER_VALUE { get; set; }

        /// <summary>
        /// 天网业务字段，检测结果:0 正常 1  黑屏  2 冻结  3  掉线   4  亮度异常  5 清晰度异常   6 偏色  7  噪声  8  抖动  9 遮挡  10  PTZ失控
        /// </summary>
        [IsDBField]
        public int? POLLING_RESULT { get; set; }

        /// <summary>
        /// 天网业务字段，最新检测时间
        /// </summary>
        [IsDBField]
        public DateTime? POLLING_TIME { get; set; }

        /// <summary>
        /// 天网业务字段，诊断服务器ID
        /// </summary>
        [IsDBField]
        public long? SERVER_ID { get; set; }

        /// <summary>
        /// 天网业务字段，摄像头检索条件集合
        /// </summary>
        [IsDBField]
        public string SHORT_MSG { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机所属设备
        /// </summary>
        [IsDBField]
        public string CAMERA_BELONGS_ID { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机来源，0 华为VCN3000   1 交警支队
        /// </summary>
        [IsDBField]
        public string RELATED_CUSTOMS { get; set; }

        /// <summary>
        /// 天网业务字段，是否进入空间库，1为进入，0为否
        /// </summary>
        [IsDBField]
        public int? ADDED_TO_SDE { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机备件
        /// </summary>
        [IsDBField]
        public string CAMERA_BAK { get; set; }

        /// <summary>
        /// 天网业务字段，摄像机所属四创虚拟卡口设备
        /// </summary>
        [IsDBField]
        public string CAMERA_BELONGS_PK { get; set; }

        /// <summary>
        /// 天网业务字段，杆件编码
        /// </summary>
        [IsDBField]
        public string MEMBERBAR_CODE { get; set; }

        /// <summary>
        /// 天网业务字段，是否是支网
        /// </summary>
        [IsDBField]
        public int? IS_BRANCH { get; set; }

        /// <summary>
        /// 是否设置看守位
        /// </summary>
        [IsDBField]
        public int? IS_WATCHPOS { get; set; }

        /// <summary>
        /// 监视角度，取值范围0-360度（正东方为0度，正南方为90度，正西方为180度，正北方为270度，精确到个位）
        /// </summary>
        [IsDBField]
        public string CAMERA_ANGLE { get; set; }

        /// <summary>
        /// 1、0.5m；2、1m；3、1.5m；4、2m；5、7m（外场定义）
        /// </summary>
        [IsDBField]
        public string CROSS_ARM3 { get; set; }

        /// <summary>
        /// 一机一档数据同步：0未同步 1已同步
        /// </summary>
        [IsDBField]
        public int? IS_SYS { get; set; }

        /// <summary>
        /// 摄像机存储时间
        /// </summary>
        [IsDBField]
        public long? RECORD_TIME { get; set; }

        /// <summary>
        /// 解析平台编码
        /// </summary>
        [IsDBField]
        public string ANALYSIS_NO { get; set; }

        /// <summary>
        /// WIFI 在线状态，0离线，1在线
        /// </summary>
        [IsDBField]
        public string WIFI_STATE { get; set; }

        /// <summary>
        /// 人脸任务状态：0未启动 1已启动 2锁定
        /// </summary>
        [IsDBField]
        public int? FACE_TASK_STATUS { get; set; }

        /// <summary>
        /// 视频结构化任务状态：0未启动 1已启动 2锁定
        /// </summary>
        [IsDBField]
        public int? VIDEO_TASK_STATUS { get; set; }

        /// <summary>
        /// 虚拟卡口任务状态：0未启动 1已启动 2锁定
        /// </summary>
        [IsDBField]
        public int? BAYONET_TASK_STATUS { get; set; }

        /// <summary>
        /// 视频质量诊断结果附图URL
        /// </summary>
        [IsDBField]
        public string VQD_URL { get; set; }

        /// <summary>
        /// 一机一档同步数据类型 1:新增 2:修改 3:删除
        /// </summary>
        [IsDBField]
        public int? SYS_TYPE { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [IsId]
        [IsDBField]
        public string ID { get; set; }

    }
}
