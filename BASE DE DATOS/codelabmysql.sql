-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: codelabagencia
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (48,'Jorge ','Ferreira',5497689,'099730001','Julio Delgado 1145',1),(47,'Pedro','perez',5565756,'099785745','Jdelado 124',0),(58,'Renzo','Mac Eachen',55427370,'098593943','Dubai',0),(60,'Juan','Gimenez',23456789,'099439251','urugauy 657',1),(61,'Roberto','Cordero',365356,'09960834','3343',0),(62,'mi','huevoduro',55662244,'','',1),(63,'Pedro el','1',1,'hhhh','1',1);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `jefe`
--

LOCK TABLES `jefe` WRITE;
/*!40000 ALTER TABLE `jefe` DISABLE KEYS */;
/*!40000 ALTER TABLE `jefe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `moneda`
--

LOCK TABLES `moneda` WRITE;
/*!40000 ALTER TABLE `moneda` DISABLE KEYS */;
INSERT INTO `moneda` VALUES (1,'Dólar',37.30,39.70),(2,'Euro',38.27,42.93),(3,'Peso Argentino',0.03,0.25),(4,'Real',7.10,8.80),(5,'Peso Uruguayo',1.00,1.00);
/*!40000 ALTER TABLE `moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `prestamo`
--

LOCK TABLES `prestamo` WRITE;
/*!40000 ALTER TABLE `prestamo` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `transacción`
--

LOCK TABLES `transacción` WRITE;
/*!40000 ALTER TABLE `transacción` DISABLE KEYS */;
/*!40000 ALTER TABLE `transacción` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'JEFE','Franco','Ferrari','fferrari114520@gmail.com','a5bef651c8e3fd6cc63c43cd6bc1341af97d78af828f152c0f40d5a06570bd34'),(6,'1','1','1','1','6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b'),(3,'User1','Luis','Alfre','ggt3','c81ce2684a7b8d8738cd9a978e5e1acc846eca4b92686420bc1e641d287c4e80'),(4,'a','a','a','a','ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb'),(5,'3','3','3','3','4e07408562bedb8b60ce05c1decfe3ad16b72230967de01f640b7e4729b49fce'),(8,'zomacfit','Renzo','Mac Eachen','renzomaceachen@gmail.com','79be79e1502a22cb6813939a2e8fe5ed231a92693f6ff1b5dccfc5567fe4ecec'),(9,'USER2','Franco','Ferrari','145','a5bef651c8e3fd6cc63c43cd6bc1341af97d78af828f152c0f40d5a06570bd34'),(10,'Fix','Fix','Ferrari','fitzgeral1@gmail.com','a5813ad799f804b5cc8d127f9c7e4e09cf96ce2135b9f77b379881a0ab2d1aec'),(11,'Poroto','Romaldo','Gutierrez','tumamaprogeimer@gmail.com','97a62ad21d79c01cceb7767952acec4fec86bfe909b06e5f3f6963365cf91ab8');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-29 22:59:53
