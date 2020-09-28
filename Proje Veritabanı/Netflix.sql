DROP DATABASE netflix;
CREATE DATABASE  IF NOT EXISTS `netflix` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_turkish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `netflix`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: netflix
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Position to start replication or point-in-time recovery from
--

-- CHANGE MASTER TO MASTER_LOG_FILE='OSMAN-bin.000003', MASTER_LOG_POS=156;

--
-- Table structure for table `t_kullanici`
--

DROP TABLE IF EXISTS `t_kullanici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_kullanici` (
  `ad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `dogumtarihi` date NOT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_kullanici`
--

LOCK TABLES `t_kullanici` WRITE;
/*!40000 ALTER TABLE `t_kullanici` DISABLE KEYS */;
INSERT INTO `t_kullanici` VALUES ('osman','osman@gmail.com','1234','2000-05-05'),('osman2','osman2@gmail.com','1234','2000-05-05'),('osman3','osman3@gmail.com','1234','2000-05-05'),('osman4','osman4@gmail.com','1234','2000-05-05'),('osman5','osman5@gmail.com','1234','2000-05-05'),('osman6','osman6@gmail.com','1234','2000-05-05'),('yener','yener@gmail.com','123','2000-04-04'),('yener1','yener1@gmail.com','123','2000-04-04'),('yener2','yener2@gmail.com','123','2000-04-04'),('yener3','yener3@gmail.com','123','2000-04-04'),('yener4','yener4@gmail.com','123','2000-04-04'),('yener5','yener5@gmail.com','123','2000-04-04');
/*!40000 ALTER TABLE `t_kullanici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_kullaniciprogram`
--

DROP TABLE IF EXISTS `t_kullaniciprogram`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_kullaniciprogram` (
  `kullaniciemail` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `programad` varchar(60) COLLATE utf8_turkish_ci NOT NULL,
  `izlenmetarihi` date NOT NULL,
  `izlenmesüresi` int NOT NULL DEFAULT '0',
  `puan` float NOT NULL DEFAULT '0',
  `kalinanbölüm` int NOT NULL DEFAULT '0',
  KEY `kullaniciemail` (`kullaniciemail`),
  KEY `programad` (`programad`),
  CONSTRAINT `t_kullaniciprogram_ibfk_1` FOREIGN KEY (`kullaniciemail`) REFERENCES `t_kullanici` (`email`),
  CONSTRAINT `t_kullaniciprogram_ibfk_2` FOREIGN KEY (`programad`) REFERENCES `t_program` (`ad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_kullaniciprogram`
--

LOCK TABLES `t_kullaniciprogram` WRITE;
/*!40000 ALTER TABLE `t_kullaniciprogram` DISABLE KEYS */;
INSERT INTO `t_kullaniciprogram` VALUES ('osman@gmail.com','72 Sevimli Hayvan','2020-05-05',90,8.3,1),('osman2@gmail.com','Alaca Karanlık','2020-05-05',40,6.1,1),('osman3@gmail.com','Assassin\'s Creed','2020-05-05',8,9,1),('yener@gmail.com','Gezegenimiz','2020-05-05',90,4.4,1),('yener2@gmail.com','Başlangıç','2020-05-05',50,8.3,1),('yener3@gmail.com','Beyblade','2020-05-05',10,3.2,1),('yener4@gmail.com','Büyük Tasarımlar','2020-05-05',50,6.5,1),('osman2@gmail.com','Criminal','2020-05-05',40,6.1,1),('osman3@gmail.com','Da Vinci Şifresi','2020-05-05',8,9,1),('yener@gmail.com','Başlangıç','2020-05-05',90,4.4,1),('yener2@gmail.com','Şirinler','2020-05-05',50,8.3,1),('yener3@gmail.com','Stranger Tings','2020-05-05',10,3.2,1),('yener4@gmail.com','Sonic X','2020-05-05',50,6.5,1),('osman@gmail.com','Shrek','2020-05-05',90,7.1,1),('osman2@gmail.com','Sonic X','2020-05-05',40,6,1),('osman3@gmail.com','Şirinler','2020-05-05',70,7.8,1),('osman4@gmail.com','Ejderhalar','2020-05-05',30,7.5,4),('yener@gmail.com','Kuşçular','2020-05-05',90,4,1),('yener1@gmail.com','Kardeşim Benim','2020-05-05',90,5.1,1),('yener2@gmail.com','Interstellar','2020-05-05',50,8,1),('yener3@gmail.com','How I met your mother','2020-05-05',10,4,1),('yener4@gmail.com','Harry Potter Ölüm Yadigarları','2020-05-05',50,6,1),('osman@gmail.com','Gezegenimiz','2020-05-05',90,8,1),('osman2@gmail.com','Dünyanın En Sıra Dışı Evleri','2020-05-05',40,6,1),('osman3@gmail.com','Ejderhalar','2020-05-05',70,9,1),('osman4@gmail.com','Delibal','2020-05-05',30,8,4),('yener@gmail.com','Da Vinci Şifresi','2020-05-05',90,4,1),('yener1@gmail.com','Charlie\'nin Çikolata Fabrikası','2020-05-05',90,8,1),('yener2@gmail.com','Car Masters','2020-05-05',50,8,1),('yener3@gmail.com','Büyük Tasarımlar','2020-05-05',10,3,1),('yener4@gmail.com','Beyblade','2020-05-05',50,6,1),('osman@gmail.com','Başlangıç','2020-05-05',90,8,1),('osman2@gmail.com','72 Sevimli Hayvan','2020-05-05',40,6,1),('osman3@gmail.com','Assassin\'s Creed','2020-05-05',70,9,1),('osman4@gmail.com','Yerçekimi','2020-05-05',30,8,4),('yener@gmail.com','The Originals','2020-05-05',90,4,1),('yener1@gmail.com','The Blacklist','2020-05-05',90,8,1),('yener2@gmail.com','Stranger Tings','2020-05-05',50,8,1),('yener3@gmail.com','Mission Blue','2020-05-05',10,3,1),('yener4@gmail.com','Leyla ile Mecnun','2020-05-05',50,6,1);
/*!40000 ALTER TABLE `t_kullaniciprogram` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_program`
--

DROP TABLE IF EXISTS `t_program`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_program` (
  `ad` varchar(60) COLLATE utf8_turkish_ci NOT NULL,
  `tip` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `bölümsayisi` int NOT NULL,
  `programuzunluk` int NOT NULL,
  PRIMARY KEY (`ad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_program`
--

LOCK TABLES `t_program` WRITE;
/*!40000 ALTER TABLE `t_program` DISABLE KEYS */;
INSERT INTO `t_program` VALUES ('72 Sevimli Hayvan','Film',1,120),('Alaca Karanlık','Film',1,120),('Assassin\'s Creed','Film',1,120),('Başlangıç','Film',1,120),('Beyblade','Dizi',8,40),('Büyük Tasarımlar','Tv Show',4,40),('Car Masters','Tv Show',4,40),('Charlie\'nin Çikolata Fabrikası','Film',1,120),('Criminal','Dizi',8,40),('Da Vinci Şifresi','Film',1,120),('Delibal','Film',1,120),('Dünyanın En Sıra Dışı Evleri','Tv Show',4,40),('Ejderhalar','Dizi',8,40),('Gezegenimiz','Film',1,120),('Harry Potter Ölüm Yadigarları','Film',1,120),('How I met your mother','Dizi',8,40),('Interstellar','Film',1,120),('Jaws','Film',1,120),('Kardeşim Benim','Film',1,120),('Kuşçular','Film',1,120),('Leyla ile Mecnun','Dizi',8,40),('Mission Blue','Film',1,120),('Patron Bebek Yine İş Başında','Film',1,120),('Shrek','Film',1,120),('Sonic X','Dizi',8,40),('Stranger Tings','Dizi',8,40),('Şirinler','Film',1,120),('The Blacklist','Dizi',8,40),('The Originals','Dizi',8,40),('Yerçekimi','Film',1,120);
/*!40000 ALTER TABLE `t_program` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_programtur`
--

DROP TABLE IF EXISTS `t_programtur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_programtur` (
  `programad` varchar(60) COLLATE utf8_turkish_ci NOT NULL,
  `turad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  KEY `turad` (`turad`),
  KEY `t_programtur_ibfk_1` (`programad`),
  CONSTRAINT `t_programtur_ibfk_1` FOREIGN KEY (`programad`) REFERENCES `t_program` (`ad`) ON DELETE CASCADE,
  CONSTRAINT `t_programtur_ibfk_2` FOREIGN KEY (`turad`) REFERENCES `t_tur` (`turad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_programtur`
--

LOCK TABLES `t_programtur` WRITE;
/*!40000 ALTER TABLE `t_programtur` DISABLE KEYS */;
INSERT INTO `t_programtur` VALUES ('Assassin\'s Creed','Aksiyon ve Macera'),('Assassin\'s Creed','Bilim Kurgu ve Fantastik'),('Alaca Karanlık','Aksiyon ve Macera'),('Alaca Karanlık','Romantizm'),('Başlangıç','Aksiyon ve Macera'),('Interstellar','Aksiyon ve Macera'),('Interstellar','Drama'),('Harry Potter Ölüm Yadigarları','Aksiyon ve Macera'),('Harry Potter Ölüm Yadigarları','Bilim Kurgu ve Fantastik'),('Harry Potter Ölüm Yadigarları','Çocuk ve Aile'),('Mission Blue','Belgesel'),('Gezegenimiz','Belgesel'),('72 Sevimli Hayvan','Belgesel'),('Kuşçular','Belgesel'),('Şirinler','Çocuk ve Aile'),('Şirinler','Komedi'),('Charlie\'nin Çikolata Fabrikası','Komedi'),('Charlie\'nin Çikolata Fabrikası','Çocuk ve Aile'),('Shrek','Çocuk ve Aile'),('Shrek','Komedi'),('Delibal','Drama'),('Delibal','Romantizm'),('Kardeşim Benim','Drama'),('Kardeşim Benim','Komedi'),('Yerçekimi','Drama'),('Yerçekimi','Bilim Kurgu ve Fantastik'),('Jaws','Gerilim'),('Da Vinci Şifresi','Gerilim'),('Ejderhalar','Aksiyon ve Macera'),('Ejderhalar','Çocuk ve Aile'),('How I met your mother','Romantizm'),('Leyla ile Mecnun','Romantizm'),('Gezegenimiz','Bilim ve Doğa'),('72 Sevimli Hayvan','Bilim ve Doğa'),('Kuşçular','Bilim ve Doğa'),('Patron Bebek Yine İş Başında','Çocuk ve Aile'),('Patron Bebek Yine İş Başında','Komedi'),('Stranger Tings','Aksiyon ve Macera'),('Stranger Tings','Korku'),('The Originals','Drama'),('The Originals','Korku'),('Criminal','Gerilim'),('Beyblade','Anime'),('Beyblade','Çocuk ve Aile'),('Sonic X','Anime'),('Sonic X','Aksiyon ve Macera'),('The Blacklist','Aksiyon ve Macera'),('The Blacklist','Gerilim'),('Dünyanın En Sıra Dışı Evleri','Reality Program'),('Car Masters','Reality Program'),('Büyük Tasarımlar','Reality Program');
/*!40000 ALTER TABLE `t_programtur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_tur`
--

DROP TABLE IF EXISTS `t_tur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_tur` (
  `turad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`turad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_tur`
--

LOCK TABLES `t_tur` WRITE;
/*!40000 ALTER TABLE `t_tur` DISABLE KEYS */;
INSERT INTO `t_tur` VALUES ('Aksiyon ve Macera'),('Anime'),('Belgesel'),('Bilim Kurgu ve Fantastik'),('Bilim ve Doğa'),('Çocuk ve Aile'),('Drama'),('Gerilim'),('Komedi'),('Korku'),('Reality Program'),('Romantizm');
/*!40000 ALTER TABLE `t_tur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'netflix'
--

--
-- Dumping routines for database 'netflix'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-30 22:07:48
