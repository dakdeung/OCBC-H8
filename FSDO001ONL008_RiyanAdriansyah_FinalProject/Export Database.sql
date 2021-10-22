-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 21, 2021 at 06:55 PM
-- Server version: 8.0.13-4
-- PHP Version: 7.2.24-0ubuntu0.18.04.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `3S1hHabKL9`
--

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text COLLATE utf8_unicode_ci,
  `ClaimValue` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ConcurrencyStamp` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text COLLATE utf8_unicode_ci,
  `ClaimValue` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderKey` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `ProviderDisplayName` text COLLATE utf8_unicode_ci,
  `UserId` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `RoleId` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `UserName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedUserName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Email` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedEmail` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text COLLATE utf8_unicode_ci,
  `SecurityStamp` text COLLATE utf8_unicode_ci,
  `ConcurrencyStamp` text COLLATE utf8_unicode_ci,
  `PhoneNumber` text COLLATE utf8_unicode_ci,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('971bf0cb-c405-41f2-a39b-ee94317ef2ea', 'riyan', 'RIYAN', 'riyan@gmail.com', 'RIYAN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEEhsX5xXKQXL9hnkLHKxNvjHBQFrxue+D1JmlV/W9KcLGTCGaKi+nut+9eTq/zqMbw==', '7T32OBJXAOWQX7Z7V3WW4BFKMTRLZ7H3', '8eaefe0d-423d-4c5b-9fcd-b9cc3a3be7b6', NULL, 0, 0, NULL, 1, 0),
('981a86dd-dd22-4c49-a5da-7fda9afb731c', 'felia', 'FELIA', 'felia@gmail.com', 'FELIA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEHX2/gPTXe9V/lCVJ44q+2Xs6kjE9m0AGxqOObyiVR9Uzu2nTshC1aweMwIfuC31Sg==', '2ZL4QSBWYWHTHQCM2SCJYATUFR53KHKS', '921c9f21-83fc-4b63-b0c5-b4554385275d', NULL, 0, 0, NULL, 1, 0),
('cbe0757d-13a5-4242-8c8c-b527c676e136', 'Ujang', 'UJANG', 'ujang@gmail.com', 'UJANG@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEGDMYO98sPcwtqNYyOISUGbksUOJ/JtiLGGjyBPlxnAQlDh2+teasGaIq68+4Ad46A==', 'HE35IMR3G4IFAVYFW5P5ET5N4PKR5R3X', '833f5707-fd8d-474e-bfc0-fb100f57d077', NULL, 0, 0, NULL, 1, 0),
('e77e0933-03ae-4adb-849a-d26b879d4ce0', 'dadun', 'DADUN', 'dadun@gmail.com', 'DADUN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAENXtoOCCsuElvmBIJzSYv9+5bG8WoCskXsWnDOmac0Qh4h1N38XVY4edcGSLJsZ9rw==', 'CEG54D5NU7Y7OHUI2OZAD4T2Y5YDV42O', '6ad193e3-9283-46a1-82c1-f4a6f9654d35', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `LoginProvider` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `Value` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Items`
--

CREATE TABLE `Items` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` text COLLATE utf8_unicode_ci,
  `cardNumber` text COLLATE utf8_unicode_ci,
  `expirationDate` text COLLATE utf8_unicode_ci,
  `securityCode` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Items`
--

INSERT INTO `Items` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(1, 'Riyan Adriansyah', '23523423423', '12/12/2025', '2352342342342');

-- --------------------------------------------------------

--
-- Table structure for table `RefreshTokens`
--

CREATE TABLE `RefreshTokens` (
  `id` int(11) NOT NULL,
  `UserId` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Token` text COLLATE utf8_unicode_ci,
  `JwtId` text COLLATE utf8_unicode_ci,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevoked` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `RefreshTokens`
--

INSERT INTO `RefreshTokens` (`id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevoked`, `AddedDate`, `ExpiryDate`) VALUES
(1, '971bf0cb-c405-41f2-a39b-ee94317ef2ea', 'EX29D126U8BLCMIS8J0418G4UMU7UOG1KAKec99136f-ff9e-4ab2-84f8-3a74758c4a86', 'd2e3ed4e-0f0d-4e43-91f7-a315677e645f', 0, 0, '2021-10-21 17:30:06', '2022-04-21 17:30:06'),
(2, '971bf0cb-c405-41f2-a39b-ee94317ef2ea', 'XQFG4FETK2YEXHDHK8KSZ0814VZ3XD588EG3d522751-e475-4661-941c-e0d85e74b106', '7c04a48d-ccf0-4b8e-9656-293e4b187ba5', 0, 0, '2021-10-21 17:30:43', '2022-04-21 17:30:43'),
(3, '981a86dd-dd22-4c49-a5da-7fda9afb731c', 'PC3B5OJ393I3DUZEUT0DF1HP74D1AS5WFG8dd5188c8-e861-4492-9609-aff3116b785b', '382677cc-7691-4eae-806b-2e7beb757256', 0, 0, '2021-10-21 18:00:21', '2022-04-21 18:00:21'),
(4, 'e77e0933-03ae-4adb-849a-d26b879d4ce0', 'GHWZEQWSXLFM1NM2WDV932XOK9FN3SU5CIP63f024bb-753d-4535-a980-067ce2c8c17e', 'ed602a3a-ea0e-49d8-9a42-3f664fa54ffc', 0, 0, '2021-10-21 18:15:48', '2022-04-21 18:15:48'),
(5, 'cbe0757d-13a5-4242-8c8c-b527c676e136', 'BDKSE3W04KJ6SU2J4TUOAGJS0G6GNB0RBE0cb33b3ba-7f33-4923-bcc7-a5cdf5a96aa2', '9f8a2a1b-3efa-465a-bc98-e5cd3c71825f', 0, 0, '2021-10-21 18:31:28', '2022-04-21 18:31:28'),
(6, 'cbe0757d-13a5-4242-8c8c-b527c676e136', 'ZVY91KVBWFMKRQUJUNC408U0RKDTEE57S1Ve01381fb-a2dc-4d87-9b7b-957a71ad4aa9', '93ca6664-da6d-4420-84f5-89d33bef1e0f', 0, 0, '2021-10-21 18:32:23', '2022-04-21 18:32:23');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `ProductVersion` varchar(32) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021172728_Initial Migrations', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `Items`
--
ALTER TABLE `Items`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- Indexes for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Items`
--
ALTER TABLE `Items`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
