-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2020 at 06:23 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `tournament_pbd`
--
CREATE DATABASE IF NOT EXISTS `tournament_pbd` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `tournament_pbd`;

-- --------------------------------------------------------

--
-- Table structure for table `matches`
--

CREATE TABLE IF NOT EXISTS `matches` (
  `Id` varchar(45) NOT NULL,
  `Team1ID` int(11) NOT NULL,
  `Team2ID` int(11) NOT NULL,
  `MatchWinner` varchar(45) DEFAULT NULL,
  `MatchRound` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Team_has_Team_Team2_idx` (`Team2ID`),
  KEY `fk_Team_has_Team_Team1_idx` (`Team1ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matches`
--

INSERT INTO `matches` (`Id`, `Team1ID`, `Team2ID`, `MatchWinner`, `MatchRound`) VALUES
('1', 1, 2, 'a', 0);

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE IF NOT EXISTS `players` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Team_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Players_Team_idx` (`Team_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `players`
--

INSERT INTO `players` (`Id`, `Name`, `Email`, `Team_Id`) VALUES
(1, 'Budi', 'Budi@gmail.com', 1),
(2, 'Tommy', 'Tommy@gmail.com', 1),
(3, 'Andre', 'Andre@gmail.com', 1),
(4, 'Steven', 'Steven@gmail.com', 2),
(5, 'Mario Andreas', 'MarioAndreas@gmail.com', 2),
(6, 'Nicky Suherman', 'NickyS12@gmail.com', 2),
(7, 'Valentino Lucas', 'Val_cas@gmail.com', 3),
(8, 'John Paul', 'PaulJo@gmail.com', 3),
(9, 'Xem Dagh', 'XemDagh@gmail.com', 3);

-- --------------------------------------------------------

--
-- Table structure for table `prizes`
--

CREATE TABLE IF NOT EXISTS `prizes` (
  `Id` int(11) NOT NULL,
  `PlaceNumber` int(11) DEFAULT NULL,
  `PlaceName` varchar(45) DEFAULT NULL,
  `PrizeAmount` decimal(10,0) DEFAULT NULL,
  `PrizePercentage` double DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `rounds`
--

CREATE TABLE IF NOT EXISTS `rounds` (
  `round` int(11) NOT NULL,
  `Schedule` datetime DEFAULT NULL,
  `Round Winner` varchar(45) DEFAULT NULL,
  `Matches_Id` varchar(45) NOT NULL,
  PRIMARY KEY (`round`,`Matches_Id`),
  KEY `fk_Rounds_Matches1_idx` (`Matches_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `teams`
--

CREATE TABLE IF NOT EXISTS `teams` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teams`
--

INSERT INTO `teams` (`Id`, `Name`) VALUES
(1, 'Cows'),
(2, 'Blushing Flys'),
(3, 'Bright Sheep');

-- --------------------------------------------------------

--
-- Table structure for table `tournamentprizes`
--

CREATE TABLE IF NOT EXISTS `tournamentprizes` (
  `Prizes_Id` int(11) NOT NULL,
  `Tournaments_Id` int(11) NOT NULL,
  PRIMARY KEY (`Prizes_Id`,`Tournaments_Id`),
  KEY `fk_Prizes_has_Tournaments_Tournaments1_idx` (`Tournaments_Id`),
  KEY `fk_Prizes_has_Tournaments_Prizes1_idx` (`Prizes_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE IF NOT EXISTS `tournaments` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `EntryFee` decimal(10,0) DEFAULT NULL,
  `Tournamentscol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tournaments`
--

INSERT INTO `tournaments` (`Id`, `Name`, `EntryFee`, `Tournamentscol`) VALUES
(1, 'PUBG', '150000', 'a'),
(2, 'Basket', '350000', 'b'),
(3, 'Voli', '200000', 'c');

-- --------------------------------------------------------

--
-- Table structure for table `tournamentteams`
--

CREATE TABLE IF NOT EXISTS `tournamentteams` (
  `Id` varchar(45) NOT NULL,
  `Tournaments_Id` int(11) NOT NULL,
  `Teams_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Tournaments_has_Teams_Teams1_idx` (`Teams_Id`),
  KEY `fk_Tournaments_has_Teams_Tournaments1_idx` (`Tournaments_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
