-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 10, 2017 at 02:45 AM
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
  `meeting_Date` date NOT NULL,
  `Meeting_time` time NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Description` varchar(45) NOT NULL,
  `id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_burialofficial`
--

CREATE TABLE `tbl_burialofficial` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `Position` varchar(45) NOT NULL,
  `Year` varchar(45) NOT NULL
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
  `Contact_no` varchar(45) NOT NULL,
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
  `First_Name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_Name` varchar(45) NOT NULL,
  `Address` varchar(60) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `Date_of_birth` datetime DEFAULT NULL,
  `concat_number` varchar(45) NOT NULL,
  `Name_of_school_grad` varchar(45) NOT NULL,
  `Address_of_school_graduaterd` varchar(45) NOT NULL,
  `year_graduated` varchar(45) NOT NULL,
  `Chutch_name` varchar(45) NOT NULL,
  `Church_address` varchar(45) NOT NULL,
  `years_of_service` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_listofhostpastor`
--

CREATE TABLE `tbl_listofhostpastor` (
  `id` int(10) UNSIGNED NOT NULL,
  `Pastor_id` int(10) UNSIGNED NOT NULL,
  `Officer_type` varchar(20) NOT NULL
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
  `Baptized_date` datetime DEFAULT NULL,
  `Contact_no` varchar(20) NOT NULL,
  `Email_ad` varchar(45) NOT NULL,
  `Blood_type` varchar(5) NOT NULL,
  `Civil_status` varchar(10) NOT NULL,
  `Church_name` varchar(45) NOT NULL,
  `Pastor_name` varchar(45) NOT NULL,
  `Marriage_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(1, 'admin', 'admin', 'admin', '21232f297a57a5a743894a0e4a801fc3', 'ADMIN', '1=1', '2017-02-09 18:48:44');

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
  `Name_of_business` varchar(45) NOT NULL,
  `Business_address` varchar(45) NOT NULL,
  `Estimated_annual_income` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_church_attendance_2` (`Member_id`);

--
-- Indexes for table `tbl_burialofficial`
--
ALTER TABLE `tbl_burialofficial`
  ADD KEY `FK_tbl_burialOfficial_1` (`member_id`);

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
-- Indexes for table `tbl_listofhostpastor`
--
ALTER TABLE `tbl_listofhostpastor`
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
-- AUTO_INCREMENT for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbl_child_information`
--
ALTER TABLE `tbl_child_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `tbl_church_expenses`
--
ALTER TABLE `tbl_church_expenses`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `tbl_listofhostpastor`
--
ALTER TABLE `tbl_listofhostpastor`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_member_information`
--
ALTER TABLE `tbl_member_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `tbl_offerings`
--
ALTER TABLE `tbl_offerings`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_useraccount`
--
ALTER TABLE `tbl_useraccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
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
  ADD CONSTRAINT `FK_tbl_attendance_1` FOREIGN KEY (`Member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_burialofficial`
--
ALTER TABLE `tbl_burialofficial`
  ADD CONSTRAINT `FK_tbl_burialOfficial_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
