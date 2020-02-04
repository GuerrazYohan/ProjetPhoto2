-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 30 jan. 2020 à 13:13
-- Version du serveur :  5.7.26
-- Version de PHP :  7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `photoboothproject_2020`
--
CREATE DATABASE IF NOT EXISTS `photoboothproject_2020` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `photoboothproject_2020`;

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `idCompte` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(45) NOT NULL,
  `Prenom` varchar(45) NOT NULL,
  `MotDePasse` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  PRIMARY KEY (`idCompte`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`idCompte`, `Nom`, `Prenom`, `MotDePasse`, `Email`) VALUES
(1, 'Fasano', 'Alexis', 'UnSalaud', 'fasano.alexis74@gmail.com'),
(2, 'Pougnard', 'Corentin', 'Pougnard', 'gmail.com'),
(3, 'Guerraz', 'Yohan', 'Guerraz', 'gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `compte_has_photo`
--

DROP TABLE IF EXISTS `compte_has_photo`;
CREATE TABLE IF NOT EXISTS `compte_has_photo` (
  `Compte_idCompte` int(11) NOT NULL,
  `Photo_idPhoto` int(11) NOT NULL,
  `Photo_Evenements_idEvenements` int(11) NOT NULL,
  `Photo_Evenements_Compte_idCompte` int(11) NOT NULL,
  PRIMARY KEY (`Compte_idCompte`,`Photo_idPhoto`,`Photo_Evenements_idEvenements`,`Photo_Evenements_Compte_idCompte`),
  KEY `fk_Compte_has_Photo_Photo1_idx` (`Photo_idPhoto`,`Photo_Evenements_idEvenements`,`Photo_Evenements_Compte_idCompte`),
  KEY `fk_Compte_has_Photo_Compte1_idx` (`Compte_idCompte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `compte_has_photo`
--

INSERT INTO `compte_has_photo` (`Compte_idCompte`, `Photo_idPhoto`, `Photo_Evenements_idEvenements`, `Photo_Evenements_Compte_idCompte`) VALUES
(1, 1, 1, 1),
(2, 2, 1, 1),
(3, 3, 2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `evenements`
--

DROP TABLE IF EXISTS `evenements`;
CREATE TABLE IF NOT EXISTS `evenements` (
  `idEvenements` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(45) NOT NULL,
  `DateDebut` date NOT NULL,
  `DateDeFin` date NOT NULL,
  `Compte_idCompte` int(11) NOT NULL,
  `MotDePasseEvent` varchar(45) NOT NULL,
  PRIMARY KEY (`idEvenements`,`Compte_idCompte`),
  KEY `fk_Evenements_Compte1_idx` (`Compte_idCompte`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `evenements`
--

INSERT INTO `evenements` (`idEvenements`, `Nom`, `DateDebut`, `DateDeFin`, `Compte_idCompte`, `MotDePasseEvent`) VALUES
(1, 'Project', '2020-01-22', '2020-01-25', 1, 'Fasano'),
(2, 'Project2', '2020-01-25', '2020-01-30', 2, 'Marie');

-- --------------------------------------------------------

--
-- Structure de la table `evenements_attente`
--

DROP TABLE IF EXISTS `evenements_attente`;
CREATE TABLE IF NOT EXISTS `evenements_attente` (
  `idEvenements_Attente` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(45) NOT NULL,
  `DateDebut` date NOT NULL,
  `DateDeFin` date NOT NULL,
  `MotDePasseEvent` varchar(45) NOT NULL,
  `IdCompte` int(11) NOT NULL,
  PRIMARY KEY (`idEvenements_Attente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `evenements_attente`
--

INSERT INTO `evenements_attente` (`idEvenements_Attente`, `Nom`, `DateDebut`, `DateDeFin`, `MotDePasseEvent`, `IdCompte`) VALUES
(1, 'Project6', '2020-01-31', '2020-02-05', 'Project', 3);

-- --------------------------------------------------------

--
-- Structure de la table `photo`
--

DROP TABLE IF EXISTS `photo`;
CREATE TABLE IF NOT EXISTS `photo` (
  `idPhoto` int(11) NOT NULL AUTO_INCREMENT,
  `CheminDacces` varchar(200) NOT NULL,
  `RawBytesQR` varchar(500) NOT NULL,
  `Evenements_idEvenements` int(11) NOT NULL,
  `Evenements_Compte_idCompte` int(11) NOT NULL,
  PRIMARY KEY (`idPhoto`,`Evenements_idEvenements`,`Evenements_Compte_idCompte`),
  KEY `fk_Photo_Evenements1_idx` (`Evenements_idEvenements`,`Evenements_Compte_idCompte`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `photo`
--

INSERT INTO `photo` (`idPhoto`, `CheminDacces`, `RawBytesQR`, `Evenements_idEvenements`, `Evenements_Compte_idCompte`) VALUES
(1, 'C:\\Users\\SN2\\Desktop', '1231494941952156146545616515619', 1, 1),
(2, 'C:\\Users\\SN2\\Desktop\\1', '54946986589458456464584496', 1, 1),
(3, 'C:\\Users\\SN2\\Desktop\\2', '5596496644964416146465149845196', 2, 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `compte_has_photo`
--
ALTER TABLE `compte_has_photo`
  ADD CONSTRAINT `fk_Compte_has_Photo_Compte1` FOREIGN KEY (`Compte_idCompte`) REFERENCES `compte` (`idCompte`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Compte_has_Photo_Photo1` FOREIGN KEY (`Photo_idPhoto`,`Photo_Evenements_idEvenements`,`Photo_Evenements_Compte_idCompte`) REFERENCES `photo` (`idPhoto`, `Evenements_idEvenements`, `Evenements_Compte_idCompte`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `evenements`
--
ALTER TABLE `evenements`
  ADD CONSTRAINT `fk_Evenements_Compte1` FOREIGN KEY (`Compte_idCompte`) REFERENCES `compte` (`idCompte`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `photo`
--
ALTER TABLE `photo`
  ADD CONSTRAINT `fk_Photo_Evenements1` FOREIGN KEY (`Evenements_idEvenements`,`Evenements_Compte_idCompte`) REFERENCES `evenements` (`idEvenements`, `Compte_idCompte`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
