-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jul 01, 2019 at 01:34 PM
-- Server version: 10.1.40-MariaDB
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbOPSRS`
--
CREATE DATABASE IF NOT EXISTS `dbOPSRS` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbOPSRS`;

-- --------------------------------------------------------

--
-- Table structure for table `control`
--

CREATE TABLE `control` (
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `controlRole`
--

CREATE TABLE `controlRole` (
  `roleId` int(2) NOT NULL,
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL,
  `invisible` tinyint(1) NOT NULL,
  `disabled` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `custId` int(6) NOT NULL,
  `custName` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `address` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `companyName` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `email` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `phone` varchar(8) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`custId`, `custName`, `address`, `companyName`, `email`, `phone`) VALUES
(100001, 'Ken', 'LWL', 'IVE', 'lwl@ive.com', '88888888'),
(100002, 'Peter', 'DI', 'IVE', 'di@ive.com', '77777777');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderId` int(6) NOT NULL,
  `staffId` int(6) NOT NULL,
  `custId` int(6) NOT NULL,
  `status` varchar(45) COLLATE utf8_bin NOT NULL,
  `date` datetime NOT NULL,
  `deliveryDate` date NOT NULL,
  `shippingAddress` varchar(45) COLLATE utf8_bin NOT NULL,
  `totalAmount` varchar(45) COLLATE utf8_bin NOT NULL,
  `remark` text COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`orderId`, `staffId`, `custId`, `status`, `date`, `deliveryDate`, `shippingAddress`, `totalAmount`, `remark`) VALUES
(100001, 100001, 100001, 'Finish', '2019-06-05 12:12:12', '2019-06-09', 'LWL', '2000', NULL),
(100002, 100001, 100001, 'Creation', '2019-06-06 12:45:32', '2019-07-12', 'LWL', '50400', NULL),
(100003, 100002, 100002, 'Creation', '2019-06-11 12:43:23', '2019-06-15', 'LWL', '3000', 'Please quickly'),
(100004, 100001, 100003, 'Creation', '2019-06-14 05:00:47', '2019-06-15', 'l', '40', 'Remark'),
(100005, 100001, 100004, 'Creation', '2019-06-14 05:04:52', '2019-06-15', 'a', '40', 'Remark'),
(100006, 100001, 100005, 'Creation', '2019-06-14 05:08:56', '2019-06-15', 'b', '480', 'Remark'),
(100007, 100001, 100006, 'Creation', '2019-06-14 05:11:16', '2019-06-25', 'c', '40', 'Remark'),
(100008, 100001, 100006, 'Creation', '2019-06-14 05:15:22', '2019-06-19', 'c', '40', 'Remark'),
(100009, 100001, 100007, 'Creation', '2019-06-14 05:16:55', '2019-06-15', 'd', '40', 'Remark'),
(100010, 100001, 100008, 'Creation', '2019-06-14 05:17:44', '2019-06-26', 'e', '40', 'Remark'),
(100011, 100001, 100009, 'Creation', '2019-06-14 05:21:11', '2019-06-15', 'f', '480', 'Remark'),
(100012, 100001, 100010, 'Creation', '2019-06-14 05:24:17', '2019-06-15', 'g', '40', 'Remark'),
(100013, 100001, 100011, 'Creation', '2019-06-14 05:26:22', '2019-06-15', 'h', '50', 'Remark'),
(100014, 100001, 100012, 'Creation', '2019-06-14 05:27:36', '2019-06-15', 'i', '40', 'Remark'),
(100015, 100001, 100013, 'Creation', '2019-06-14 05:40:03', '2019-06-15', 'j', '5000', 'Remark'),
(100016, 100001, 100014, 'Creation', '2019-06-14 05:45:53', '2019-06-19', 'k', '40', 'Remark'),
(100017, 100001, 100015, 'Creation', '2019-06-14 05:47:38', '2019-06-26', 'q', '40', 'Remark'),
(100018, 100001, 100016, 'Creation', '2019-06-14 05:52:14', '2019-06-26', 'w', '40', 'Remark'),
(100019, 100001, 100017, 'Creation', '2019-06-14 05:58:21', '2019-06-15', 'qq', '40', 'Remark'),
(100020, 100001, 100018, 'Creation', '2019-06-14 06:08:33', '2019-06-30', 'ww', '40', 'Remark');

-- --------------------------------------------------------

--
-- Table structure for table `orderProduct`
--

CREATE TABLE `orderProduct` (
  `orderid` int(6) NOT NULL,
  `productId` int(6) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `orderProduct`
--

INSERT INTO `orderProduct` (`orderid`, `productId`, `qty`) VALUES
(100001, 100001, 50),
(100002, 100001, 10),
(100002, 100003, 10),
(100003, 100004, 100),
(100004, 100001, 1),
(100005, 100001, 1),
(100006, 100001, 12),
(100007, 100001, 1),
(100008, 100001, 1),
(100009, 100001, 1),
(100010, 100001, 1),
(100011, 100001, 12),
(100012, 100001, 1),
(100013, 100002, 1),
(100014, 100001, 1),
(100015, 100003, 1),
(100016, 100001, 1),
(100017, 100001, 1),
(100018, 100001, 1),
(100019, 100001, 1),
(100020, 100001, 1);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `productId` int(6) NOT NULL,
  `type` char(1) COLLATE utf8_bin NOT NULL,
  `brand` varchar(45) COLLATE utf8_bin NOT NULL,
  `productName` varchar(45) COLLATE utf8_bin NOT NULL,
  `Description` varchar(45) COLLATE utf8_bin NOT NULL,
  `atHand` int(11) NOT NULL,
  `onHand` int(11) NOT NULL,
  `inHand` int(11) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productId`, `type`, `brand`, `productName`, `Description`, `atHand`, `onHand`, `inHand`, `price`) VALUES
(100001, 'A', 'Self', 'Metal03', 'The metal 03', 0, 1000, 1000, 40),
(100002, 'A', 'Self', 'Metal01', 'The first metal', 0, 1000, 1000, 50),
(100003, 'B', 'Self', 'Engine01', 'The major engine', 0, 1000, 1000, 5000),
(100004, 'C', 'Self', 'Bulb01', 'The smail bulb', 0, 1000, 1000, 30),
(100005, 'D', 'Self', 'Metal Button 01', 'The smaill metal button', 0, 1000, 1000, 5),
(100006, 'A', 'Self', 'Metal02', 'The metal 02', 0, 1000, 1000, 30);

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `roleId` int(2) NOT NULL,
  `roleName` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`roleId`, `roleName`) VALUES
(1, 'Administrator'),
(2, 'Financial Accountant'),
(3, 'Salesmen'),
(4, 'Storemen'),
(5, 'Purchasing Manager'),
(6, 'Sales Office Manager'),
(7, 'Spare Despatcher');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staffId` int(11) NOT NULL,
  `staffName` varchar(20) COLLATE utf8_bin NOT NULL,
  `pwd` varchar(20) COLLATE utf8_bin NOT NULL DEFAULT '000000',
  `available` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffId`, `staffName`, `pwd`, `available`) VALUES
(100001, 'John', '123456', 1),
(100002, 'Andy', 'abcdef', 1),
(100003, 'May', '123456', 1),
(100004, 'Joey', '123456', 1),
(100005, 'Peter', '412431', 1),
(100006, 'Juno', '232142', 1),
(100007, 'Ian', 'adfsnal', 1),
(100008, 'Ivan', 'weqweq', 1),
(100009, 'Ada', 'abcdefg', 1),
(100010, 'Alva', '12dsasw', 1),
(100011, 'Bonnie', '123456', 1),
(100012, 'Ava', '123456', 1);

-- --------------------------------------------------------

--
-- Table structure for table `staffRole`
--

CREATE TABLE `staffRole` (
  `staffId` int(11) NOT NULL,
  `roleId` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staffRole`
--

INSERT INTO `staffRole` (`staffId`, `roleId`) VALUES
(100001, 1),
(100002, 2),
(100003, 3),
(100004, 4),
(100005, 5),
(100006, 5),
(100006, 6),
(100007, 7),
(100008, 1),
(100009, 2),
(100010, 3),
(100011, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `control`
--
ALTER TABLE `control`
  ADD PRIMARY KEY (`page`,`controlId`);

--
-- Indexes for table `controlRole`
--
ALTER TABLE `controlRole`
  ADD PRIMARY KEY (`roleId`,`page`,`controlId`),
  ADD KEY `controlRole_page_fk` (`page`),
  ADD KEY `controlRole_page_controlId_fk` (`page`,`controlId`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`custId`),
  ADD UNIQUE KEY `custId_UNIQUE` (`custId`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderId`),
  ADD UNIQUE KEY `orderId_UNIQUE` (`orderId`);

--
-- Indexes for table `orderProduct`
--
ALTER TABLE `orderProduct`
  ADD PRIMARY KEY (`orderid`,`productId`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productId`),
  ADD UNIQUE KEY `productId_UNIQUE` (`productId`),
  ADD UNIQUE KEY `productName_UNIQUE` (`productName`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`roleId`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staffId`),
  ADD UNIQUE KEY `staffId_UNIQUE` (`staffId`);

--
-- Indexes for table `staffRole`
--
ALTER TABLE `staffRole`
  ADD PRIMARY KEY (`staffId`,`roleId`),
  ADD KEY `staffRole_roleId_fk` (`roleId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `custId` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100019;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `orderId` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100021;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `productId` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100007;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `staffId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100013;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `controlRole`
--
ALTER TABLE `controlRole`
  ADD CONSTRAINT `controlRole_page_controlId_fk` FOREIGN KEY (`page`,`controlId`) REFERENCES `control` (`page`, `controlId`),
  ADD CONSTRAINT `controlRole_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`);

--
-- Constraints for table `staffRole`
--
ALTER TABLE `staffRole`
  ADD CONSTRAINT `staffRole_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`),
  ADD CONSTRAINT `staffRole_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
