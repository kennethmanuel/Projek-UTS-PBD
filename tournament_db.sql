-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2020 at 04:59 PM
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
-- Table structure for table `matches`
--

CREATE TABLE `matches` (
  `Id` varchar(45) NOT NULL,
  `Team1ID` int(11) NOT NULL,
  `Team2ID` int(11) NOT NULL,
  `MatchWinner` varchar(45) DEFAULT NULL,
  `MatchRound` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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

-- --------------------------------------------------------

--
-- Table structure for table `prizes`
--

CREATE TABLE `prizes` (
  `Id` int(11) NOT NULL,
  `PlaceNumber` int(11) DEFAULT NULL,
  `PlaceName` varchar(45) DEFAULT NULL,
  `PrizeAmount` decimal(10,0) DEFAULT NULL,
  `PrizePercentage` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `rounds`
--

CREATE TABLE `rounds` (
  `round` int(11) NOT NULL,
  `Schedule` datetime DEFAULT NULL,
  `Round Winner` varchar(45) DEFAULT NULL,
  `Matches_Id` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `teams`
--

CREATE TABLE `teams` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tournamentprizes`
--

CREATE TABLE `tournamentprizes` (
  `Prizes_Id` int(11) NOT NULL,
  `Tournaments_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE `tournaments` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `EntryFee` decimal(10,0) DEFAULT NULL,
  `Tournamentscol` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tournamentteams`
--

CREATE TABLE `tournamentteams` (
  `Id` varchar(45) NOT NULL,
  `Tournaments_Id` int(11) NOT NULL,
  `Teams_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `matches`
--
ALTER TABLE `matches`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_Team_has_Team_Team2_idx` (`Team2ID`),
  ADD KEY `fk_Team_has_Team_Team1_idx` (`Team1ID`);

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
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `rounds`
--
ALTER TABLE `rounds`
  ADD PRIMARY KEY (`round`,`Matches_Id`),
  ADD KEY `fk_Rounds_Matches1_idx` (`Matches_Id`);

--
-- Indexes for table `teams`
--
ALTER TABLE `teams`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tournamentprizes`
--
ALTER TABLE `tournamentprizes`
  ADD PRIMARY KEY (`Prizes_Id`,`Tournaments_Id`),
  ADD KEY `fk_Prizes_has_Tournaments_Tournaments1_idx` (`Tournaments_Id`),
  ADD KEY `fk_Prizes_has_Tournaments_Prizes1_idx` (`Prizes_Id`);

--
-- Indexes for table `tournaments`
--
ALTER TABLE `tournaments`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tournamentteams`
--
ALTER TABLE `tournamentteams`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_Tournaments_has_Teams_Teams1_idx` (`Teams_Id`),
  ADD KEY `fk_Tournaments_has_Teams_Tournaments1_idx` (`Tournaments_Id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `matches`
--
ALTER TABLE `matches`
  ADD CONSTRAINT `fk_Team_has_Team_Team1` FOREIGN KEY (`Team1ID`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Team_has_Team_Team2` FOREIGN KEY (`Team2ID`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `players`
--
ALTER TABLE `players`
  ADD CONSTRAINT `fk_Players_Team` FOREIGN KEY (`Team_Id`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `rounds`
--
ALTER TABLE `rounds`
  ADD CONSTRAINT `fk_Rounds_Matches1` FOREIGN KEY (`Matches_Id`) REFERENCES `matches` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tournamentprizes`
--
ALTER TABLE `tournamentprizes`
  ADD CONSTRAINT `fk_Prizes_has_Tournaments_Prizes1` FOREIGN KEY (`Prizes_Id`) REFERENCES `prizes` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Prizes_has_Tournaments_Tournaments1` FOREIGN KEY (`Tournaments_Id`) REFERENCES `tournaments` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tournamentteams`
--
ALTER TABLE `tournamentteams`
  ADD CONSTRAINT `fk_Tournaments_has_Teams_Teams1` FOREIGN KEY (`Teams_Id`) REFERENCES `teams` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tournaments_has_Teams_Tournaments1` FOREIGN KEY (`Tournaments_Id`) REFERENCES `tournaments` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
