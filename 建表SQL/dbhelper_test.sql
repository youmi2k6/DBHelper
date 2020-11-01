/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50728
Source Host           : localhost:3306
Source Database       : dbhelper_test

Target Server Type    : MYSQL
Target Server Version : 50728
File Encoding         : 65001

Date: 2020-11-01 20:38:30
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `bs_order`
-- ----------------------------
DROP TABLE IF EXISTS `bs_order`;
CREATE TABLE `bs_order` (
`id`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '主键' ,
`order_time`  datetime NOT NULL COMMENT '订单时间' ,
`amount`  decimal(20,2) NULL DEFAULT NULL COMMENT '订单金额' ,
`order_userid`  bigint(20) NOT NULL COMMENT '下单用户' ,
`status`  tinyint(4) NOT NULL COMMENT '订单状态(0草稿 1已下单 2已付款 3已发货 4完成)' ,
`remark`  varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '备注' ,
`create_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '创建者ID' ,
`create_time`  datetime NOT NULL COMMENT '创建时间' ,
`update_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新者ID' ,
`update_time`  datetime NULL DEFAULT NULL COMMENT '更新时间' ,
PRIMARY KEY (`id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8mb4 COLLATE=utf8mb4_general_ci
COMMENT='订单表'

;

-- ----------------------------
-- Records of bs_order
-- ----------------------------
BEGIN;
INSERT INTO `bs_order` VALUES ('4fad31a32c544a53a8bc5cf81d9857c6', '2020-11-01 20:36:39', '17268.42', '10', '0', null, '10', '2020-11-01 20:36:40', null, null), ('58ade81729c641c886d3167dd8f576b1', '2020-11-01 20:36:42', '17268.42', '10', '0', null, '10', '2020-11-01 20:36:43', null, null), ('69e32c302d564f5aacc4c8619f01d72b', '2020-11-01 20:36:36', '17268.42', '10', '0', null, '10', '2020-11-01 20:36:37', null, null), ('991de30a46ad4599919b56d1a13d100c', '2020-11-01 20:36:40', '17268.42', '10', '0', null, '10', '2020-11-01 20:36:40', null, null), ('e894b48ad0fb46229baa64b2c450db61', '2020-11-01 20:36:43', '17268.42', '10', '0', null, '10', '2020-11-01 20:36:43', null, null);
COMMIT;

-- ----------------------------
-- Table structure for `bs_order_detail`
-- ----------------------------
DROP TABLE IF EXISTS `bs_order_detail`;
CREATE TABLE `bs_order_detail` (
`id`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '主键' ,
`order_id`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '订单ID' ,
`goods_name`  varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品名称' ,
`quantity`  int(11) NOT NULL COMMENT '数量' ,
`price`  decimal(20,2) NOT NULL COMMENT '价格' ,
`spec`  varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '物品规格' ,
`order_num`  int(11) NULL DEFAULT NULL COMMENT '排序' ,
`create_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '创建者ID' ,
`create_time`  datetime NOT NULL COMMENT '创建时间' ,
`update_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新者ID' ,
`update_time`  datetime NULL DEFAULT NULL COMMENT '更新时间' ,
PRIMARY KEY (`id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8mb4 COLLATE=utf8mb4_general_ci
COMMENT='订单明细表'

;

-- ----------------------------
-- Records of bs_order_detail
-- ----------------------------
BEGIN;
INSERT INTO `bs_order_detail` VALUES ('00f937b63310441eadb4677859fa7354', '4fad31a32c544a53a8bc5cf81d9857c6', '鼠标', '12', '50.68', '个', '2', '10', '2020-11-01 20:36:40', null, null), ('01b973383f2041e99bbdc80b57d65e8f', '69e32c302d564f5aacc4c8619f01d72b', '鼠标', '12', '50.68', '个', '2', '10', '2020-11-01 20:36:37', null, null), ('14a4fd6ad61d44708b85b585270f4595', '4fad31a32c544a53a8bc5cf81d9857c6', '电脑', '3', '5100.00', '台', '1', '10', '2020-11-01 20:36:40', null, null), ('280a1f1aebf14ffe9535e5f4fb8f387c', '58ade81729c641c886d3167dd8f576b1', '电脑', '3', '5100.00', '台', '1', '10', '2020-11-01 20:36:43', null, null), ('28b22a4c18974fd5b223f9f4cec92f63', '58ade81729c641c886d3167dd8f576b1', '鼠标', '12', '50.68', '个', '2', '10', '2020-11-01 20:36:43', null, null), ('373552f167344c4bbef4f6181160bf49', 'e894b48ad0fb46229baa64b2c450db61', '键盘', '11', '123.66', '个', '3', '10', '2020-11-01 20:36:43', null, null), ('74a527d7f588488cbdbcc07ad2d01541', '69e32c302d564f5aacc4c8619f01d72b', '电脑', '3', '5100.00', '台', '1', '10', '2020-11-01 20:36:37', null, null), ('a2fc46da2bbd49e4b9c2fdf4721a9e3c', '991de30a46ad4599919b56d1a13d100c', '电脑', '3', '5100.00', '台', '1', '10', '2020-11-01 20:36:40', null, null), ('b752ed84977b44ca864d6d30d6f06708', 'e894b48ad0fb46229baa64b2c450db61', '鼠标', '12', '50.68', '个', '2', '10', '2020-11-01 20:36:43', null, null), ('bccee217412948198d7fc8b1757f012f', '69e32c302d564f5aacc4c8619f01d72b', '键盘', '11', '123.66', '个', '3', '10', '2020-11-01 20:36:37', null, null), ('cdf70dcd413e4ffaabebc7bd161a6023', '991de30a46ad4599919b56d1a13d100c', '鼠标', '12', '50.68', '个', '2', '10', '2020-11-01 20:36:40', null, null), ('d0acf6216ac94f20a047ec90a60f65ab', '4fad31a32c544a53a8bc5cf81d9857c6', '键盘', '11', '123.66', '个', '3', '10', '2020-11-01 20:36:40', null, null), ('d11e7310b11f4e0984ef901f2c3d2ceb', '58ade81729c641c886d3167dd8f576b1', '键盘', '11', '123.66', '个', '3', '10', '2020-11-01 20:36:43', null, null), ('e8f9fa724c3f431da2abcaaa95d48ccf', '991de30a46ad4599919b56d1a13d100c', '键盘', '11', '123.66', '个', '3', '10', '2020-11-01 20:36:40', null, null), ('fab8393bdba0432dbedc6fb97c81d31e', 'e894b48ad0fb46229baa64b2c450db61', '电脑', '3', '5100.00', '台', '1', '10', '2020-11-01 20:36:43', null, null);
COMMIT;

-- ----------------------------
-- Table structure for `sys_user`
-- ----------------------------
DROP TABLE IF EXISTS `sys_user`;
CREATE TABLE `sys_user` (
`id`  bigint(20) NOT NULL AUTO_INCREMENT COMMENT '主键' ,
`user_name`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户名' ,
`real_name`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '用户姓名' ,
`password`  varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户密码' ,
`remark`  varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '备注' ,
`create_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '创建者ID' ,
`create_time`  datetime NOT NULL COMMENT '创建时间' ,
`update_userid`  varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新者ID' ,
`update_time`  datetime NULL DEFAULT NULL COMMENT '更新时间' ,
PRIMARY KEY (`id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8mb4 COLLATE=utf8mb4_general_ci
COMMENT='用户表'
AUTO_INCREMENT=16

;

-- ----------------------------
-- Records of sys_user
-- ----------------------------
BEGIN;
INSERT INTO `sys_user` VALUES ('1', 'admin', '超级管理员', '123456', '超级管理员', '1', '2020-11-01 13:39:43', '1', '2020-11-01 13:39:47'), ('2', 'admin2020', '普通管理员', '123456', '普通管理员', '1', '2020-11-01 13:42:55', '1', '2020-11-01 13:42:58'), ('10', 'zhangsan', '张三', '123456', '测试修改用户94', '1', '2020-11-01 13:40:30', '1', '2020-11-01 13:40:34'), ('11', '李四', '李四', '123456', '', '1', '2020-11-01 13:42:08', '1', '2020-11-01 13:42:10');
COMMIT;

-- ----------------------------
-- Auto increment value for `sys_user`
-- ----------------------------
ALTER TABLE `sys_user` AUTO_INCREMENT=16;
