-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主機： localhost
-- 產生時間： 2019 年 07 月 02 日 13:25
-- 伺服器版本： 10.1.40-MariaDB
-- PHP 版本： 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `dbOPSRS`
--

-- --------------------------------------------------------

--
-- 資料表結構 `control`
--

CREATE TABLE `control` (
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL,
  `description` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `control`
--

INSERT INTO `control` (`page`, `controlId`, `description`) VALUES
('Correct ROL', 900, ''),
('Customer Management', 1100, ''),
('Edit Order', 210, ''),
('Edit Order', 211, 'Input actual quantity despatched'),
('Edit Order', 212, 'Update Order Status'),
('Edit Stock', 510, ''),
('Generate Report', 800, ''),
('New Order', 100, ''),
('New Purchase Order', 600, ''),
('New Stock', 400, ''),
('Receive Goods', 700, ''),
('Report Defective', 300, ''),
('Role Control', 1200, ''),
('Search Order', 200, ''),
('Search Order', 201, 'Generater DIS'),
('Search Order', 202, 'Generater Invoice '),
('Search Stock', 500, ''),
('Staff Management', 1000, '');

-- --------------------------------------------------------

--
-- 資料表結構 `controlRole`
--

CREATE TABLE `controlRole` (
  `roleId` int(2) NOT NULL,
  `page` varchar(30) NOT NULL,
  `controlId` int(2) NOT NULL,
  `disabled` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `controlRole`
--

INSERT INTO `controlRole` (`roleId`, `page`, `controlId`, `disabled`) VALUES
(1, 'Correct ROL', 900, 0),
(1, 'Customer Management', 1100, 0),
(1, 'Edit Order', 210, 0),
(1, 'Edit Order', 211, 0),
(1, 'Edit Order', 212, 0),
(1, 'Edit Stock', 510, 0),
(1, 'Generate Report', 800, 0),
(1, 'New Order', 100, 0),
(1, 'New Purchase Order', 600, 0),
(1, 'New Stock', 400, 0),
(1, 'Receive Goods', 700, 0),
(1, 'Report Defective', 300, 0),
(1, 'Role Control', 1200, 0),
(1, 'Search Order', 200, 0),
(1, 'Search Order', 201, 0),
(1, 'Search Order', 202, 0),
(1, 'Search Stock', 500, 0),
(1, 'Staff Management', 1000, 0),
(2, 'Correct ROL', 900, 1),
(2, 'Customer Management', 1100, 1),
(2, 'Edit Order', 210, 1),
(2, 'Edit Order', 211, 1),
(2, 'Edit Order', 212, 1),
(2, 'Edit Stock', 510, 1),
(2, 'Generate Report', 800, 0),
(2, 'New Order', 100, 1),
(2, 'New Purchase Order', 600, 1),
(2, 'New Stock', 400, 1),
(2, 'Receive Goods', 700, 1),
(2, 'Report Defective', 300, 1),
(2, 'Role Control', 1200, 1),
(2, 'Search Order', 200, 0),
(2, 'Search Order', 201, 1),
(2, 'Search Order', 202, 1),
(2, 'Search Stock', 500, 0),
(2, 'Staff Management', 1000, 1),
(3, 'Correct ROL', 900, 1),
(3, 'Customer Management', 1100, 1),
(3, 'Edit Order', 210, 0),
(3, 'Edit Order', 211, 0),
(3, 'Edit Order', 212, 0),
(3, 'Edit Stock', 510, 1),
(3, 'Generate Report', 800, 0),
(3, 'New Order', 100, 0),
(3, 'New Purchase Order', 600, 1),
(3, 'New Stock', 400, 1),
(3, 'Receive Goods', 700, 1),
(3, 'Report Defective', 300, 1),
(3, 'Role Control', 1200, 1),
(3, 'Search Order', 200, 0),
(3, 'Search Order', 201, 1),
(3, 'Search Order', 202, 0),
(3, 'Search Stock', 500, 0),
(3, 'Staff Management', 1000, 1),
(4, 'Correct ROL', 900, 1),
(4, 'Customer Management', 1100, 1),
(4, 'Edit Order', 210, 0),
(4, 'Edit Order', 211, 0),
(4, 'Edit Order', 212, 1),
(4, 'Edit Stock', 510, 1),
(4, 'Generate Report', 800, 0),
(4, 'New Order', 100, 1),
(4, 'New Purchase Order', 600, 1),
(4, 'New Stock', 400, 1),
(4, 'Receive Goods', 700, 0),
(4, 'Report Defective', 300, 0),
(4, 'Role Control', 1200, 1),
(4, 'Search Order', 200, 0),
(4, 'Search Order', 201, 0),
(4, 'Search Order', 202, 1),
(4, 'Search Stock', 500, 1),
(4, 'Staff Management', 1000, 1),
(5, 'Correct ROL', 900, 1),
(5, 'Customer Management', 1100, 1),
(5, 'Edit Order', 210, 1),
(5, 'Edit Order', 211, 1),
(5, 'Edit Order', 212, 1),
(5, 'Edit Stock', 510, 0),
(5, 'Generate Report', 800, 0),
(5, 'New Order', 100, 1),
(5, 'New Purchase Order', 600, 0),
(5, 'New Stock', 400, 0),
(5, 'Receive Goods', 700, 1),
(5, 'Report Defective', 300, 1),
(5, 'Role Control', 1200, 1),
(5, 'Search Order', 200, 1),
(5, 'Search Order', 201, 1),
(5, 'Search Order', 202, 1),
(5, 'Search Stock', 500, 0),
(5, 'Staff Management', 1000, 1),
(6, 'Correct ROL', 900, 0),
(6, 'Customer Management', 1100, 1),
(6, 'Edit Order', 210, 0),
(6, 'Edit Order', 211, 1),
(6, 'Edit Order', 212, 0),
(6, 'Edit Stock', 510, 1),
(6, 'Generate Report', 800, 0),
(6, 'New Order', 100, 0),
(6, 'New Purchase Order', 600, 0),
(6, 'New Stock', 400, 0),
(6, 'Receive Goods', 700, 1),
(6, 'Report Defective', 300, 1),
(6, 'Role Control', 1200, 1),
(6, 'Search Order', 200, 0),
(6, 'Search Order', 201, 1),
(6, 'Search Order', 202, 0),
(6, 'Search Stock', 500, 0),
(6, 'Staff Management', 1000, 1),
(7, 'Correct ROL', 900, 1),
(7, 'Customer Management', 1100, 1),
(7, 'Edit Order', 210, 0),
(7, 'Edit Order', 211, 1),
(7, 'Edit Order', 212, 0),
(7, 'Edit Stock', 510, 1),
(7, 'Generate Report', 800, 1),
(7, 'New Order', 100, 1),
(7, 'New Purchase Order', 600, 1),
(7, 'New Stock', 400, 1),
(7, 'Receive Goods', 700, 1),
(7, 'Report Defective', 300, 1),
(7, 'Role Control', 1200, 1),
(7, 'Search Order', 200, 0),
(7, 'Search Order', 201, 1),
(7, 'Search Order', 202, 0),
(7, 'Search Stock', 500, 1),
(7, 'Staff Management', 1000, 1);

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

CREATE TABLE `customer` (
  `custId` int(11) NOT NULL,
  `custName` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `companyName` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `phone` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`custId`, `custName`, `address`, `companyName`, `email`, `phone`) VALUES
(100001, 'Ken', 'LWL', 'IVE', 'lwl@ive.com', '88888888'),
(100002, 'Peter', 'DI', 'IVE', 'di@ive.com', '77777777');

-- --------------------------------------------------------

--
-- 資料表結構 `defective`
--

CREATE TABLE `defective` (
  `defectiveId` int(11) NOT NULL,
  `staffId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `qty` int(11) NOT NULL,
  `reason` varchar(45) NOT NULL,
  `remark` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `order`
--

CREATE TABLE `order` (
  `orderId` int(11) NOT NULL,
  `staffId` int(11) NOT NULL,
  `custId` int(11) NOT NULL,
  `status` varchar(45) NOT NULL,
  `date` datetime NOT NULL,
  `deliveryDate` date NOT NULL,
  `shippingAddress` varchar(45) NOT NULL,
  `totalAmount` double NOT NULL,
  `remark` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `order`
--

INSERT INTO `order` (`orderId`, `staffId`, `custId`, `status`, `date`, `deliveryDate`, `shippingAddress`, `totalAmount`, `remark`) VALUES
(100001, 100001, 100001, 'Finish', '2019-06-05 12:12:12', '2019-06-09', 'LWL', 2000, NULL),
(100002, 100001, 100001, 'Creation', '2019-06-06 12:45:32', '2019-07-12', 'LWL', 50400, NULL),
(100003, 100002, 100002, 'Creation', '2019-06-11 12:43:23', '2019-06-15', 'LWL', 3000, 'Please quickly'),
(100004, 100001, 100002, 'Creation', '2019-06-14 05:00:47', '2019-06-15', 'l', 40, 'Remark'),
(100005, 100001, 100002, 'Creation', '2019-06-14 05:04:52', '2019-06-15', 'a', 40, 'Remark'),
(100006, 100001, 100002, 'Creation', '2019-06-14 05:08:56', '2019-06-15', 'b', 480, 'Remark'),
(100007, 100001, 100002, 'Creation', '2019-06-14 05:11:16', '2019-06-25', 'c', 40, 'Remark'),
(100008, 100001, 100002, 'Creation', '2019-06-14 05:15:22', '2019-06-19', 'c', 40, 'Remark'),
(100009, 100001, 100002, 'Creation', '2019-06-14 05:16:55', '2019-06-15', 'd', 40, 'Remark'),
(100010, 100001, 100002, 'Creation', '2019-06-14 05:17:44', '2019-06-26', 'e', 40, 'Remark'),
(100011, 100001, 100001, 'Creation', '2019-06-14 05:21:11', '2019-06-15', 'f', 480, 'Remark'),
(100012, 100001, 100002, 'Creation', '2019-06-14 05:24:17', '2019-06-15', 'g', 40, 'Remark'),
(100013, 100001, 100001, 'Creation', '2019-06-14 05:26:22', '2019-06-15', 'h', 50, 'Remark'),
(100014, 100001, 100001, 'Creation', '2019-06-14 05:27:36', '2019-06-15', 'i', 40, 'Remark'),
(100015, 100001, 100001, 'Creation', '2019-06-14 05:40:03', '2019-06-15', 'j', 5000, 'Remark'),
(100016, 100001, 100001, 'Creation', '2019-06-14 05:45:53', '2019-06-19', 'k', 40, 'Remark'),
(100017, 100001, 100001, 'Creation', '2019-06-14 05:47:38', '2019-06-26', 'q', 40, 'Remark'),
(100018, 100001, 100001, 'Creation', '2019-06-14 05:52:14', '2019-06-26', 'w', 40, 'Remark'),
(100019, 100001, 100001, 'Creation', '2019-06-14 05:58:21', '2019-06-15', 'qq', 40, 'Remark'),
(100020, 100001, 100001, 'Creation', '2019-06-14 06:08:33', '2019-06-30', 'ww', 40, 'Remark');

-- --------------------------------------------------------

--
-- 資料表結構 `orderProduct`
--

CREATE TABLE `orderProduct` (
  `orderId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `orderProduct`
--

INSERT INTO `orderProduct` (`orderId`, `productId`, `qty`) VALUES
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
-- 資料表結構 `product`
--

CREATE TABLE `product` (
  `productId` int(11) NOT NULL,
  `type` char(1) NOT NULL,
  `brand` varchar(45) NOT NULL,
  `productName` varchar(45) NOT NULL,
  `Description` varchar(45) NOT NULL,
  `atHand` int(11) NOT NULL,
  `onHand` int(11) NOT NULL,
  `inHand` int(11) NOT NULL,
  `price` double NOT NULL,
  `leadTime` int(3) DEFAULT NULL,
  `safetyStock` int(11) DEFAULT NULL,
  `reorderPoint` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `product`
--

INSERT INTO `product` (`productId`, `type`, `brand`, `productName`, `Description`, `atHand`, `onHand`, `inHand`, `price`, `leadTime`, `safetyStock`, `reorderPoint`) VALUES
(100001, 'A', 'Self', 'Metal03', 'The metal 03', 0, 1000, 1000, 40, NULL, NULL, NULL),
(100002, 'A', 'Self', 'Metal01', 'The first metal', 0, 1000, 1000, 50, NULL, NULL, NULL),
(100003, 'B', 'Self', 'Engine01', 'The major engine', 0, 1000, 1000, 5000, NULL, NULL, NULL),
(100004, 'C', 'Self', 'Bulb01', 'The smail bulb', 0, 1000, 1000, 30, NULL, NULL, NULL),
(100005, 'D', 'Self', 'Metal Button 01', 'The smaill metal button', 0, 1000, 1000, 5, NULL, NULL, NULL),
(100006, 'A', 'Self', 'Metal02', 'The metal 02', 0, 1000, 1000, 30, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `purchasingOrder`
--

CREATE TABLE `purchasingOrder` (
  `poId` int(11) NOT NULL,
  `staffId` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `deliveryDate` date NOT NULL,
  `address` varchar(45) NOT NULL,
  `totalAmount` double NOT NULL,
  `remark` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `purchasingOrderProduct`
--

CREATE TABLE `purchasingOrderProduct` (
  `poId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `role`
--

CREATE TABLE `role` (
  `roleId` int(2) NOT NULL,
  `roleName` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `role`
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
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `staffId` int(11) NOT NULL,
  `roleId` int(2) NOT NULL,
  `staffName` varchar(20) NOT NULL,
  `pwd` varchar(20) NOT NULL DEFAULT '000000',
  `available` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `staff`
--

INSERT INTO `staff` (`staffId`, `roleId`, `staffName`, `pwd`, `available`) VALUES
(100001, 1, 'John', '123456', 1),
(100002, 2, 'Andy', 'abcdef', 1),
(100003, 3, 'May', '123456', 1),
(100004, 4, 'Joey', '123456', 1),
(100005, 5, 'Peter', '412431', 1),
(100006, 6, 'Juno', '232142', 1),
(100007, 7, 'Ian', 'adfsnal', 1),
(100008, 1, 'Ivan', 'weqweq', 1),
(100009, 2, 'Ada', 'abcdefg', 1),
(100010, 3, 'Alva', '12dsasw', 1),
(100011, 4, 'Bonnie', '123456', 1),
(100012, 5, 'Ava', '123456', 1);

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `control`
--
ALTER TABLE `control`
  ADD PRIMARY KEY (`page`,`controlId`);

--
-- 資料表索引 `controlRole`
--
ALTER TABLE `controlRole`
  ADD PRIMARY KEY (`roleId`,`page`,`controlId`),
  ADD KEY `controlRole_page_fk` (`page`),
  ADD KEY `controlRole_page_controlId_fk` (`page`,`controlId`);

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`custId`),
  ADD UNIQUE KEY `custId_UNIQUE` (`custId`);

--
-- 資料表索引 `defective`
--
ALTER TABLE `defective`
  ADD PRIMARY KEY (`defectiveId`),
  ADD UNIQUE KEY `defectiveId_UNIQUE` (`defectiveId`),
  ADD KEY `defective_productId_fk_idx` (`productId`),
  ADD KEY `defective_staffId_fk_idx` (`staffId`);

--
-- 資料表索引 `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderId`),
  ADD UNIQUE KEY `orderId_UNIQUE` (`orderId`),
  ADD KEY `order_staffId_fk` (`staffId`),
  ADD KEY `order_custid_fk_idx` (`custId`);

--
-- 資料表索引 `orderProduct`
--
ALTER TABLE `orderProduct`
  ADD PRIMARY KEY (`orderId`,`productId`),
  ADD KEY `orderProduct_productId_fk_idx` (`productId`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productId`),
  ADD UNIQUE KEY `productId_UNIQUE` (`productId`),
  ADD UNIQUE KEY `productName_UNIQUE` (`productName`);

--
-- 資料表索引 `purchasingOrder`
--
ALTER TABLE `purchasingOrder`
  ADD PRIMARY KEY (`poId`),
  ADD UNIQUE KEY `poId_UNIQUE` (`poId`),
  ADD KEY `purchasingOrder_staffId_fk_idx` (`staffId`);

--
-- 資料表索引 `purchasingOrderProduct`
--
ALTER TABLE `purchasingOrderProduct`
  ADD PRIMARY KEY (`poId`),
  ADD KEY `purchasingOrderProduct_productId_fk_idx` (`productId`);

--
-- 資料表索引 `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`roleId`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staffId`),
  ADD UNIQUE KEY `staffId_UNIQUE` (`staffId`),
  ADD KEY `staff_roleId_fk_idx` (`roleId`);

--
-- 在傾印的資料表使用自動增長(AUTO_INCREMENT)
--

--
-- 使用資料表自動增長(AUTO_INCREMENT) `customer`
--
ALTER TABLE `customer`
  MODIFY `custId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100003;

--
-- 使用資料表自動增長(AUTO_INCREMENT) `defective`
--
ALTER TABLE `defective`
  MODIFY `defectiveId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100001;

--
-- 使用資料表自動增長(AUTO_INCREMENT) `order`
--
ALTER TABLE `order`
  MODIFY `orderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100021;

--
-- 使用資料表自動增長(AUTO_INCREMENT) `product`
--
ALTER TABLE `product`
  MODIFY `productId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100007;

--
-- 使用資料表自動增長(AUTO_INCREMENT) `purchasingOrder`
--
ALTER TABLE `purchasingOrder`
  MODIFY `poId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100001;

--
-- 使用資料表自動增長(AUTO_INCREMENT) `staff`
--
ALTER TABLE `staff`
  MODIFY `staffId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100013;

--
-- 已傾印資料表的限制(constraint)
--

--
-- 資料表的限制(constraint) `controlRole`
--
ALTER TABLE `controlRole`
  ADD CONSTRAINT `controlRole_page_controlId_fk` FOREIGN KEY (`page`,`controlId`) REFERENCES `control` (`page`, `controlId`),
  ADD CONSTRAINT `controlRole_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`);

--
-- 資料表的限制(constraint) `defective`
--
ALTER TABLE `defective`
  ADD CONSTRAINT `defective_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`),
  ADD CONSTRAINT `defective_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`);

--
-- 資料表的限制(constraint) `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_custId_fk` FOREIGN KEY (`custId`) REFERENCES `customer` (`custId`),
  ADD CONSTRAINT `order_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`);

--
-- 資料表的限制(constraint) `orderProduct`
--
ALTER TABLE `orderProduct`
  ADD CONSTRAINT `orderProduct_orderId_fk` FOREIGN KEY (`orderId`) REFERENCES `order` (`orderId`),
  ADD CONSTRAINT `orderProduct_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`);

--
-- 資料表的限制(constraint) `purchasingOrder`
--
ALTER TABLE `purchasingOrder`
  ADD CONSTRAINT `purchasingOrder_staffId_fk` FOREIGN KEY (`staffId`) REFERENCES `staff` (`staffId`);

--
-- 資料表的限制(constraint) `purchasingOrderProduct`
--
ALTER TABLE `purchasingOrderProduct`
  ADD CONSTRAINT `purchasingOrderProduct_poId_fk` FOREIGN KEY (`poId`) REFERENCES `purchasingorder` (`poId`),
  ADD CONSTRAINT `purchasingOrderProduct_productId_fk` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`);

--
-- 資料表的限制(constraint) `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_roleId_fk` FOREIGN KEY (`roleId`) REFERENCES `role` (`roleId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
