-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 18 May 2023, 10:26:23
-- Sunucu sürümü: 10.4.28-MariaDB
-- PHP Sürümü: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `arackiralamauygulamasi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giris`
--

CREATE TABLE `giris` (
  `kullaniciadi` varchar(45) NOT NULL,
  `sifre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `giris`
--

INSERT INTO `giris` (`kullaniciadi`, `sifre`) VALUES
('test', '1234');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteribilgisi`
--

CREATE TABLE `musteribilgisi` (
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `tc` bigint(11) NOT NULL,
  `cinsiyet` text NOT NULL,
  `telefon` int(11) NOT NULL,
  `araclistele` text NOT NULL,
  `vitestipi` text NOT NULL,
  `baslangicgunu` text NOT NULL,
  `bitisgunu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `musteribilgisi`
--

INSERT INTO `musteribilgisi` (`ad`, `soyad`, `tc`, `cinsiyet`, `telefon`, `araclistele`, `vitestipi`, `baslangicgunu`, `bitisgunu`) VALUES
('test1', 'testterrr', 47958468425, 'Erkek', 2147483647, 'Renault Megane2', 'Otomatik', '2 Haziran 2023 Cuma', '4 Haziran 2023 Pazar');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `giris`
--
ALTER TABLE `giris`
  ADD UNIQUE KEY `UNIQUE` (`kullaniciadi`);

--
-- Tablo için indeksler `musteribilgisi`
--
ALTER TABLE `musteribilgisi`
  ADD PRIMARY KEY (`tc`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
