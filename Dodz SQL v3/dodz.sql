-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 21, 2022 at 02:10 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dodz`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `user_id` varchar(45) NOT NULL,
  `user_name` varchar(45) DEFAULT NULL,
  `user_pass` varchar(45) DEFAULT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `mname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `question` varchar(200) DEFAULT NULL,
  `answer` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`user_id`, `user_name`, `user_pass`, `fname`, `mname`, `lname`, `question`, `answer`) VALUES
('DS000', 'user1', 'user1pass', 'Paul Vincent', 'Herrera', 'admin', 'What is your favorite fruit?', 'Orange');

-- --------------------------------------------------------

--
-- Table structure for table `itemlist`
--

CREATE TABLE `itemlist` (
  `prod_num` int(11) NOT NULL,
  `prod_code` int(11) DEFAULT NULL,
  `prod_name` varchar(45) DEFAULT NULL,
  `prod_quantity` int(11) DEFAULT NULL,
  `prod_price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `products_id` int(11) NOT NULL,
  `products_code` varchar(45) DEFAULT NULL,
  `products_name` varchar(100) DEFAULT NULL,
  `products_quantity` varchar(45) DEFAULT NULL,
  `products_r` varchar(45) DEFAULT NULL,
  `products_price` varchar(45) DEFAULT NULL,
  `products_exp` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`products_id`, `products_code`, `products_name`, `products_quantity`, `products_r`, `products_price`, `products_exp`) VALUES
(2, '4800010075564', 'Cream-O Choco 33g', '100', '', '56', '23/09/22'),
(3, '4800092550911', 'Fudgee Barr Choco 40gx10pcs', '16', '', '60', '12/07/23'),
(24, '4800092660641', 'Choco Mucho Chocolate 33g', '8', '', '67', '18/08/22');

-- --------------------------------------------------------

--
-- Table structure for table `psession`
--

CREATE TABLE `psession` (
  `ID` int(11) NOT NULL,
  `Username` varchar(45) DEFAULT NULL,
  `Product_Name` varchar(45) DEFAULT NULL,
  `Session` varchar(45) DEFAULT NULL,
  `Time` varchar(45) DEFAULT NULL,
  `Date` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `psession`
--

INSERT INTO `psession` (`ID`, `Username`, `Product_Name`, `Session`, `Time`, `Date`) VALUES
(62, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Updated', '8:41:28 PM', 'March 7, 2022'),
(63, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Updated', '8:41:34 PM', 'March 7, 2022'),
(64, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Updated', '8:54:25 PM', 'March 7, 2022'),
(65, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Deleted', '9:11:44 PM', 'March 7, 2022'),
(66, 'admin', 'Choco Mucho Chocolate 33x10', 'Add Product', '9:11:59 PM', 'March 7, 2022'),
(67, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Updated', '9:12:06 PM', 'March 7, 2022'),
(68, 'admin', 'Cream-O Choco 33g', 'Product Updated', '9:15:48 PM', 'March 7, 2022'),
(69, 'admin', 'Cream-O Choco 33g', 'Product Updated', '9:17:46 PM', 'March 7, 2022'),
(70, 'admin', 'Choco Mucho Chocolate 33x10', 'Product Deleted', '9:30:15 PM', 'March 7, 2022'),
(71, 'admin', 'Choco Mucho 10x33g', 'Add Product', '9:31:12 PM', 'March 7, 2022'),
(72, 'admin', 'Choco Mucho Chocolate 33g', 'Add Product', '9:33:31 PM', 'March 7, 2022'),
(73, 'admin', 'Choco Mucho Chocolate 33g', 'Product Deleted', '9:35:42 PM', 'March 7, 2022'),
(74, 'admin', 'Choco Mucho Chocolate 33g', 'Add Product', '9:36:02 PM', 'March 7, 2022'),
(75, 'admin', 'Choco Mucho', 'Add Product', '9:41:35 PM', 'March 7, 2022'),
(76, 'admin', 'Choco Mucho Chocolate 33g', 'Product Updated', '9:50:56 PM', 'March 7, 2022'),
(77, 'admin', 'Choco Mucho Chocolate 33g', 'Product Updated', '9:52:01 PM', 'March 7, 2022'),
(78, 'admin', 'Choco Mucho Chocolate 33g', 'Product Updated', '9:52:46 PM', 'March 7, 2022'),
(79, 'admin', 'Choco Mucho Chocolate 33g', 'Product Deleted', '10:00:24 PM', 'March 7, 2022'),
(80, 'admin', 'Choco Mucho Chocolate 33g', 'Product Deleted', '10:00:24 PM', 'March 7, 2022'),
(81, 'admin', 'Choco', 'Add Product', '10:03:57 PM', 'March 7, 2022'),
(82, 'admin', 'Choco', 'Product Updated', '10:04:20 PM', 'March 7, 2022'),
(83, 'admin', 'Choco', 'Product Deleted', '10:04:34 PM', 'March 7, 2022'),
(84, 'admin', 'choco', 'Add Product', '10:07:21 PM', 'March 7, 2022'),
(85, 'admin', 'choco', 'Product Deleted', '10:07:23 PM', 'March 7, 2022'),
(86, 'admin', 'test', 'Add Product', '10:07:52 PM', 'March 7, 2022'),
(87, 'admin', 'test', 'Product Deleted', '10:08:03 PM', 'March 7, 2022'),
(88, 'admin', 'Choco Mucho Chocolate 33g', 'Add Product', '10:28:59 PM', 'March 7, 2022'),
(89, 'admin', 'Choco Mucho Chocolate 33g', 'Product Updated', '10:55:13 PM', 'March 7, 2022'),
(90, 'admin', 'Fudgee Bar Choco 10x40g', 'Product Updated', '10:58:20 PM', 'March 7, 2022'),
(91, 'admin', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '8:31:54 AM', 'March 8, 2022'),
(92, 'testusername', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '9:27:05 AM', 'March 8, 2022'),
(93, 'testusername', 'MAXX Candy Lemon', 'Add Product', '9:47:50 AM', 'March 8, 2022'),
(94, 'testusername', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '10:09:54 AM', 'March 8, 2022'),
(95, 'testusername', 'MAXX Candy Lemon', 'Product Updated', '10:11:13 AM', 'March 8, 2022'),
(96, 'testusername', 'MAXX Candy Lemon', 'Product Updated', '10:12:04 AM', 'March 8, 2022'),
(97, 'testusername', 'MAXX Candy Lemon', 'Product Updated', '10:13:03 AM', 'March 8, 2022'),
(98, 'testusername', 'MAXX Candy Lemon', 'Product Updated', '10:15:24 AM', 'March 8, 2022'),
(99, 'user1', 'MAXX Candy Lemon', 'Product Updated', '12:13:31 PM', 'March 8, 2022'),
(100, 'user1', 'MAXX Candy Lemon', 'Product Updated', '12:15:00 PM', 'March 8, 2022'),
(101, 'user1', 'MAXX Candy Lemon', 'Product Updated', '12:16:56 PM', 'March 8, 2022'),
(102, 'user1', 'MAXX Candy Lemon', 'Product Deleted', '12:17:00 PM', 'March 8, 2022'),
(103, 'user1', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '12:17:54 PM', 'March 8, 2022'),
(104, 'user1', 'test', 'Add Product', '12:27:00 PM', 'March 8, 2022'),
(105, 'user1', 'test', 'Product Updated', '12:30:15 PM', 'March 8, 2022'),
(106, 'user1', 'test', 'Product Updated', '12:31:22 PM', 'March 8, 2022'),
(107, 'user1', 'test2', 'Add Product', '7:01:04 PM', '03/11/22'),
(108, 'user1', 'test22', 'Add Product', '7:01:44 PM', '03/11/22'),
(109, 'user1', 'test2', 'Add Product', '7:03:46 PM', '03/11/22'),
(110, 'user1', 'test222', 'Add Product', '7:03:54 PM', '03/11/22'),
(111, 'user1', 'test222', 'Product Deleted', '7:07:26 PM', '03/11/22'),
(112, 'user1', 'test22', 'Product Deleted', '7:07:28 PM', '03/11/22'),
(113, 'user1', 'test2', 'Add Product', '7:07:40 PM', '03/11/22'),
(114, 'user1', 'test22', 'Add Product', '7:08:48 PM', '03/11/22'),
(115, 'user1', 'test22', 'Add Product', '7:09:06 PM', '03/11/22'),
(116, 'user1', 'test22', 'Product Deleted', '7:09:08 PM', '03/11/22'),
(117, 'user1', 'test2', 'Add Product', '7:09:19 PM', '03/11/22'),
(118, 'user1', 'test2', 'Add Product', '7:09:32 PM', '03/11/22'),
(119, 'user1', 'test2', 'Add Product', '7:10:20 PM', '03/11/22'),
(120, 'user1', 'test', 'Add Product', '7:10:29 PM', '03/11/22'),
(121, 'user1', 'test2', 'Add Product', '7:10:50 PM', '03/11/22'),
(122, 'user1', 'test2', 'Add Product', '7:10:59 PM', '03/11/22'),
(123, 'user1', 'test22', 'Add Product', '7:11:04 PM', '03/11/22'),
(124, 'user1', 'test2', 'Product Deleted', '7:11:48 PM', '03/11/22'),
(125, 'user1', 'test', 'Add Product', '7:12:07 PM', '03/11/22'),
(126, 'user1', 'test2', 'Add Product', '7:12:13 PM', '03/11/22'),
(127, 'user1', 'test2', 'Add Product', '7:13:48 PM', '03/11/22'),
(128, 'user1', 'test2', 'Add Product', '7:14:49 PM', '03/11/22'),
(129, 'user1', 'test2', 'Add Product', '7:17:21 PM', '03/11/22'),
(130, 'user1', 'test', 'Add Product', '7:17:28 PM', '03/11/22'),
(131, 'user1', 'test2', 'Add Product', '7:17:32 PM', '03/11/22'),
(132, 'user1', 'asd1', 'Add Product', '7:17:43 PM', '03/11/22'),
(133, 'user1', '1', 'Add Product', '7:18:03 PM', '03/11/22'),
(134, 'user1', '1', 'Add Product', '7:18:55 PM', '03/11/22'),
(135, 'user1', '1', 'Add Product', '7:19:07 PM', '03/11/22'),
(136, 'user1', '1', 'Add Product', '7:19:24 PM', '03/11/22'),
(137, 'user1', '', 'Product Deleted', '7:19:27 PM', '03/11/22'),
(138, 'user1', '1', 'Product Deleted', '7:19:32 PM', '03/11/22'),
(139, 'user1', '1', 'Add Product', '7:22:25 PM', '03/11/22'),
(140, 'user1', '1', 'Add Product', '7:22:33 PM', '03/11/22'),
(141, 'user1', '', 'Add Product', '7:23:11 PM', '03/11/22'),
(142, 'user1', '1', 'Add Product', '7:23:15 PM', '03/11/22'),
(143, 'user1', '1', 'Add Product', '7:23:33 PM', '03/11/22'),
(144, 'user1', '1', 'Add Product', '7:24:05 PM', '03/11/22'),
(145, 'user1', '1', 'Add Product', '7:25:18 PM', '03/11/22'),
(146, 'user1', '1', 'Add Product', '7:25:40 PM', '03/11/22'),
(147, 'user1', '', 'Product Deleted', '7:25:43 PM', '03/11/22'),
(148, 'user1', 'Choco Mucho Chocolate 33g', 'Add Product', '7:28:32 PM', '03/11/22'),
(149, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:29:21 PM', '03/11/22'),
(150, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:32:01 PM', '03/11/22'),
(151, 'user1', '1', 'Product Deleted', '12:33:37 PM', '03/12/22'),
(152, 'user1', '1', 'Product Deleted', '12:33:46 PM', '03/12/22'),
(153, 'user1', '12', 'Add Product', '12:35:01 PM', '03/12/22'),
(154, 'user1', '12', 'Add Product', '12:37:14 PM', '03/12/22'),
(155, 'user1', '1', 'Product Deleted', '12:41:54 PM', '03/12/22'),
(156, 'user1', 'test', 'Product Deleted', '12:41:56 PM', '03/12/22'),
(157, 'user1', '12', 'Add Product', '12:42:06 PM', '03/12/22'),
(158, 'user1', '12', 'Add Product', '12:42:13 PM', '03/12/22'),
(159, 'user1', '12', 'Add Product', '12:42:40 PM', '03/12/22'),
(160, 'user1', '12', 'Add Product', '12:42:48 PM', '03/12/22'),
(161, 'user1', '1', 'Add Product', '12:44:52 PM', '03/12/22'),
(162, 'user1', '1', 'Add Product', '12:45:00 PM', '03/12/22'),
(163, 'user1', '1', 'Add Product', '12:45:15 PM', '03/12/22'),
(164, 'user1', '1', 'Add Product', '12:45:25 PM', '03/12/22'),
(165, 'user1', '1', 'Add Product', '12:46:06 PM', '03/12/22'),
(166, 'user1', '1', 'Add Product', '12:46:48 PM', '03/12/22'),
(167, 'user1', '1', 'Add Product', '12:49:11 PM', '03/12/22'),
(168, 'user1', '1', 'Add Product', '12:52:37 PM', '03/12/22'),
(169, 'user1', '1', 'Add Product', '12:52:48 PM', '03/12/22'),
(170, 'user1', '12', 'Add Product', '12:53:02 PM', '03/12/22'),
(171, 'user1', '1', 'Product Deleted', '12:53:08 PM', '03/12/22'),
(172, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '12:59:40 PM', '03/12/22'),
(173, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '1:06:15 PM', '03/12/22'),
(174, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '1:06:41 PM', '03/12/22'),
(175, 'user1', 'testproduct', 'Add Product', '1:10:22 PM', '03/12/22'),
(176, 'user1', 'testproduct', 'Add Product', '1:10:48 PM', '03/12/22'),
(177, 'user1', 'testproduct', 'Add Product', '1:11:06 PM', '03/12/22'),
(178, 'user1', '100', 'Add Product', '1:11:25 PM', '03/12/22'),
(179, 'user1', '1000', 'Add Product', '1:15:55 PM', '03/12/22'),
(180, 'user1', '1000', 'Product Deleted', '1:16:00 PM', '03/12/22'),
(181, 'user1', '100', 'Add Product', '1:20:22 PM', '03/12/22'),
(182, 'user1', '100', 'Add Product', '1:20:49 PM', '03/12/22'),
(183, 'user1', '100', 'Add Product', '1:21:01 PM', '03/12/22'),
(184, 'user1', '100', 'Product Deleted', '1:21:03 PM', '03/12/22'),
(185, 'user1', '100', 'Product Deleted', '1:21:06 PM', '03/12/22'),
(186, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '1:23:38 PM', '03/12/22'),
(187, 'user1', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '1:23:44 PM', '03/12/22'),
(188, 'user1', 'Cream-O Choco 33g', 'Product Updated', '1:23:53 PM', '03/12/22'),
(189, 'user1', 'testproduct', 'Add Product', '1:24:23 PM', '03/12/22'),
(190, 'user1', 'testproduct', 'Add Product', '1:24:36 PM', '03/12/22'),
(191, 'user1', 'testproduct', 'Add Product', '1:25:17 PM', '03/12/22'),
(192, 'user1', '1231231', 'Add Product', '1:26:02 PM', '03/12/22'),
(193, 'user1', 'asdasd', 'Add Product', '1:26:19 PM', '03/12/22'),
(194, 'user1', 'asdasd', 'Add Product', '1:26:30 PM', '03/12/22'),
(195, 'user1', 'asdasd', 'Add Product', '1:26:46 PM', '03/12/22'),
(196, 'user1', 'asdasd', 'Add Product', '1:27:05 PM', '03/12/22'),
(197, 'user1', 'asdasd', 'Product Updated', '1:27:33 PM', '03/12/22'),
(198, 'user1', 'asdasd', 'Product Deleted', '7:24:21 PM', '03/21/22'),
(199, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:25:00 PM', '03/21/22'),
(200, 'user1', 'Fudgee Barr Choco 40gx10pcs', 'Product Updated', '7:25:10 PM', '03/21/22'),
(201, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:44:56 PM', '03/21/22'),
(202, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:52:11 PM', '03/21/22'),
(203, 'user1', 'Choco Mucho Chocolate 33g', 'Product Updated', '7:52:32 PM', '03/21/22');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sales_id` int(11) NOT NULL,
  `sales_date` varchar(45) DEFAULT NULL,
  `sales_profit` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sales_id`, `sales_date`, `sales_profit`) VALUES
(1, '01/04/22', '50000'),
(2, '01/05/22', '25000'),
(3, '02/01/22', '15000'),
(4, '02/03/22', '10000'),
(24, '03/07/22', '858'),
(25, '03/08/22', '250'),
(26, '03/21/22', '871');

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

CREATE TABLE `session` (
  `ses_id` int(11) NOT NULL,
  `user_name` varchar(45) DEFAULT NULL,
  `user_time` varchar(45) DEFAULT NULL,
  `user_date` varchar(45) DEFAULT NULL,
  `user_ses` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`ses_id`, `user_name`, `user_time`, `user_date`, `user_ses`) VALUES
(230, 'user1', '5:51:58 PM', 'March 6, 2022', 'Login'),
(231, 'user1', '5:52:08 PM', 'March 6, 2022', 'Logout'),
(232, 'user1', '7:50:11 PM', 'March 7, 2022', 'Login'),
(233, 'user1', '7:50:14 PM', 'March 7, 2022', 'Logout'),
(234, 'user1', '7:52:04 PM', 'March 7, 2022', 'Login'),
(235, 'user1', '7:52:59 PM', 'March 7, 2022', 'Login'),
(236, 'user1', '7:53:13 PM', 'March 7, 2022', 'Logout'),
(237, 'user1', '8:02:45 PM', 'March 7, 2022', 'Login'),
(238, 'user1', '8:03:30 PM', 'March 7, 2022', 'Logout'),
(239, 'user1', '8:14:23 PM', 'March 7, 2022', 'Login'),
(240, 'user1', '8:15:44 PM', 'March 7, 2022', 'Logout'),
(241, 'user1', '8:21:01 PM', 'March 7, 2022', 'Login'),
(242, 'user1', '8:21:29 PM', 'March 7, 2022', 'Logout'),
(243, 'user1', '8:41:16 PM', 'March 7, 2022', 'Login'),
(244, 'user1', '8:42:06 PM', 'March 7, 2022', 'Logout'),
(245, 'user1', '8:54:12 PM', 'March 7, 2022', 'Login'),
(246, 'user1', '8:54:26 PM', 'March 7, 2022', 'Logout'),
(247, 'user1', '9:04:47 PM', 'March 7, 2022', 'Login'),
(248, 'user1', '9:04:51 PM', 'March 7, 2022', 'Logout'),
(249, 'user1', '9:05:15 PM', 'March 7, 2022', 'Login'),
(250, 'user1', '9:07:48 PM', 'March 7, 2022', 'Login'),
(251, 'user1', '9:08:38 PM', 'March 7, 2022', 'Login'),
(252, 'user1', '9:10:58 PM', 'March 7, 2022', 'Login'),
(253, 'user1', '9:14:23 PM', 'March 7, 2022', 'Login'),
(254, 'user1', '9:16:01 PM', 'March 7, 2022', 'Logout'),
(255, 'user1', '9:16:05 PM', 'March 7, 2022', 'Login'),
(256, 'user1', '9:16:12 PM', 'March 7, 2022', 'Logout'),
(257, 'user1', '9:16:20 PM', 'March 7, 2022', 'Login'),
(258, 'user1', '9:16:56 PM', 'March 7, 2022', 'Logout'),
(259, 'user1', '9:17:25 PM', 'March 7, 2022', 'Login'),
(260, 'user1', '9:29:58 PM', 'March 7, 2022', 'Login'),
(261, 'user1', '9:31:56 PM', 'March 7, 2022', 'Login'),
(262, 'user1', '9:33:02 PM', 'March 7, 2022', 'Login'),
(263, 'user1', '9:35:34 PM', 'March 7, 2022', 'Login'),
(264, 'user1', '9:41:07 PM', 'March 7, 2022', 'Login'),
(265, 'user1', '9:41:39 PM', 'March 7, 2022', 'Logout'),
(266, 'user1', '9:50:08 PM', 'March 7, 2022', 'Login'),
(267, 'user1', '9:51:43 PM', 'March 7, 2022', 'Login'),
(268, 'user1', '9:52:28 PM', 'March 7, 2022', 'Login'),
(269, 'user1', '9:52:48 PM', 'March 7, 2022', 'Logout'),
(270, 'user1', '10:00:11 PM', 'March 7, 2022', 'Login'),
(271, 'user1', '10:00:27 PM', 'March 7, 2022', 'Logout'),
(272, 'user1', '10:03:26 PM', 'March 7, 2022', 'Login'),
(273, 'user1', '10:06:36 PM', 'March 7, 2022', 'Login'),
(274, 'user1', '10:25:27 PM', 'March 7, 2022', 'Logout'),
(275, 'user1', '10:27:43 PM', 'March 7, 2022', 'Login'),
(276, 'user1', '10:29:04 PM', 'March 7, 2022', 'Logout'),
(277, 'user1', '10:30:56 PM', 'March 7, 2022', 'Login'),
(278, 'user1', '10:34:32 PM', 'March 7, 2022', 'Logout'),
(279, 'user1', '10:35:37 PM', 'March 7, 2022', 'Login'),
(280, 'user1', '10:35:55 PM', 'March 7, 2022', 'Logout'),
(281, 'user1', '10:38:26 PM', 'March 7, 2022', 'Login'),
(282, 'user1', '10:38:40 PM', 'March 7, 2022', 'Logout'),
(283, 'user1', '10:46:27 PM', 'March 7, 2022', 'Login'),
(284, 'user1', '10:46:45 PM', 'March 7, 2022', 'Logout'),
(285, 'user1', '10:48:26 PM', 'March 7, 2022', 'Login'),
(286, 'user1', '10:48:47 PM', 'March 7, 2022', 'Logout'),
(287, 'user1', '10:51:13 PM', 'March 7, 2022', 'Login'),
(288, 'user1', '10:51:43 PM', 'March 7, 2022', 'Logout'),
(289, 'user1', '10:52:17 PM', 'March 7, 2022', 'Login'),
(290, 'user1', '10:52:43 PM', 'March 7, 2022', 'Logout'),
(291, 'user1', '10:53:44 PM', 'March 7, 2022', 'Login'),
(292, 'user1', '10:55:35 PM', 'March 7, 2022', 'Logout'),
(293, 'user1', '10:57:57 PM', 'March 7, 2022', 'Login'),
(294, 'user1', '10:59:07 PM', 'March 7, 2022', 'Logout'),
(295, 'user1', '10:59:43 PM', 'March 7, 2022', 'Login'),
(296, 'user1', '11:00:48 PM', 'March 7, 2022', 'Logout'),
(297, 'user1', '8:30:08 AM', 'March 8, 2022', 'Login'),
(298, 'user1', '8:32:07 AM', 'March 8, 2022', 'Logout'),
(299, 'user1', '8:46:46 AM', 'March 8, 2022', 'Login'),
(300, 'user1', '8:47:01 AM', 'March 8, 2022', 'Logout'),
(301, 'testusername', '9:11:25 AM', 'March 8, 2022', 'Login'),
(302, 'testusername', '9:16:21 AM', 'March 8, 2022', 'Logout'),
(303, 'testusername', '9:17:15 AM', 'March 8, 2022', 'Login'),
(304, 'testusername', '9:17:33 AM', 'March 8, 2022', 'Logout'),
(305, 'testusername', '9:20:39 AM', 'March 8, 2022', 'Login'),
(306, 'testusername', '9:20:53 AM', 'March 8, 2022', 'Logout'),
(307, 'testusername', '9:26:47 AM', 'March 8, 2022', 'Login'),
(308, 'testusername', '9:27:11 AM', 'March 8, 2022', 'Logout'),
(309, 'testusername', '9:45:33 AM', 'March 8, 2022', 'Login'),
(310, 'testusername', '9:48:31 AM', 'March 8, 2022', 'Logout'),
(311, 'testusername', '9:50:30 AM', 'March 8, 2022', 'Login'),
(312, 'testusername', '9:52:24 AM', 'March 8, 2022', 'Logout'),
(313, 'testusername', '10:09:22 AM', 'March 8, 2022', 'Login'),
(314, 'testusername', '10:10:01 AM', 'March 8, 2022', 'Logout'),
(315, 'testusername', '10:10:53 AM', 'March 8, 2022', 'Login'),
(316, 'testusername', '10:11:16 AM', 'March 8, 2022', 'Logout'),
(317, 'testusername', '10:11:52 AM', 'March 8, 2022', 'Login'),
(318, 'testusername', '10:12:07 AM', 'March 8, 2022', 'Logout'),
(319, 'testusername', '10:12:53 AM', 'March 8, 2022', 'Login'),
(320, 'testusername', '10:13:05 AM', 'March 8, 2022', 'Logout'),
(321, 'testusername', '10:15:05 AM', 'March 8, 2022', 'Login'),
(322, 'testusername', '10:15:26 AM', 'March 8, 2022', 'Logout'),
(323, 'user1', '12:12:58 PM', 'March 8, 2022', 'Login'),
(324, 'user1', '12:13:42 PM', 'March 8, 2022', 'Logout'),
(325, 'user1', '12:14:41 PM', 'March 8, 2022', 'Login'),
(326, 'user1', '12:15:02 PM', 'March 8, 2022', 'Logout'),
(327, 'user1', '12:16:23 PM', 'March 8, 2022', 'Login'),
(328, 'user1', '12:20:01 PM', 'March 8, 2022', 'Login'),
(329, 'user1', '12:21:26 PM', 'March 8, 2022', 'Logout'),
(330, 'user1', '12:22:10 PM', 'March 8, 2022', 'Login'),
(331, 'user1', '12:23:10 PM', 'March 8, 2022', 'Logout'),
(332, 'user1', '12:26:22 PM', 'March 8, 2022', 'Login'),
(333, 'user1', '12:27:19 PM', 'March 8, 2022', 'Logout'),
(334, 'user1', '12:29:49 PM', 'March 8, 2022', 'Login'),
(335, 'user1', '12:30:17 PM', 'March 8, 2022', 'Logout'),
(336, 'user1', '12:31:01 PM', 'March 8, 2022', 'Login'),
(337, 'user1', '12:31:32 PM', 'March 8, 2022', 'Logout'),
(338, 'user1', '12:32:41 PM', 'March 8, 2022', 'Login'),
(339, 'user1', '12:35:45 PM', 'March 8, 2022', 'Login'),
(340, 'user1', '1:38:29 PM', 'March 8, 2022', 'Login'),
(341, 'user1', '1:39:16 PM', 'March 8, 2022', 'Logout'),
(342, 'user1', '1:39:53 PM', 'March 8, 2022', 'Login'),
(343, 'user1', '1:50:06 PM', 'March 8, 2022', 'Logout'),
(344, 'user1', '2:15:24 PM', 'March 9, 2022', 'Login'),
(345, 'user1', '2:17:50 PM', 'March 9, 2022', 'Logout'),
(346, 'user1', '9:14:10 PM', 'March 9, 2022', 'Login'),
(347, 'user1', '9:15:43 PM', 'March 9, 2022', 'Login'),
(348, 'user1', '9:16:59 PM', 'March 9, 2022', 'Logout'),
(349, 'user1', '9:18:30 PM', 'March 9, 2022', 'Login'),
(350, 'user1', '9:19:27 PM', 'March 9, 2022', 'Logout'),
(351, 'user1', '9:21:49 PM', 'March 9, 2022', 'Login'),
(352, 'user1', '9:25:01 PM', 'March 9, 2022', 'Logout'),
(353, 'user1', '6:54:04 PM', 'March 11, 2022', 'Login'),
(354, 'user1', '6:54:19 PM', 'March 11, 2022', 'Logout'),
(355, 'user1', '6:54:52 PM', 'March 11, 2022', 'Login'),
(356, 'user1', '6:55:05 PM', 'March 11, 2022', 'Logout'),
(357, 'user1', '6:55:36 PM', 'March 11, 2022', 'Login'),
(358, 'user1', '6:56:19 PM', 'March 11, 2022', 'Login'),
(359, 'user1', '6:57:43 PM', 'March 11, 2022', 'Login'),
(360, 'user1', '6:58:23 PM', 'March 11, 2022', 'Login'),
(361, 'user1', '6:58:37 PM', 'March 11, 2022', 'Logout'),
(362, 'user1', '7:00:16 PM', 'March 11, 2022', 'Login'),
(363, 'user1', '7:00:50 PM', 'March 11, 2022', 'Login'),
(364, 'user1', '7:01:12 PM', 'March 11, 2022', 'Logout'),
(365, 'user1', '7:01:36 PM', 'March 11, 2022', 'Login'),
(366, 'user1', '7:01:51 PM', 'March 11, 2022', 'Logout'),
(367, 'user1', '7:02:18 PM', 'March 11, 2022', 'Login'),
(368, 'user1', '7:03:27 PM', 'March 11, 2022', 'Login'),
(369, 'user1', '7:04:07 PM', 'March 11, 2022', 'Logout'),
(370, 'user1', '7:07:19 PM', 'March 11, 2022', 'Login'),
(371, 'user1', '7:08:15 PM', 'March 11, 2022', 'Login'),
(372, 'user1', '7:09:38 PM', 'March 11, 2022', 'Logout'),
(373, 'user1', '7:10:09 PM', 'March 11, 2022', 'Login'),
(374, 'user1', '7:11:42 PM', 'March 11, 2022', 'Login'),
(375, 'user1', '7:12:36 PM', 'March 11, 2022', 'Logout'),
(376, 'user1', '7:13:39 PM', 'March 11, 2022', 'Login'),
(377, 'user1', '7:13:53 PM', 'March 11, 2022', 'Logout'),
(378, 'user1', '7:14:41 PM', 'March 11, 2022', 'Login'),
(379, 'user1', '7:15:14 PM', 'March 11, 2022', 'Logout'),
(380, 'user1', '7:17:12 PM', 'March 11, 2022', 'Login'),
(381, 'user1', '7:18:20 PM', 'March 11, 2022', 'Login'),
(382, 'user1', '7:19:38 PM', 'March 11, 2022', 'Logout'),
(383, 'user1', '7:22:15 PM', 'March 11, 2022', 'Login'),
(384, 'user1', '7:23:39 PM', 'March 11, 2022', 'Logout'),
(385, 'user1', '7:23:51 PM', 'March 11, 2022', 'Login'),
(386, 'user1', '7:24:09 PM', 'March 11, 2022', 'Logout'),
(387, 'user1', '7:24:58 PM', 'March 11, 2022', 'Login'),
(388, 'user1', '7:25:46 PM', 'March 11, 2022', 'Logout'),
(389, 'user1', '7:28:19 PM', 'March 11, 2022', 'Login'),
(390, 'user1', '7:32:08 PM', 'March 11, 2022', 'Logout'),
(391, 'user1', '12:31:31 PM', 'March 12, 2022', 'Login'),
(392, 'user1', '12:31:55 PM', 'March 12, 2022', 'Logout'),
(393, 'user1', '12:33:31 PM', 'March 12, 2022', 'Login'),
(394, 'user1', '12:33:52 PM', 'March 12, 2022', 'Logout'),
(395, 'user1', '12:34:44 PM', 'March 12, 2022', 'Login'),
(396, 'user1', '12:37:06 PM', 'March 12, 2022', 'Login'),
(397, 'user1', '12:37:50 PM', 'March 12, 2022', 'Login'),
(398, 'user1', '12:41:48 PM', 'March 12, 2022', 'Login'),
(399, 'user1', '12:42:52 PM', 'March 12, 2022', 'Logout'),
(400, 'user1', '12:44:41 PM', 'March 12, 2022', 'Login'),
(401, 'user1', '12:45:27 PM', 'March 12, 2022', 'Logout'),
(402, 'user1', '12:45:53 PM', 'March 12, 2022', 'Login'),
(403, 'user1', '12:46:08 PM', 'March 12, 2022', 'Logout'),
(404, 'user1', '12:46:38 PM', 'March 12, 2022', 'Login'),
(405, 'user1', '12:46:53 PM', 'March 12, 2022', 'Logout'),
(406, 'user1', '12:49:03 PM', 'March 12, 2022', 'Login'),
(407, 'user1', '12:49:15 PM', 'March 12, 2022', 'Logout'),
(408, 'user1', '12:52:30 PM', 'March 12, 2022', 'Login'),
(409, 'user1', '12:53:11 PM', 'March 12, 2022', 'Logout'),
(410, 'user1', '12:56:34 PM', 'March 12, 2022', 'Login'),
(411, 'user1', '12:57:51 PM', 'March 12, 2022', 'Login'),
(412, 'user1', '12:59:30 PM', 'March 12, 2022', 'Login'),
(413, 'user1', '12:59:44 PM', 'March 12, 2022', 'Logout'),
(414, 'user1', '1:00:11 PM', 'March 12, 2022', 'Login'),
(415, 'user1', '1:01:23 PM', 'March 12, 2022', 'Login'),
(416, 'user1', '1:02:15 PM', 'March 12, 2022', 'Login'),
(417, 'user1', '1:03:36 PM', 'March 12, 2022', 'Login'),
(418, 'user1', '1:05:01 PM', 'March 12, 2022', 'Login'),
(419, 'user1', '1:05:39 PM', 'March 12, 2022', 'Login'),
(420, 'user1', '1:06:06 PM', 'March 12, 2022', 'Login'),
(421, 'user1', '1:06:43 PM', 'March 12, 2022', 'Logout'),
(422, 'user1', '1:09:11 PM', 'March 12, 2022', 'Login'),
(423, 'user1', '1:09:17 PM', 'March 12, 2022', 'Logout'),
(424, 'user1', '1:09:40 PM', 'March 12, 2022', 'Login'),
(425, 'user1', '1:11:39 PM', 'March 12, 2022', 'Logout'),
(426, 'user1', '1:15:10 PM', 'March 12, 2022', 'Login'),
(427, 'user1', '1:16:05 PM', 'March 12, 2022', 'Logout'),
(428, 'user1', '1:20:00 PM', 'March 12, 2022', 'Login'),
(429, 'user1', '1:21:09 PM', 'March 12, 2022', 'Logout'),
(430, 'user1', '1:22:52 PM', 'March 12, 2022', 'Login'),
(431, 'user1', '9:16:50 PM', 'March 16, 2022', 'Login'),
(432, 'user1', '9:17:30 PM', 'March 16, 2022', 'Logout'),
(433, 'user1', '9:18:06 PM', 'March 16, 2022', 'Login'),
(434, 'user1', '9:18:21 PM', 'March 16, 2022', 'Logout'),
(435, 'user1', '7:41:55 PM', 'March 19, 2022', 'Login'),
(436, 'user1', '7:42:14 PM', 'March 19, 2022', 'Logout'),
(437, 'user1', '7:24:13 PM', 'March 21, 2022', 'Login'),
(438, 'user1', '7:24:25 PM', 'March 21, 2022', 'Logout'),
(439, 'user1', '7:24:31 PM', 'March 21, 2022', 'Login'),
(440, 'user1', '7:25:15 PM', 'March 21, 2022', 'Logout'),
(441, 'user1', '7:44:32 PM', 'March 21, 2022', 'Login'),
(442, 'user1', '7:45:01 PM', 'March 21, 2022', 'Logout'),
(443, 'user1', '7:51:57 PM', 'March 21, 2022', 'Login'),
(444, 'user1', '7:52:13 PM', 'March 21, 2022', 'Logout'),
(445, 'user1', '7:52:24 PM', 'March 21, 2022', 'Login'),
(446, 'user1', '7:52:34 PM', 'March 21, 2022', 'Logout');

-- --------------------------------------------------------

--
-- Table structure for table `sold`
--

CREATE TABLE `sold` (
  `sold_change` int(11) DEFAULT NULL,
  `sold_total` int(11) DEFAULT NULL,
  `sold_pay` int(11) DEFAULT NULL,
  `sold_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sold`
--

INSERT INTO `sold` (`sold_change`, `sold_total`, `sold_pay`, `sold_id`) VALUES
(33, 67, 100, 94),
(33, 67, 100, 95),
(33, 67, 100, 96),
(33, 67, 100, 97),
(33, 67, 100, 98),
(33, 67, 100, 99);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `itemlist`
--
ALTER TABLE `itemlist`
  ADD PRIMARY KEY (`prod_num`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`products_id`);

--
-- Indexes for table `psession`
--
ALTER TABLE `psession`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sales_id`);

--
-- Indexes for table `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`ses_id`);

--
-- Indexes for table `sold`
--
ALTER TABLE `sold`
  ADD PRIMARY KEY (`sold_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `itemlist`
--
ALTER TABLE `itemlist`
  MODIFY `prod_num` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=770;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `products_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `psession`
--
ALTER TABLE `psession`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=204;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sales_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `session`
--
ALTER TABLE `session`
  MODIFY `ses_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=447;

--
-- AUTO_INCREMENT for table `sold`
--
ALTER TABLE `sold`
  MODIFY `sold_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
