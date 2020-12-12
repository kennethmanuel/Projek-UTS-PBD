-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2020 at 01:58 AM
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
  `WinnerId` int(11) NOT NULL,
  `Round` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `matchup`
--

INSERT INTO `matchup` (`Id`, `WinnerId`, `Round`) VALUES
('001', 6, 1),
('002', 5, 1),
('003', 2, 1),
('004', 4, 1),
('005', 5, 2),
('006', 2, 2),
('007', 2, 3),
('008', 10, 1),
('009', 12, 1),
('010', 12, 2);

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
('001', 6, 1),
('001', 7, 0),
('002', 3, 0),
('002', 5, 1),
('003', 1, 0),
('003', 2, 1),
('004', 4, 1),
('004', 8, 0),
('005', 5, 1),
('005', 6, 0),
('006', 2, 1),
('006', 4, 0),
('007', 2, 1),
('007', 5, 0),
('008', 9, 0),
('008', 10, 1),
('009', 11, 0),
('009', 12, 1),
('010', 10, 0),
('010', 12, 1);

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
(1, 'Parker Mclellan', 'parker@gmail.com', 1),
(2, 'Cai Hubbard', 'caihubbard@gmail.com', 1),
(3, 'Soraya Watkins', 'soraya@gmail.com', 1),
(4, 'Afsana Livingston', 'afsana@gmail.com', 2),
(5, 'Mario Andreas', 'mario @gmail.com', 2),
(6, 'Nicky Suherman', 'nicky@gmail.com', 2),
(7, 'Valentino Lucas', 'valentino@gmail.com', 3),
(8, 'John Paul', 'pauljo@gmail.com', 3),
(9, 'Xem Dagh', 'xemdagh@gmail.com', 3),
(10, 'Georgiana Lim', 'georgiana@gmail.com', 4),
(11, 'Stephen Beattie', 'stephen@gmail.com', 4),
(12, 'Kris Bowman', 'kris@gmail.com', 4),
(13, 'Richard Kent', 'richard@gmail.com', 5),
(14, 'Kiana Owens', 'kiana@outlook.com', 5),
(15, 'Rees Leal', 'rees@outlook.com', 5),
(16, 'Britany Larson', 'britany@outlook.com', 6),
(17, 'Ronan Bassett', 'ronan@outlook.com', 6),
(18, 'Vinny Swanson', 'vinny@outook.com', 6),
(19, 'Lorelai Ochoa', 'lorelai@outlook.com', 7),
(20, 'Susanna Odom', 'susanna@outlook.com', 7),
(21, 'Cindy Macleod', 'cindy@outlook.com', 7),
(22, 'Cataleya Conner', 'cataleya@outlook.com', 8),
(23, 'Kean Leech', 'kean@outlook.com', 8),
(24, 'Luna Schwartz', 'luna@outlook.com', 8),
(25, 'Pooja Cherry', 'pooja@protonmail.com', 9),
(26, 'Kadeem Lindsey', 'lindsey@protonmail.com', 9),
(27, 'Meg Butt', 'butt@urbutt.com', 10),
(28, 'Hunter Rodrigues', 'hunter@urbutt.com', 10),
(29, 'Albert Houghton', 'houghton@sigma.ac.id', 11),
(30, 'Eoin Pritchard', 'eoin@sigma.ac.id', 11),
(31, 'Teejay Clark', 'teejay@valve.com', 12),
(32, 'Umayr Kim', 'kim@valve.com', 12);

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
(1, 'Champion', '1440000', 0.6, 1),
(2, 'Runner Up', '600000', 0.25, 1),
(3, 'Third Place', '360000', 0.15, 1),
(4, 'Grand Champion', '800000', 1, 2);

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
(1, 'Cows', 0),
(2, 'Blushing Flys', 0),
(3, 'Bright Sheep', 0),
(4, 'AEON', 0),
(5, 'Cat Lover', 0),
(6, 'Shadow Ninja', 0),
(7, 'Wibu lokal', 0),
(8, 'Ligma Balls', 0),
(9, 'Flying Ninja', 0),
(10, 'Sister Destroyer', 0),
(11, 'Ligma Dig', 0),
(12, 'Sugma Dig', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE `tournaments` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `EntryFee` decimal(10,0) DEFAULT NULL,
  `Round` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tournaments`
--

INSERT INTO `tournaments` (`Id`, `Name`, `EntryFee`, `Round`) VALUES
(1, 'Team Chess Tournament', '300000', 1),
(2, 'Badminton Ganda 2v2', '200000', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `matchup`
--
ALTER TABLE `matchup`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_Team_has_Team_Team1_idx` (`WinnerId`);

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
-- Indexes for table `tournaments`
--
ALTER TABLE `tournaments`
  ADD PRIMARY KEY (`Id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `matchup`
--
ALTER TABLE `matchup`
  ADD CONSTRAINT `fk_Team_has_Team_Team1` FOREIGN KEY (`WinnerId`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
