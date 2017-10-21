# ScheduleJobManager
A simple management tool for schedule job ,which is based on Quartz.NET, integrate with desktop,webservice

任务计划管理系统部署说明

一.	安装环境准备
名称	说明
.NET Framework	4.0+
MySQL	MySQL Community Server 5.6 +
IIS 7.0	
二.	各个应用安装http://www.cnblogs.com/kongdf/p/6429775.html
1.	数据库创建
在MySQL 数据库里依次执行以下SQL脚本——
•	quartz-net-custom-mysql.sql
•	quartz-net-base-tables_mysql_innodb.sql
2.	部署任务寄宿站点JobHostSite
•	端口设置建议为：20170
•	应用池设置为永不回收
•	应用池选择”集成模式”
3.	部署任务服务站点JobServiceSite
•	端口设置建议为：20171
•	应用池选择”集成模式”

注：所有发布文件已经上传在百度云盘里，（需要密码验证）。
源代码在Coding.NET上，如要需要，可以在Coding.NET上分配代码管理权限。
 
