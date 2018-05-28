-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Pon 28. kvě 2018, 15:13
-- Verze serveru: 10.1.16-MariaDB
-- Verze PHP: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `prog_maturita`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `osoba`
--

CREATE TABLE `osoba` (
  `id` int(11) UNSIGNED NOT NULL,
  `pracoviste_id` int(11) UNSIGNED NOT NULL,
  `jmeno` varchar(155) COLLATE utf8_czech_ci NOT NULL,
  `prijmeni` varchar(155) COLLATE utf8_czech_ci NOT NULL,
  `vek` int(3) NOT NULL,
  `plat` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

-- --------------------------------------------------------

--
-- Struktura tabulky `pracoviste`
--

CREATE TABLE `pracoviste` (
  `id` int(11) UNSIGNED NOT NULL,
  `nazev` varchar(155) COLLATE utf8_czech_ci NOT NULL,
  `umisteni` varchar(155) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Klíče pro exportované tabulky
--

--
-- Klíče pro tabulku `osoba`
--
ALTER TABLE `osoba`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pracoviste_id` (`pracoviste_id`);

--
-- Klíče pro tabulku `pracoviste`
--
ALTER TABLE `pracoviste`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `osoba`
--
ALTER TABLE `osoba`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pro tabulku `pracoviste`
--
ALTER TABLE `pracoviste`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
