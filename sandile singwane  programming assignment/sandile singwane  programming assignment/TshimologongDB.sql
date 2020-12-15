/*
SQLyog Community Edition- MySQL GUI v5.22a
Host - 5.1.41 : Database - tshimologongdb
*********************************************************************
Server version : 5.1.41
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `tshimologongdb`;

USE `tshimologongdb`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `tblfood` */

DROP TABLE IF EXISTS `tblfood`;

CREATE TABLE `tblfood` (
  `food_id` int(10) NOT NULL AUTO_INCREMENT,
  `food_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`food_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tblfood` */

insert  into `tblfood`(`food_id`,`food_name`) values (1,'Pizza'),(2,'Pasta'),(3,'Pap and Wors'),(4,'Chicken stir fry'),(5,'Beef stir fry'),(6,'Other');

/*Table structure for table `userdetail` */

DROP TABLE IF EXISTS `userdetail`;

CREATE TABLE `userdetail` (
  `s_id` int(10) NOT NULL AUTO_INCREMENT,
  `surname` varchar(30) DEFAULT NULL,
  `fName` varchar(30) DEFAULT NULL,
  `contact` int(10) DEFAULT NULL,
  `date` varchar(30) DEFAULT NULL,
  `age` varchar(10) DEFAULT NULL,
  `foodChoice` varchar(100) DEFAULT NULL,
  `eatOut` varchar(100) DEFAULT NULL,
  `watchMovie` varchar(100) DEFAULT NULL,
  `watchTv` varchar(100) DEFAULT NULL,
  `listenRadio` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`s_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `userdetail` */

insert  into `userdetail`(`s_id`,`surname`,`fName`,`contact`,`date`,`age`,`foodChoice`,`eatOut`,`watchMovie`,`watchTv`,`listenRadio`) values (1,'singwane','sandile',791710877,'2020-12-13','24','Pizza	','1',' 2',' 2','1'),(2,'mthethwa','thabiso',789654125,'2020-12-14','25','Pizza	',' 2',' 2','4','5'),(3,'shabangu','alfred',821478954,'2020-12-14','23','Pasta	','1','1','1','1'),(4,'matseba','nelisiwe',654789415,'2020-12-15','22','Pap and Wors	','1','3','3','4'),(5,'lukhele','thato',789654122,'2020-12-14','28','Chicken stir fry	','1','1','1','1'),(6,'ndlovu','sharon',791203699,'2020-12-16','22','Other	',' 2',' 2','1','3'),(7,'simelane','derrick',789654125,'2020-12-15','19','Beef stir fry	',' 2','1',' 2','4');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
