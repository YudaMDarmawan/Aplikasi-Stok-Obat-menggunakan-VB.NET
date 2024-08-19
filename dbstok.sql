-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 13, 2017 at 09:45 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbstok`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kode_admin` varchar(10) NOT NULL,
  `nama_admin` varchar(35) NOT NULL,
  `password_admin` varchar(10) NOT NULL,
  `Level_admin` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`kode_admin`, `nama_admin`, `password_admin`, `Level_admin`) VALUES
('adm001', 'Irfan', 'Aula', 'Admin'),
('gas001', 'Aula', 'setia', 'Petugas'),
('gas002', 'Suherlan', 'jajang', 'Petugas');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_obat`
--

CREATE TABLE `tbl_obat` (
  `Kode_Obat` varchar(8) NOT NULL,
  `Produk_obat` varchar(30) NOT NULL,
  `Jenis_obat` varchar(10) NOT NULL,
  `Tgl_produksi` varchar(30) NOT NULL,
  `Exp` varchar(30) NOT NULL,
  `HET` varchar(8) NOT NULL,
  `Ukuran` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_obat`
--

INSERT INTO `tbl_obat` (`Kode_Obat`, `Produk_obat`, `Jenis_obat`, `Tgl_produksi`, `Exp`, `HET`, `Ukuran`) VALUES
('B70084B	', 'Bantugin', 'Sirup', '22/04/2017 11:05:51', '22/04/2020 11:05:51', '44.000', '120 ml'),
('B70085B', 'Paracetamol', 'Sirup', '13/05/2017 8:28:38', '13/12/2017 8:28:38', '55.000', '120 ml'),
('B70086E', 'Enkasari', 'Sirup', '14/05/2017 2:11:12', '14/05/2019 2:11:12', '28.000', '120 ml');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_obatkeluar`
--

CREATE TABLE `tbl_obatkeluar` (
  `Kode_Obat` varchar(8) NOT NULL,
  `No_order` varchar(16) NOT NULL,
  `Tgl_Keluar` varchar(30) NOT NULL,
  `Jumlah` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_obatkeluar`
--

INSERT INTO `tbl_obatkeluar` (`Kode_Obat`, `No_order`, `Tgl_Keluar`, `Jumlah`) VALUES
('B70085B', 'PO001', '13/05/2017 20:49:51', '2');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_obatmasuk`
--

CREATE TABLE `tbl_obatmasuk` (
  `Kode_Obat` varchar(8) NOT NULL,
  `Proses_Order` varchar(16) NOT NULL,
  `Tgl_Masuk` varchar(30) NOT NULL,
  `Jumlah` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_obatmasuk`
--

INSERT INTO `tbl_obatmasuk` (`Kode_Obat`, `Proses_Order`, `Tgl_Masuk`, `Jumlah`) VALUES
('B70084B	', 'PO001', '13/05/2017 23:14:36', '25'),
('B70086E', 'PO002', '14/05/2017 2:13:49', '10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stok`
--

CREATE TABLE `tbl_stok` (
  `Kode_Obat` varchar(8) NOT NULL,
  `Jumlah` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_stok`
--

INSERT INTO `tbl_stok` (`Kode_Obat`, `Jumlah`) VALUES
('B70084B	', 25),
('B70086E', 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kode_admin`);

--
-- Indexes for table `tbl_obat`
--
ALTER TABLE `tbl_obat`
  ADD PRIMARY KEY (`Kode_Obat`) USING BTREE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
