-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2021 at 10:36 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cafe_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `name` varchar(250) NOT NULL,
  `category` varchar(250) NOT NULL,
  `price` bigint(20) NOT NULL,
  `iid` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`name`, `category`, `price`, `iid`) VALUES
('biryani', 'Punjabi Foods', 200, 27),
('Sajji', 'Punjabi Foods', 800, 31),
('Milk shake', 'Drinks', 200, 34),
('Dinner Package', 'Packages!!!!!!', 900, 37),
('Lunch', 'Packages!!!!!!', 700, 38),
('shwarma', 'Fast Food', 150, 40),
('Bar b Q', 'Fast Food', 800, 42),
('Kabab', 'Fast Food', 200, 44),
('Coke', 'Drinks', 100, 45),
('custer', 'Sweets', 140, 46),
('pepsi', 'Drinks', 70, 47),
('chat', 'Fast Food', 70, 48),
('firni', 'Sweets', 3000, 49),
('Italian rice', 'Italian Foods', 1000, 50),
('gfg', 'Packages!!!!!!', 57, 51),
('halwa', 'Sweets', 400, 52),
('qulfa', 'Sweets', 399, 53),
('dahi bharay', 'Fast Food', 120, 54),
('Lomon juice', 'Drinks', 70, 55);

-- --------------------------------------------------------

--
-- Table structure for table `signup`
--

CREATE TABLE `signup` (
  `id` int(11) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` int(20) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `signup`
--

INSERT INTO `signup` (`id`, `user_name`, `email`, `phone`, `password`) VALUES
(1, 'Aqib', 'aqib@gmail.com', 123, '123'),
(2, 'qasim', 'qasim@gmail.com', 2147483647, '123'),
(3, 'Asim', 'asim@gmail.com', 2147483647, '123'),
(4, 'subhan', 'subhan@gmail.com', 123345, '123'),
(5, 'Aslam', 'aslam@gmail.com', 12324, '123'),
(6, 'amjad', 'amjad@gmail.com', 1234, '123'),
(7, 'Kamaran', 'kamran@gmail.com', 1234556, '123'),
(8, 'Atif', 'atif@gmail.com', 3444098, '123'),
(9, 'ali', 'ali@gmail.com', 4354, '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`iid`);

--
-- Indexes for table `signup`
--
ALTER TABLE `signup`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `iid` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `signup`
--
ALTER TABLE `signup`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
