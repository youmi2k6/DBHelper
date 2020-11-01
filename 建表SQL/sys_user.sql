/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50728
Source Host           : localhost:3306
Source Database       : dbhelper_test

Target Server Type    : MYSQL
Target Server Version : 50728
File Encoding         : 65001

Date: 2020-11-01 20:17:52
*/

SET FOREIGN_KEY_CHECKS=0;
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
AUTO_INCREMENT=14

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
ALTER TABLE `sys_user` AUTO_INCREMENT=14;
