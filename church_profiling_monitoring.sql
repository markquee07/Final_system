-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 08, 2017 at 04:32 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `church_profiling_monitoring`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance`
--

CREATE TABLE `tbl_attendance` (
  `Member_id` int(10) UNSIGNED NOT NULL,
  `Activity_type` varchar(45) NOT NULL,
  `Date_s` datetime NOT NULL,
  `Meeting_time` time NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Description` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_child_information`
--

CREATE TABLE `tbl_child_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Child_id` varchar(8) NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Birth_date` datetime NOT NULL,
  `Church_member` varchar(3) NOT NULL,
  `First_name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_child_information`
--

INSERT INTO `tbl_child_information` (`id`, `Child_id`, `Gender`, `Birth_date`, `Church_member`, `First_name`, `Last_name`, `Middle_name`) VALUES
(1, 'Y8Z95T15', 'MALE', '2017-02-05 00:00:00', '', 'mark1', 'mark1', 'm'),
(2, 'YE748RVQ', 'FEMALE', '2017-02-05 00:00:00', '', 'asd', 'asd', 'd'),
(3, 'Y69Y61MU', 'MALE', '2017-02-05 00:00:00', '', 'a', 'aa', 'a'),
(4, '251Q71V2', 'MALE', '2017-02-05 00:00:00', '', 'asd', 'asd', 'asd'),
(5, 'L0Y2JEOB', 'MALE', '2018-03-07 00:00:00', '', 'as', 'as', 'asa'),
(6, '9PVQP7TK', 'FEMALE', '2018-03-07 00:00:00', '', 'kjhgckjhgvc', 'mjhgcx', ''),
(7, 'IAQ0HWVK', 'FEMALE', '2013-06-24 00:00:00', '', 'hgc', 'kjhgc', ''),
(8, 'M8LEWX9A', 'FEMALE', '2017-02-16 00:00:00', '', 'as', 's', ''),
(9, '4G043VQ9', 'FEMALE', '2000-06-21 00:00:00', '', 'ad', 'ad', 'a'),
(10, 'MXJLO5K3', 'FEMALE', '2017-02-24 00:00:00', '', 'as', 'as', ''),
(11, '416U6WEJ', 'MALE', '2017-02-25 00:00:00', '', 'dd', 'sd', 'ds');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_expenses`
--

CREATE TABLE `tbl_church_expenses` (
  `id` int(10) UNSIGNED NOT NULL,
  `Expenses_type` varchar(45) NOT NULL,
  `Amount` double NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_income`
--

CREATE TABLE `tbl_church_income` (
  `Income_type_id` int(10) UNSIGNED NOT NULL,
  `Amount` double NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_information`
--

CREATE TABLE `tbl_church_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Church_name` varchar(45) NOT NULL,
  `Church_address` varchar(45) NOT NULL,
  `Contact_no` int(10) UNSIGNED NOT NULL,
  `Email_ad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_officials`
--

CREATE TABLE `tbl_church_officials` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `Position_type` varchar(20) NOT NULL,
  `Year` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_educational_background`
--

CREATE TABLE `tbl_educational_background` (
  `Member_id` int(10) UNSIGNED NOT NULL,
  `HEA` varchar(45) NOT NULL,
  `Course_graduated` varchar(70) NOT NULL,
  `Name_of_school_graduated` varchar(60) NOT NULL,
  `Licensure_passer` varchar(3) NOT NULL,
  `License_specification` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_educational_background`
--

INSERT INTO `tbl_educational_background` (`Member_id`, `HEA`, `Course_graduated`, `Name_of_school_graduated`, `Licensure_passer`, `License_specification`) VALUES
(10, 'None', 'None', 'None', 'No', 'None'),
(11, 'None', 'None', 'None', 'No', 'None'),
(12, 'None', 'None', 'None', 'No', 'None'),
(13, 'Elementary', 'None', 'h', 'No', 'None'),
(14, 'None', 'None', 'None', 'No', 'None'),
(15, 'None', 'None', 'None', 'No', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_emergency_funds`
--

CREATE TABLE `tbl_emergency_funds` (
  `id` int(10) UNSIGNED NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL,
  `Amount` double NOT NULL,
  `Date_borrowed` datetime NOT NULL,
  `Due_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_expenditures`
--

CREATE TABLE `tbl_expenditures` (
  `id` int(10) UNSIGNED NOT NULL,
  `Expenditures_type` varchar(40) NOT NULL,
  `Amount` double NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_family_details`
--

CREATE TABLE `tbl_family_details` (
  `Parent_id` int(10) UNSIGNED NOT NULL,
  `Child_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_family_details`
--

INSERT INTO `tbl_family_details` (`Parent_id`, `Child_id`) VALUES
(12, 10),
(14, 11);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fines`
--

CREATE TABLE `tbl_fines` (
  `id` int(10) UNSIGNED NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL,
  `Fines` double NOT NULL,
  `status` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_host_pastor`
--

CREATE TABLE `tbl_host_pastor` (
  `id` int(10) UNSIGNED NOT NULL,
  `Pastor Name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member_information`
--

CREATE TABLE `tbl_member_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Member_id` varchar(8) NOT NULL,
  `First_name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_name` varchar(10) NOT NULL,
  `Date_of_birth` datetime NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Province` varchar(45) NOT NULL,
  `City` varchar(45) NOT NULL,
  `Barangay` varchar(45) NOT NULL,
  `Baptized_status` varchar(3) NOT NULL,
  `Baptized_date` datetime NOT NULL,
  `Contact_no` varchar(20) NOT NULL,
  `Email_ad` varchar(45) NOT NULL,
  `Blood_type` varchar(5) NOT NULL,
  `Civil_status` varchar(10) NOT NULL,
  `Church_name` varchar(45) NOT NULL,
  `Pastor_name` varchar(45) NOT NULL,
  `Marriage_date` datetime NOT NULL,
  `image` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_member_information`
--

INSERT INTO `tbl_member_information` (`id`, `Member_id`, `First_name`, `Last_name`, `Middle_name`, `Date_of_birth`, `Gender`, `Province`, `City`, `Barangay`, `Baptized_status`, `Baptized_date`, `Contact_no`, `Email_ad`, `Blood_type`, `Civil_status`, `Church_name`, `Pastor_name`, `Marriage_date`, `image`) VALUES
(10, 'J38CHZZ7', 'SAS', 'ASAW', '', '2017-01-29 00:00:00', 'Female', 'AS', 'AS', 'SAS', 'No', '2017-01-29 00:00:00', 'None', 'None', 'B-', 'Single', 'SA', 'AS', '2017-01-29 00:00:00', ''),
(11, 'G95E2GSJ', 'T', 'Y', '', '2017-01-29 00:00:00', 'Male', 'QWERT', 'WERTYUI', 'SDHJ', 'No', '2017-01-29 00:00:00', 'None', 'None', 'AB+', 'Single', 'WERTY', 'ASDF', '2017-01-29 00:00:00', ''),
(12, 'VGEXNLAF', 'SD', 'AS', '', '2017-01-29 00:00:00', 'Female', 'S', 'S', 'AS', 'No', '2017-01-29 00:00:00', 'None', 'None', 'B+', 'Single', 'AS', 'AS', '2017-01-29 00:00:00', ''),
(13, 'IIDU3RQM', 'M', 'N', '', '2017-01-29 00:00:00', 'Male', 'Y', 'Y', 'Y', 'No', '2017-01-29 00:00:00', 'None', 'None', 'B+', 'Single', 'Y', 'Y', '2017-01-29 00:00:00', ''),
(14, '3HHMGZ9F', 'G', 'G', '', '2017-01-29 00:00:00', 'Male', 'SSSSSS', 'SDSD', 'DSDS', 'No', '2017-01-29 00:00:00', 'None', 'None', 'B-', 'Single', 'DS', 'SDSD', '2017-01-29 00:00:00', ''),
(15, '8IEZ9XTQ', 'N', 'N', 'N', '2017-01-29 00:00:00', 'Male', 'N', 'N', 'N', 'No', '2017-01-29 00:00:00', 'None', 'None', 'A+', 'Single', 'N', 'N', '2017-01-29 00:00:00', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_offerings`
--

CREATE TABLE `tbl_offerings` (
  `id` int(10) UNSIGNED NOT NULL,
  `offering_type` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `date` datetime NOT NULL,
  `Church_pastor_share` double NOT NULL,
  `District_moderator_share` double NOT NULL,
  `Main_church_share` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ten`
--

CREATE TABLE `tbl_ten` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `amount` double NOT NULL,
  `status` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_useraccount`
--

CREATE TABLE `tbl_useraccount` (
  `id` int(10) UNSIGNED NOT NULL,
  `First_Name` varchar(45) NOT NULL,
  `Last_Name` varchar(45) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `User_type` varchar(45) NOT NULL,
  `Contact_no` varchar(45) NOT NULL,
  `Date_registered` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_useraccount`
--

INSERT INTO `tbl_useraccount` (`id`, `First_Name`, `Last_Name`, `Username`, `Password`, `User_type`, `Contact_no`, `Date_registered`) VALUES
(1, 'admin', 'admin', 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin', '11111', '2017-01-29 13:13:26'),
(2, 'marianne', 'bautista', '', '202cb962ac59075b964b07152d234b70', 'ADMIN', '0', '2017-02-07 09:06:47'),
(3, 'marianne', 'joy', '', '202cb962ac59075b964b07152d234b70', 'ADMIN', '1313', '2017-02-07 09:09:03'),
(4, 'm', 'm', '9876', '6f8f57715090da2632453988d9a1501b', 'ADMIN', '9876', '2017-02-07 09:49:05'),
(5, 'k', 'k', '66', '8ce4b16b22b58894aa86c421e8759df3', 'ADMIN', '66', '2017-02-07 10:28:36'),
(6, 'm', 'm', 'admin', '6f8f57715090da2632453988d9a1501b', 'ADMIN', '12', '2017-02-07 10:35:22'),
(7, 'k', 'k', 'k', '8ce4b16b22b58894aa86c421e8759df3', 'ADMIN', '12', '2017-02-07 10:40:14'),
(8, 'n', 'n', 'n', '7b8b965ad4bca0e41ab51de7b31363a1', 'ADMIN', '9090', '2017-02-07 10:44:44'),
(9, 'adad', 'asd', 'ads', '7815696ecbf1c96e6894b779456d330e', 'SECRETARY', '12214214', '2017-02-07 16:34:49');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_wedding`
--

CREATE TABLE `tbl_wedding` (
  `id` int(10) UNSIGNED NOT NULL,
  `other_income_type` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_work_information`
--

CREATE TABLE `tbl_work_information` (
  `Members_id` int(10) UNSIGNED NOT NULL,
  `Work_status` varchar(3) NOT NULL,
  `Work_address` varchar(45) NOT NULL,
  `Nature_of_work` varchar(45) NOT NULL,
  `Name_of_company` varchar(45) NOT NULL,
  `Salary` double NOT NULL,
  `Self_employed` varchar(10) NOT NULL,
  `Nature_of_business` varchar(45) NOT NULL,
  `Name_of_business` varchar(45) NOT NULL,
  `Business_address` varchar(45) NOT NULL,
  `Estimated_annual_income` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_work_information`
--

INSERT INTO `tbl_work_information` (`Members_id`, `Work_status`, `Work_address`, `Nature_of_work`, `Name_of_company`, `Salary`, `Self_employed`, `Nature_of_business`, `Name_of_business`, `Business_address`, `Estimated_annual_income`) VALUES
(10, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0'),
(11, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0'),
(12, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0'),
(13, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0'),
(14, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0'),
(15, 'No', 'None', 'None', 'None', 0, 'None', '', 'None', 'None', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD KEY `FK_tbl_church_attendance_2` (`Member_id`);

--
-- Indexes for table `tbl_child_information`
--
ALTER TABLE `tbl_child_information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_expenses`
--
ALTER TABLE `tbl_church_expenses`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_income`
--
ALTER TABLE `tbl_church_income`
  ADD KEY `FK_tbl_church_income_3` (`Income_type_id`);

--
-- Indexes for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_officials`
--
ALTER TABLE `tbl_church_officials`
  ADD KEY `FK_tbl_church_officials_2` (`member_id`);

--
-- Indexes for table `tbl_educational_background`
--
ALTER TABLE `tbl_educational_background`
  ADD KEY `FK_tbl_educational_background_1` (`Member_id`);

--
-- Indexes for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_emergency_funds_1` (`member_id`);

--
-- Indexes for table `tbl_expenditures`
--
ALTER TABLE `tbl_expenditures`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_family_details`
--
ALTER TABLE `tbl_family_details`
  ADD KEY `FK_tbl_family_details_1` (`Parent_id`),
  ADD KEY `FK_tbl_family_details_2` (`Child_id`);

--
-- Indexes for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_fines_1` (`member_id`);

--
-- Indexes for table `tbl_host_pastor`
--
ALTER TABLE `tbl_host_pastor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_member_information`
--
ALTER TABLE `tbl_member_information`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Index_2` (`Member_id`);

--
-- Indexes for table `tbl_offerings`
--
ALTER TABLE `tbl_offerings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_ten`
--
ALTER TABLE `tbl_ten`
  ADD KEY `FK_tbl_ten_1` (`member_id`);

--
-- Indexes for table `tbl_useraccount`
--
ALTER TABLE `tbl_useraccount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_wedding`
--
ALTER TABLE `tbl_wedding`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_work_information`
--
ALTER TABLE `tbl_work_information`
  ADD KEY `FK_work_information_1` (`Members_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_child_information`
--
ALTER TABLE `tbl_child_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tbl_church_expenses`
--
ALTER TABLE `tbl_church_expenses`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_church_officials`
--
ALTER TABLE `tbl_church_officials`
  MODIFY `member_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_expenditures`
--
ALTER TABLE `tbl_expenditures`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_host_pastor`
--
ALTER TABLE `tbl_host_pastor`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_member_information`
--
ALTER TABLE `tbl_member_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tbl_offerings`
--
ALTER TABLE `tbl_offerings`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_useraccount`
--
ALTER TABLE `tbl_useraccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tbl_wedding`
--
ALTER TABLE `tbl_wedding`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD CONSTRAINT `FK_tbl_church_attendance_1` FOREIGN KEY (`Member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_attendance_2` FOREIGN KEY (`Member_id`) REFERENCES `tbl_child_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_church_income`
--
ALTER TABLE `tbl_church_income`
  ADD CONSTRAINT `FK_tbl_church_income_1` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_fines` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_income_2` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_offerings` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_income_3` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_wedding` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_church_officials`
--
ALTER TABLE `tbl_church_officials`
  ADD CONSTRAINT `FK_tbl_church_officials_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_officials_2` FOREIGN KEY (`member_id`) REFERENCES `tbl_host_pastor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_educational_background`
--
ALTER TABLE `tbl_educational_background`
  ADD CONSTRAINT `FK_tbl_educational_background_1` FOREIGN KEY (`Member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  ADD CONSTRAINT `FK_tbl_emergency_funds_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_family_details`
--
ALTER TABLE `tbl_family_details`
  ADD CONSTRAINT `FK_tbl_family_details_1` FOREIGN KEY (`Parent_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_family_details_2` FOREIGN KEY (`Child_id`) REFERENCES `tbl_child_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  ADD CONSTRAINT `FK_tbl_fines_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_ten`
--
ALTER TABLE `tbl_ten`
  ADD CONSTRAINT `FK_tbl_ten_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_work_information`
--
ALTER TABLE `tbl_work_information`
  ADD CONSTRAINT `FK_work_information_1` FOREIGN KEY (`Members_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
