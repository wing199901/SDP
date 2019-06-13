CREATE DATABASE  IF NOT EXISTS `dbOPSRS` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */ /*!80016 DEFAULT ENCRYPTION='N' */;
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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer` (
  `custId` int(6) NOT NULL AUTO_INCREMENT,
  `custName` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `address` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `companyName` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `email` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `phone` varchar(8) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`custId`),
  UNIQUE KEY `custId_UNIQUE` (`custId`)
) ENGINE=InnoDB AUTO_INCREMENT=100003 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
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
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `order` (
  `orderId` int(6) NOT NULL AUTO_INCREMENT,
  `staffId` int(6) NOT NULL,
  `custId` int(6) NOT NULL,
  `status` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `date` date NOT NULL,
  `deliveryDate` date NOT NULL,
  `shippingAddress` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `totalAmount` varchar(45) COLLATE utf8_bin NOT NULL,
  `remark` text CHARACTER SET utf8 COLLATE utf8_bin,
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `orderId_UNIQUE` (`orderId`),
  KEY `staffId_fk_idx` (`staffId`),
  KEY `custId_fk_idx` (`custId`),
  CONSTRAINT `custId_fk` FOREIGN KEY (`custId`) REFERENCES `customer` (`custId`),
  CONSTRAINT `staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`),
  CONSTRAINT `order_status_cc` CHECK ((`status` in (_utf8mb3'Creation',_utf8mb3'Reservation',_utf8mb3'Shipping',_utf8mb3'Deletion',_utf8mb3'Finish')))
) ENGINE=InnoDB AUTO_INCREMENT=100004 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (100001,100001,100001,'Finish','2019-06-01','2019-06-05','LWL','2000',NULL),(100002,100001,100001,'Creation','2019-06-11','2019-07-05','LWL','50400',NULL),(100003,100002,100002,'Creation','2019-06-12','2019-06-27','LWL','3000','Please quickly ');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderProduct`
--

DROP TABLE IF EXISTS `orderProduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orderProduct` (
  `orderid` int(6) NOT NULL,
  `productId` int(6) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`orderid`,`productId`),
  KEY `productId_fk_idx` (`productId`),
  CONSTRAINT `orderId_fk` FOREIGN KEY (`orderid`) REFERENCES `order` (`orderId`),
  CONSTRAINT `productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderProduct`
--

LOCK TABLES `orderProduct` WRITE;
/*!40000 ALTER TABLE `orderProduct` DISABLE KEYS */;
INSERT INTO `orderProduct` VALUES (100001,100001,50),(100002,100001,10),(100002,100003,10),(100003,100004,100);
/*!40000 ALTER TABLE `orderProduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `product` (
  `productId` int(6) NOT NULL AUTO_INCREMENT,
  `type` char(1) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `brand` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `productName` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Description` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `atHand` int(11) NOT NULL,
  `onHand` int(11) NOT NULL,
  `inHand` int(11) NOT NULL,
  `price` double NOT NULL,
  PRIMARY KEY (`productId`),
  UNIQUE KEY `productId_UNIQUE` (`productId`),
  UNIQUE KEY `productName_UNIQUE` (`productName`),
  CONSTRAINT `product_type_cc` CHECK ((`type` in (_utf8mb3'A',_utf8mb3'B',_utf8mb3'C',_utf8mb3'D')))
) ENGINE=InnoDB AUTO_INCREMENT=100007 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (100001,'A','Self','Metal03','The metal 03',0,1000,1000,40),(100002,'A','Self','Metal01','The first metal',0,1000,1000,50),(100003,'B','Self','Engine01','The major engine',0,1000,1000,5000),(100004,'C','Self','Bulb01','The smail bulb',0,1000,1000,30),(100005,'D','Self','Metal Button 01','The smaill metal button',0,1000,1000,5),(100006,'A','Self','Metal02','The metal 02',0,1000,1000,30);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `staff` (
  `staffId` int(6) NOT NULL AUTO_INCREMENT,
  `staffName` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `position` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `pwd` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `available` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`staffId`),
  UNIQUE KEY `staffId_UNIQUE` (`staffId`)
) ENGINE=InnoDB AUTO_INCREMENT=1000013 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (100001,'John','Goods Inwards Clerk','123456',1),(100002,'Andy','Spares Buyer','abcdef',1),(100003,'May','Purchasing Manager','123456',1),(100004,'Joey','Sales Manager','123456',1),(100005,'Peter','Sales Office Manager','412431',1),(100006,'Juno','Salesman','232142',1),(100007,'Ian','Despatch Clerk','adfsnal',1),(100008,'Ivan','Spare Parts Controller','weqweq',1),(100009,'Ada','Storemen','abcdefg',1),(100010,'Alva','Financial Accountant','12dsasw',1),(100011,'Ava','Storemen','314124',1),(100012,'Bonnie','Salesmen','123456',1);
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

-- Dump completed on 2019-06-13 23:14:20
