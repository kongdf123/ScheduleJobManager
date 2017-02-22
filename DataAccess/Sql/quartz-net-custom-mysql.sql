CREATE DATABASE `quartz` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
CREATE TABLE `custom_db_config` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ServerAddress` varchar(30) NOT NULL,
  `DBName` varchar(45) NOT NULL,
  `UserName` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `EquipmentNum` varchar(25) NOT NULL,
  `PageSize` int(5) DEFAULT NULL,
  `MaxCapacity` int(10) DEFAULT NULL,
  `StoredType` smallint(1) NOT NULL COMMENT '存储方式，1：按每页，2：按数据总量',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COMMENT='记录数据库连接配置信息';

CREATE TABLE `custom_job_details` (
  `JobId` int(11) NOT NULL AUTO_INCREMENT,
  `JobName` varchar(100) CHARACTER SET utf8 NOT NULL,
  `JobGroup` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `JobChineseName` varchar(100) CHARACTER SET utf8 NOT NULL,
  `JobServiceURL` varchar(200) CHARACTER SET big5 NOT NULL,
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UpdatedDate` datetime DEFAULT NULL,
  `StartDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `EndDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `ExecutedFreq` smallint(1) DEFAULT NULL COMMENT '执行频率\n0：只执行一次\n1：循环执行',
  `PageSize` int(11) DEFAULT NULL,
  `Interval` int(11) DEFAULT NULL,
  `State` smallint(1) DEFAULT NULL COMMENT '任务状态\n0：等待\n1：执行中\n2：停止',
  `Description` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `IntervalType` smallint(1) DEFAULT NULL COMMENT '执行间隔类型：\n1：天\n2：小时\n3：分钟',
  PRIMARY KEY (`JobId`,`JobName`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='to manage parameter records ,which belongs to control custom job actions in practice.';
