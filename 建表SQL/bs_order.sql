/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50728
Source Host           : localhost:3306
Source Database       : dbhelper_test

Target Server Type    : MYSQL
Target Server Version : 50728
File Encoding         : 65001

Date: 2020-11-01 20:37:47
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
