-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2020 at 08:51 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tournament_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `matchup`
--

CREATE TABLE `matchup` (
  `Id` varchar(45) NOT NULL,
  `Round` int(11) DEFAULT NULL,
  `Date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `matchup`
--

INSERT INTO `matchup` (`Id`, `Round`, `Date`) VALUES
('1', 1, '2021-12-01 00:00:00'),
('2', 1, '2020-12-31 00:00:00'),
('3', 2, '2020-12-24 00:00:00'),
('4', 2, '2020-12-28 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `matchupentries`
--

CREATE TABLE `matchupentries` (
  `ParentMatchup_Id` varchar(45) NOT NULL,
  `Teams_Id` int(11) NOT NULL,
  `Score` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `matchupentries`
--

INSERT INTO `matchupentries` (`ParentMatchup_Id`, `Teams_Id`, `Score`) VALUES
('1', 1, 1),
('1', 2, 0),
('2', 9, 0),
('2', 10, 1),
('3', 11, 0),
('3', 12, 1),
('4', 4, 0),
('4', 6, 1);

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE `players` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Team_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `players`
--

INSERT INTO `players` (`Id`, `Name`, `Email`, `Team_Id`) VALUES
(1, 'Kevin', 'kevin091@gmail.com', 1),
(2, 'kenneth', 'kenneth@gmail.com', 1),
(3, 'Billy', 'Billy091@gmail.com', 2),
(4, 'Tyson', 'kenneth@gmail.com', 3),
(5, 'Yudha', 'Yudha0956@gmail.com', 4),
(6, 'Yogi', 'yogui5487@gmail.com', 5),
(7, 'Ryan', 'ryan0909@gmail.com', 6),
(8, 'Didi', 'Didi@gmail.com', 7),
(9, 'Andrew', 'andrew193@gmail.com', 8),
(10, 'Howard', 'Howard12@gmail.com', 9),
(11, 'rondo', 'rondo@gmail.com', 9),
(12, 'Allen', 'alle@yahoo.com', 9),
(13, 'Rama', 'rama@hotmail.com', 10),
(14, 'Rivaldo', 'rivaldo@gmail.com', 10),
(15, 'Harden', 'harden@gmail.com', 11),
(16, 'Powell', 'Powell12@gmail.com', 12),
(17, 'Parker Mclellan', 'parker@gmail.com', 1),
(18, 'Cai Hubbard', 'caihubbard@gmail.com', 12),
(19, 'Bob', 'Bob@gmail.com', 13),
(20, 'Arthur Coy', 'Coy@gmail.com', 16),
(21, 'David Degea', '1De@gmail.com', 17),
(22, 'Ben Tnyson', 'ben@gmail.com', 19),
(23, 'Lahm', '1lane@gmail.com', 18),
(24, 'Russell', 'bill@gmail.com', 4),
(25, 'Valencia', 'Valencia@gmail.com', 4),
(26, 'Rudy', 'habrud@gmail.com', 2),
(27, 'Beckam', '23@gmail.com', 10),
(28, 'Henderson', 'hen12345@gmail.com', 19),
(29, 'Bill Rusael', 'Bill141@gmail.com', 17),
(30, 'Tom', 'Tom52@gmail.com', 4),
(31, 'Ederson', 'eder@valve.com', 13),
(32, 'Umayr Kim', 'kim@valve.com', 15),
(33, 'Wira Negara', 'Wira@valve.com', 3),
(34, 'YTunan', 'yunan@valve.com', 19),
(35, 'Umar', 'umar@gmail.com', 13),
(36, 'jordan', 'jordan@valve.com', 12),
(37, 'ariza', 'trevor@valve.com', 14),
(38, 'Kim', 'kim12@valve.com', 16),
(39, 'madora', 'm13@valve.com', 12),
(40, 'basir', 'bas12354@valve.com', 12);

-- --------------------------------------------------------

--
-- Table structure for table `prizes`
--

CREATE TABLE `prizes` (
  `Id` int(11) NOT NULL,
  `PlaceName` varchar(45) DEFAULT NULL,
  `PrizeAmount` decimal(10,0) DEFAULT NULL,
  `PrizePercentage` double DEFAULT NULL,
  `Tournaments_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `prizes`
--

INSERT INTO `prizes` (`Id`, `PlaceName`, `PrizeAmount`, `PrizePercentage`, `Tournaments_Id`) VALUES
(1, 'Champion', '1000000', 0.5, 1),
(2, 'Legend', '1500000', 0.8, 2),
(3, 'Winner 1st', '750000', 1, 3),
(4, '2st', '700000', 0.5, 1),
(5, '3rd', '5000000', 0.5, 1),
(6, 'Master', '7000000', 0.8, 2),
(7, 'Elite', '5000000', 0.8, 2),
(8, 'Second 2st', '500000', 1, 3),
(9, 'Good 3rd', '300000', 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `teams`
--

CREATE TABLE `teams` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Totalscore` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `teams`
--

INSERT INTO `teams` (`Id`, `Name`, `Totalscore`) VALUES
(1, 'TNC Predator', 5),
(2, 'Team Nigma', 4),
(3, 'EHOME', 3),
(4, 'Team Aster', 2),
(5, 'Thunder Predator', 1),
(6, 'Cyber Legacy', 0),
(7, 'Team NP', 7),
(8, '4 Zoomers', 0),
(9, 'Team USA', 4),
(10, 'Team Indonesia', 6),
(11, 'Bob Chess', 4),
(12, 'Team Morphy', 6),
(13, 'Cows', 0),
(14, 'Blushing Flys', 0),
(15, 'AEON', 0),
(16, 'Wibu Lokal', 0),
(17, 'Flying Ninja', 0),
(18, 'Bright Sheep', 0),
(19, 'Sister Destroyer', 0),
(20, 'Shadow Ninja', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tournamententry`
--

CREATE TABLE `tournamententry` (
  `Tournaments_Id` int(11) NOT NULL,
  `Teams_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tournamententry`
--

INSERT INTO `tournamententry` (`Tournaments_Id`, `Teams_Id`) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 14),
(1, 19),
(2, 9),
(2, 10),
(3, 11),
(3, 12);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE `tournaments` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `EntryFee` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tournaments`
--

INSERT INTO `tournaments` (`Id`, `Name`, `EntryFee`) VALUES
(1, 'DOTA 2', '1000000'),
(2, 'Basketball 3x3 ', '300000'),
(3, 'Team Chess Tournament', '500000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `matchup`
--
ALTER TABLE `matchup`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `matchupentries`
--
ALTER TABLE `matchupentries`
  ADD PRIMARY KEY (`ParentMatchup_Id`,`Teams_Id`),
  ADD KEY `fk_Matchup_has_Teams_Teams1_idx` (`Teams_Id`),
  ADD KEY `fk_Matchup_has_Teams_Matchup1_idx` (`ParentMatchup_Id`);

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_Players_Team_idx` (`Team_Id`);

--
-- Indexes for table `prizes`
--
ALTER TABLE `prizes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_Prizes_Tournaments1_idx` (`Tournaments_Id`);

--
-- Indexes for table `teams`
--
ALTER TABLE `teams`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tournamententry`
--
ALTER TABLE `tournamententry`
  ADD PRIMARY KEY (`Tournaments_Id`,`Teams_Id`),
  ADD KEY `fk_Tournaments_has_Teams_Teams1_idx` (`Teams_Id`),
  ADD KEY `fk_Tournaments_has_Teams_Tournaments1_idx` (`Tournaments_Id`);

--
-- Indexes for table `tournaments`
--
ALTER TABLE `tournaments`
  ADD PRIMARY KEY (`Id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `matchupentries`
--
ALTER TABLE `matchupentries`
  ADD CONSTRAINT `fk_Matchup_has_Teams_Matchup1` FOREIGN KEY (`ParentMatchup_Id`) REFERENCES `matchup` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Matchup_has_Teams_Teams1` FOREIGN KEY (`Teams_Id`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `players`
--
ALTER TABLE `players`
  ADD CONSTRAINT `fk_Players_Team` FOREIGN KEY (`Team_Id`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `prizes`
--
ALTER TABLE `prizes`
  ADD CONSTRAINT `fk_Prizes_Tournaments1` FOREIGN KEY (`Tournaments_Id`) REFERENCES `tournaments` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tournamententry`
--
ALTER TABLE `tournamententry`
  ADD CONSTRAINT `fk_Tournaments_has_Teams_Teams1` FOREIGN KEY (`Teams_Id`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tournaments_has_Teams_Tournaments1` FOREIGN KEY (`Tournaments_Id`) REFERENCES `tournaments` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
