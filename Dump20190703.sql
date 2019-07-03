CREATE DATABASE  IF NOT EXISTS `dbOPSRS` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dbOPSRS`;
-- MySQL dump 10.13  Distrib 8.0.16, for macos10.14 (x86_64)
--
-- Host: 127.0.0.1    Database: dbOPSRS
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `control`
--

DROP TABLE IF EXISTS `control`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `control` (
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL,
  `description` varchar(45) NOT NULL,
  PRIMARY KEY (`page`,`controlId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `control`
--

LOCK TABLES `control` WRITE;
/*!40000 ALTER TABLE `control` DISABLE KEYS */;
INSERT INTO `control` VALUES ('Correct ROL',900,''),('Customer Management',1100,''),('Edit Order',210,''),('Edit Stock',510,''),('Generate Report',800,''),('New Order',100,''),('New Purchase Order',600,''),('New Stock',400,''),('Receive Goods',700,''),('Report Defective',300,''),('Role Control',1200,''),('Search Order',200,''),('Search Order',201,'Generater DIS'),('Search Order',202,'Generater Invoice '),('Search Stock',500,''),('Staff Management',1000,'');
/*!40000 ALTER TABLE `control` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlRole`
--

DROP TABLE IF EXISTS `controlRole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `controlRole` (
  `roleId` int(2) NOT NULL,
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL,
  `disabled` tinyint(1) NOT NULL,
  PRIMARY KEY (`roleId`,`page`,`controlId`),
  KEY `controlRole_page_fk` (`page`),
  KEY `controlRole_page_controlId_fk` (`page`,`controlId`),
  CONSTRAINT `controlRole_page_controlId_fk` FOREIGN KEY (`page`, `controlId`) REFERENCES `control` (`page`, `controlId`),
  CONSTRAINT `controlRole_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlRole`
--

LOCK TABLES `controlRole` WRITE;
/*!40000 ALTER TABLE `controlRole` DISABLE KEYS */;
/*!40000 ALTER TABLE `controlRole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer` (
  `custId` int(11) NOT NULL AUTO_INCREMENT,
  `custName` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `companyName` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `phone` varchar(8) NOT NULL,
  PRIMARY KEY (`custId`),
  UNIQUE KEY `custId_UNIQUE` (`custId`)
) ENGINE=InnoDB AUTO_INCREMENT=100003 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (100001,'Ken','LWL','IVE','lwl@ive.com','88888888'),(100002,'Peter','DI','IVE','di@ive.com','77777777');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `defective`
--

DROP TABLE IF EXISTS `defective`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `defective` (
  `defectiveId` int(11) NOT NULL AUTO_INCREMENT,
  `staffId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `qty` int(11) NOT NULL,
  `reason` varchar(45) NOT NULL,
  `remark` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`defectiveId`),
  UNIQUE KEY `defectiveId_UNIQUE` (`defectiveId`),
  KEY `defective_productId_fk_idx` (`productId`),
  KEY `defective_staffId_fk_idx` (`staffId`),
  CONSTRAINT `defective_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`),
  CONSTRAINT `defective_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`)
) ENGINE=InnoDB AUTO_INCREMENT=100001 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `defective`
--

LOCK TABLES `defective` WRITE;
/*!40000 ALTER TABLE `defective` DISABLE KEYS */;
/*!40000 ALTER TABLE `defective` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `order` (
  `orderId` int(11) NOT NULL AUTO_INCREMENT,
  `staffId` int(11) NOT NULL,
  `custId` int(11) NOT NULL,
  `status` varchar(45) NOT NULL,
  `date` datetime NOT NULL,
  `deliveryDate` date NOT NULL,
  `shippingAddress` varchar(45) NOT NULL,
  `totalAmount` double NOT NULL,
  `remark` text,
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `orderId_UNIQUE` (`orderId`),
  KEY `order_staffId_fk` (`staffId`),
  KEY `order_custid_fk_idx` (`custId`),
  CONSTRAINT `order_custId_fk` FOREIGN KEY (`custId`) REFERENCES `customer` (`custId`),
  CONSTRAINT `order_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`)
) ENGINE=InnoDB AUTO_INCREMENT=100021 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (100001,100001,100001,'Finish','2019-06-05 12:12:12','2019-06-09','LWL',2000,NULL),(100002,100001,100001,'Creation','2019-06-06 12:45:32','2019-07-12','LWL',50400,NULL),(100003,100002,100002,'Creation','2019-06-11 12:43:23','2019-06-15','LWL',3000,'Please quickly'),(100004,100001,100002,'Creation','2019-06-14 05:00:47','2019-06-15','l',40,'Remark'),(100005,100001,100002,'Creation','2019-06-14 05:04:52','2019-06-15','a',40,'Remark'),(100006,100001,100002,'Creation','2019-06-14 05:08:56','2019-06-15','b',480,'Remark'),(100007,100001,100002,'Creation','2019-06-14 05:11:16','2019-06-25','c',40,'Remark'),(100008,100001,100002,'Creation','2019-06-14 05:15:22','2019-06-19','c',40,'Remark'),(100009,100001,100002,'Creation','2019-06-14 05:16:55','2019-06-15','d',40,'Remark'),(100010,100001,100002,'Creation','2019-06-14 05:17:44','2019-06-26','e',40,'Remark'),(100011,100001,100001,'Creation','2019-06-14 05:21:11','2019-06-15','f',480,'Remark'),(100012,100001,100002,'Creation','2019-06-14 05:24:17','2019-06-15','g',40,'Remark'),(100013,100001,100001,'Creation','2019-06-14 05:26:22','2019-06-15','h',50,'Remark'),(100014,100001,100001,'Creation','2019-06-14 05:27:36','2019-06-15','i',40,'Remark'),(100015,100001,100001,'Creation','2019-06-14 05:40:03','2019-06-15','j',5000,'Remark'),(100016,100001,100001,'Creation','2019-06-14 05:45:53','2019-06-19','k',40,'Remark'),(100017,100001,100001,'Creation','2019-06-14 05:47:38','2019-06-26','q',40,'Remark'),(100018,100001,100001,'Creation','2019-06-14 05:52:14','2019-06-26','w',40,'Remark'),(100019,100001,100001,'Creation','2019-06-14 05:58:21','2019-06-15','qq',40,'Remark'),(100020,100001,100001,'Creation','2019-06-14 06:08:33','2019-06-30','ww',40,'Remark');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderProduct`
--

DROP TABLE IF EXISTS `orderProduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orderProduct` (
  `orderId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `despatched` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`orderId`,`productId`),
  KEY `orderProduct_productId_fk_idx` (`productId`),
  CONSTRAINT `orderProduct_orderId_fk` FOREIGN KEY (`orderId`) REFERENCES `order` (`orderId`),
  CONSTRAINT `orderProduct_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderProduct`
--

LOCK TABLES `orderProduct` WRITE;
/*!40000 ALTER TABLE `orderProduct` DISABLE KEYS */;
INSERT INTO `orderProduct` VALUES (100001,100001,50,0),(100002,100001,10,0),(100002,100003,10,0),(100003,100004,100,0),(100004,100001,1,0),(100005,100001,1,0),(100006,100001,12,0),(100007,100001,1,0),(100008,100001,1,0),(100009,100001,1,0),(100010,100001,1,0),(100011,100001,12,0),(100012,100001,1,0),(100013,100002,1,0),(100014,100001,1,0),(100015,100003,1,0),(100016,100001,1,0),(100017,100001,1,0),(100018,100001,1,0),(100019,100001,1,0),(100020,100001,1,0);
/*!40000 ALTER TABLE `orderProduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `product` (
  `productId` int(11) NOT NULL AUTO_INCREMENT,
  `type` char(1) NOT NULL,
  `brand` varchar(45) NOT NULL,
  `productName` varchar(45) NOT NULL,
  `description` varchar(45) NOT NULL,
  `atHand` int(11) NOT NULL,
  `onHand` int(11) NOT NULL,
  `inHand` int(11) NOT NULL,
  `price` double NOT NULL,
  `leadTime` int(3) DEFAULT NULL,
  `safetyStock` int(11) DEFAULT NULL,
  `reorderPoint` int(11) DEFAULT NULL,
  PRIMARY KEY (`productId`),
  UNIQUE KEY `productId_UNIQUE` (`productId`),
  UNIQUE KEY `productName_UNIQUE` (`productName`)
) ENGINE=InnoDB AUTO_INCREMENT=100007 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (100001,'A','Self','Metal03','The metal 03',0,1000,1000,40,NULL,NULL,NULL),(100002,'A','Self','Metal01','The first metal',0,1000,1000,50,NULL,NULL,NULL),(100003,'B','Self','Engine01','The major engine',0,1000,1000,5000,NULL,NULL,NULL),(100004,'C','Self','Bulb01','The smail bulb',0,1000,1000,30,NULL,NULL,NULL),(100005,'D','Self','Metal Button 01','The smaill metal button',0,1000,1000,5,NULL,NULL,NULL),(100006,'A','Self','Metal02','The metal 02',0,1000,1000,30,NULL,NULL,NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasingOrder`
--

DROP TABLE IF EXISTS `purchasingOrder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchasingOrder` (
  `poId` int(11) NOT NULL AUTO_INCREMENT,
  `staffId` int(11) NOT NULL,
  `date` date NOT NULL,
  `deliveryDate` date NOT NULL,
  `address` varchar(45) NOT NULL,
  `totalAmount` double NOT NULL,
  `remark` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`poId`),
  UNIQUE KEY `poId_UNIQUE` (`poId`),
  KEY `purchasingOrder_staffId_fk_idx` (`staffId`),
  CONSTRAINT `purchasingOrder_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`)
) ENGINE=InnoDB AUTO_INCREMENT=100001 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasingOrder`
--

LOCK TABLES `purchasingOrder` WRITE;
/*!40000 ALTER TABLE `purchasingOrder` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchasingOrder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasingOrderProduct`
--

DROP TABLE IF EXISTS `purchasingOrderProduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchasingOrderProduct` (
  `poId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`poId`),
  KEY `purchasingOrderProduct_productId_fk_idx` (`productId`),
  CONSTRAINT `purchasingOrderProduct_poId_fk` FOREIGN KEY (`poId`) REFERENCES `purchasingorder` (`poId`),
  CONSTRAINT `purchasingOrderProduct_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasingOrderProduct`
--

LOCK TABLES `purchasingOrderProduct` WRITE;
/*!40000 ALTER TABLE `purchasingOrderProduct` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchasingOrderProduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `role` (
  `roleId` int(2) NOT NULL,
  `roleName` varchar(45) NOT NULL,
  PRIMARY KEY (`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Administrator'),(2,'Financial Accountant'),(3,'Salesmen'),(4,'Storemen'),(5,'Purchasing Manager'),(6,'Sales Office Manager'),(7,'Spare Despatcher');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `staff` (
  `staffId` int(11) NOT NULL AUTO_INCREMENT,
  `roleId` int(2) NOT NULL,
  `staffName` varchar(20) NOT NULL,
  `pwd` varchar(20) NOT NULL DEFAULT '000000',
  `available` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`staffId`),
  UNIQUE KEY `staffId_UNIQUE` (`staffId`),
  KEY `staff_roleId_fk_idx` (`roleId`),
  CONSTRAINT `staff_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`)
) ENGINE=InnoDB AUTO_INCREMENT=100013 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (100001,1,'John','123456',1),(100002,2,'Andy','abcdef',1),(100003,3,'May','123456',1),(100004,4,'Joey','123456',1),(100005,5,'Peter','412431',1),(100006,6,'Juno','232142',1),(100007,7,'Ian','adfsnal',1),(100008,1,'Ivan','weqweq',1),(100009,2,'Ada','abcdefg',1),(100010,3,'Alva','12dsasw',1),(100011,4,'Bonnie','123456',1),(100012,5,'Ava','123456',1);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-07-03 19:32:35
