-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主機： localhost
-- 產生時間： 2019 年 07 月 02 日 11:44
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

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `control`
--
ALTER TABLE `control`
  ADD PRIMARY KEY (`page`,`controlId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
