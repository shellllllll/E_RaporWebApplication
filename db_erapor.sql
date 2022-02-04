/*
SQLyog Professional v12.4.3 (64 bit)
MySQL - 10.4.13-MariaDB : Database - db_erapor
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_erapor` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_erapor`;

/*Table structure for table `__efmigrationshistory` */

DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `__efmigrationshistory` */

insert  into `__efmigrationshistory`(`MigrationId`,`ProductVersion`) values 
('20220204114330_tb_admin','5.0.13');

/*Table structure for table `tb_admin` */

DROP TABLE IF EXISTS `tb_admin`;

CREATE TABLE `tb_admin` (
  `Nama_Pengguna` varchar(767) NOT NULL,
  `Kata_Sandi` text NOT NULL,
  PRIMARY KEY (`Nama_Pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_admin` */

insert  into `tb_admin`(`Nama_Pengguna`,`Kata_Sandi`) values 
('sely','12345');

/*Table structure for table `tb_ekstrakurikuler` */

DROP TABLE IF EXISTS `tb_ekstrakurikuler`;

CREATE TABLE `tb_ekstrakurikuler` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `NIS` text NOT NULL,
  `Nama` text NOT NULL,
  `Ekstrakurikuler` text NOT NULL,
  `Grade` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_ekstrakurikuler` */

insert  into `tb_ekstrakurikuler`(`Nomor`,`NIS`,`Nama`,`Ekstrakurikuler`,`Grade`) values 
(1,'345678','sely','DESK Language','A');

/*Table structure for table `tb_guru` */

DROP TABLE IF EXISTS `tb_guru`;

CREATE TABLE `tb_guru` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `Nama` text NOT NULL,
  `NUPTK` text NOT NULL,
  `Mata_Pelajaran` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guru` */

insert  into `tb_guru`(`Nomor`,`Nama`,`NUPTK`,`Mata_Pelajaran`) values 
(1,'edwar','987654321','ppkn'),
(2,'ari akbar','987654445','matematika');

/*Table structure for table `tb_kehadiran` */

DROP TABLE IF EXISTS `tb_kehadiran`;

CREATE TABLE `tb_kehadiran` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `NIS` text NOT NULL,
  `Nama` text NOT NULL,
  `Sakit` text NOT NULL,
  `Izin` text NOT NULL,
  `Tanpa_Keterangan` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_kehadiran` */

insert  into `tb_kehadiran`(`Nomor`,`NIS`,`Nama`,`Sakit`,`Izin`,`Tanpa_Keterangan`) values 
(1,'345678','sely','2','0','0');

/*Table structure for table `tb_mata_pelajaran` */

DROP TABLE IF EXISTS `tb_mata_pelajaran`;

CREATE TABLE `tb_mata_pelajaran` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `NIS` text NOT NULL,
  `Nama` text NOT NULL,
  `Pendidikan_Agama` text NOT NULL,
  `PPKN` text NOT NULL,
  `Bahasa_Indonesia` text NOT NULL,
  `Matematika` text NOT NULL,
  `IPA` text NOT NULL,
  `IPS` text NOT NULL,
  `PJOK` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_mata_pelajaran` */

insert  into `tb_mata_pelajaran`(`Nomor`,`NIS`,`Nama`,`Pendidikan_Agama`,`PPKN`,`Bahasa_Indonesia`,`Matematika`,`IPA`,`IPS`,`PJOK`) values 
(1,'345678','sely','90','90','90','90','90','90','90');

/*Table structure for table `tb_prestasi` */

DROP TABLE IF EXISTS `tb_prestasi`;

CREATE TABLE `tb_prestasi` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `NIS` text NOT NULL,
  `Nama` text NOT NULL,
  `Jenis_Prestasi` text NOT NULL,
  `Deskripsi` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_prestasi` */

insert  into `tb_prestasi`(`Nomor`,`NIS`,`Nama`,`Jenis_Prestasi`,`Deskripsi`) values 
(1,'345678','sely','Akademik','Juara 1 KTI');

/*Table structure for table `tb_sikap` */

DROP TABLE IF EXISTS `tb_sikap`;

CREATE TABLE `tb_sikap` (
  `Nomor` int(11) NOT NULL AUTO_INCREMENT,
  `NIS` text NOT NULL,
  `Nama` text NOT NULL,
  `Deskripsi_Sikap` text NOT NULL,
  PRIMARY KEY (`Nomor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_sikap` */

insert  into `tb_sikap`(`Nomor`,`NIS`,`Nama`,`Deskripsi_Sikap`) values 
(1,'345678','sely','Bagus');

/*Table structure for table `tb_siswa` */

DROP TABLE IF EXISTS `tb_siswa`;

CREATE TABLE `tb_siswa` (
  `NIS` varchar(767) NOT NULL,
  `NISN` text NOT NULL,
  `Nama` text NOT NULL,
  `Jenis_Kelamin` text NOT NULL,
  `Alamat` text NOT NULL,
  PRIMARY KEY (`NIS`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_siswa` */

insert  into `tb_siswa`(`NIS`,`NISN`,`Nama`,`Jenis_Kelamin`,`Alamat`) values 
('341233','123452334','aren','perempuan','subang'),
('345635','123456234','atun','perempuan','indramayu'),
('345645','123456677','anti','perempuan','banyumas'),
('345678','123456789','sely','perempuan','kbb');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
