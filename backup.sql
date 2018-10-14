-- MySQL dump 10.13  Distrib 8.0.12, for macos10.13 (x86_64)
--
-- Host: 127.0.0.1    Database: rest_api
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `books` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Author` longtext,
  `LaunchDate` datetime(6) NOT NULL,
  `Price` decimal(65,2) NOT NULL,
  `Title` longtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Michael C. Feathers','2017-11-29 13:50:05.878000',49.00,'Working effectively with legacy code'),(2,'Ralph Johnson, Erich Gamma, John Vlissides e Richard Helm','2017-11-29 15:15:13.636000',45.00,'Design Patterns'),(3,'Robert C. Martin','2009-01-10 00:00:00.000000',77.00,'Clean Code'),(4,'Crockford','2017-11-07 15:09:01.674000',67.00,'JavaScript'),(5,'Steve McConnell','2017-11-07 15:09:01.674000',58.00,'Code complete'),(6,'Martin Fowler e Kent Beck','2017-11-07 15:09:01.674000',88.00,'Refactoring'),(7,'Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates','2017-11-07 15:09:01.674000',110.00,'Head First Design Patterns'),(8,'Eric Evans','2017-11-07 15:09:01.674000',92.00,'Domain Driven Design'),(9,'Brian Goetz e Tim Peierls','2017-11-07 15:09:01.674000',80.00,'Java Concurrency in Practice'),(10,'Susan Cain','2017-11-07 15:09:01.674000',123.00,'O poder dos quietos'),(11,'Roger S. Pressman','2017-11-07 15:09:01.674000',56.00,'Engenharia de Software: uma abordagem profissional'),(12,'Viktor Mayer-Schonberger e Kenneth Kukier','2017-11-07 15:09:01.674000',54.00,'Big Data: como extrair volume, variedade, velocidade e valor da avalanche de informação cotidiana'),(13,'Richard Hunter e George Westerman','2017-11-07 15:09:01.674000',95.00,'O verdadeiro valor de TI'),(14,'Marc J. Schiller','2017-11-07 15:09:01.674000',45.00,'Os 11 segredos de líderes de TI altamente influentes'),(15,'Aguinaldo Aragon Fernandes e Vladimir Ferraz de Abreu','2017-11-07 15:09:01.674000',54.00,'Implantando a governança de TI'),(16,'Anderson Rodrigues','2017-11-29 13:50:05.878000',99.90,'Segredos da Mente Milionaria');
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `interests`
--

DROP TABLE IF EXISTS `interests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `interests` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `CreateOn` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interests`
--

LOCK TABLES `interests` WRITE;
/*!40000 ALTER TABLE `interests` DISABLE KEYS */;
INSERT INTO `interests` VALUES (1,'Desenvolvimento Mobile','2018-09-28 22:54:40'),(2,'Desenvolvimento Web','2018-09-28 22:54:46'),(3,'UX / UI Design','2018-09-28 22:55:19'),(4,'Marketing Digital','2018-09-28 22:55:34'),(5,'Data Science','2018-09-28 22:55:44'),(6,'Deep Learning','2018-09-28 22:55:54'),(7,'Inteligência Artificial','2018-09-28 22:56:12'),(8,'Banco de Dados','2018-09-28 22:56:28'),(9,'Jornalismo','2018-09-28 22:56:34');
/*!40000 ALTER TABLE `interests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `login` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `LoginUser` varchar(50) NOT NULL,
  `AccessKey` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `LoginUser` (`LoginUser`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,'anderson','senha123');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PERSONS`
--

DROP TABLE IF EXISTS `PERSONS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `PERSONS` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Country` varchar(50) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `CreateOn` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PERSONS`
--

LOCK TABLES `PERSONS` WRITE;
/*!40000 ALTER TABLE `PERSONS` DISABLE KEYS */;
INSERT INTO `PERSONS` VALUES (1,'Anderson Luan','Souza Rodrigues','United States','Porto Alegre','Manoelito de Ornelas, 55','Male',23,'1994-08-03','andersoonluan@gmail.com','0001-01-01 00:00:00'),(4,'Barbara','Buttow Azzolin','Brasil','Porto Alegre','Dom Diogo de Souza, 661','Female',25,'1993-01-07','barbara.buttow@gmail.com','2018-09-29 20:32:09'),(5,'Madeline','McMichan','Brazil','Muzambinho','Bultman','Female',1,'2017-12-03','mmcmichan0@yahoo.com','2018-09-29 21:03:43'),(6,'Elysha','Whyteman','Philippines','Danao','Londonderry','Female',2,'2017-09-28','ewhyteman1@360.cn','2018-09-29 21:03:44'),(7,'Katherine','Robberecht','Poland','Blizne','Bunting','Female',3,'2015-12-18','krobberecht2@columbia.edu','2018-09-29 21:03:44'),(8,'Janelle','Tomasino','Tajikistan','Kolkhozobod','Tennessee','Female',4,'2018-05-19','jtomasino3@adobe.com','2018-09-29 21:03:44'),(9,'Susanne','Munkton','Czech Republic','Lidečko','Chive','Female',5,'2015-09-25','smunkton4@irs.gov','2018-09-29 21:03:44'),(10,'Laetitia','Cluderay','Netherlands','Leiden','Dennis','Female',6,'2015-10-28','lcluderay5@ameblo.jp','2018-09-29 21:03:44'),(11,'Dehlia','Feeny','Honduras','Chotepe','Miller','Female',7,'2015-10-04','dfeeny6@imgur.com','2018-09-29 21:03:44'),(12,'Svend','Crease','Haiti','Belle-Anse','Texas','Male',8,'2016-01-07','screase7@zdnet.com','2018-09-29 21:03:44'),(13,'Tomkin','McPherson','China','Shangdian','Mallory','Male',9,'2015-08-18','tmcpherson8@mail.ru','2018-09-29 21:03:44'),(14,'Faber','Stead','Indonesia','Solok','Mcbride','Male',10,'2016-12-02','fstead9@vk.com','2018-09-29 21:03:44'),(15,'Janaya','Ledster','Russia','Povorino','Sycamore','Female',11,'2016-11-24','jledstera@mashable.com','2018-09-29 21:03:44'),(16,'Linell','Stichall','China','Xiqi','Crest Line','Female',12,'2016-11-20','lstichallb@networksolutions.com','2018-09-29 21:03:44'),(17,'Normand','Deeprose','New Zealand','Taupo','Hauk','Male',13,'2016-08-16','ndeeprosec@phpbb.com','2018-09-29 21:03:44'),(18,'Glendon','Epine','Dominican Republic','Jarabacoa','Glendale','Male',14,'2017-03-11','gepined@de.vu','2018-09-29 21:03:44'),(19,'Marlane','Houtby','Lithuania','Kulautuva','Lakeland','Female',15,'2015-04-03','mhoutbye@nyu.edu','2018-09-29 21:03:44'),(20,'Erhart','Seys','China','Youdian','Park Meadow','Male',16,'2015-10-29','eseysf@amazon.co.uk','2018-09-29 21:03:44'),(21,'Ailee','Walicki','China','Longshan','Bonner','Female',17,'2018-03-01','awalickig@chronoengine.com','2018-09-29 21:03:44'),(22,'Gerrard','Shambrooke','China','Guohe','Manitowish','Male',18,'2016-05-30','gshambrookeh@rambler.ru','2018-09-29 21:03:44'),(23,'Gerladina','Heinzel','Indonesia','Jambean','Declaration','Female',19,'2016-05-18','gheinzeli@reference.com','2018-09-29 21:03:44'),(24,'Anatola','Lyttle','Indonesia','Bogorame','Hudson','Female',20,'2017-09-11','alyttlej@php.net','2018-09-29 21:03:44'),(25,'Johnathan','Moogan','Mexico','Loma Bonita','Blaine','Male',21,'2017-04-19','jmoogank@imageshack.us','2018-09-29 21:03:44'),(26,'Jessalyn','McCheyne','Portugal','São Lourenço de Mamporcão','Kipling','Female',22,'2015-05-15','jmccheynel@mozilla.com','2018-09-29 21:03:44'),(27,'Lin','Surgeoner','Indonesia','Pameungpeuk','Cardinal','Male',23,'2015-06-20','lsurgeonerm@who.int','2018-09-29 21:03:44'),(28,'Durand','Knok','Colombia','Caparrapí','Coolidge','Male',24,'2015-07-12','dknokn@histats.com','2018-09-29 21:03:44'),(29,'Brade','Maskelyne','Portugal','Santa Marta de Penaguião','Thompson','Male',25,'2018-07-08','bmaskelyneo@tumblr.com','2018-09-29 21:03:44'),(30,'Siward','Bow','Tanzania','Dodoma','Beilfuss','Male',26,'2018-04-02','sbowp@netlog.com','2018-09-29 21:03:44'),(31,'Mariya','Bagniuk','China','Haizigou','Charing Cross','Female',27,'2015-05-22','mbagniukq@meetup.com','2018-09-29 21:03:44'),(32,'Bobbe','Jeandet','Indonesia','Cumedak','Hovde','Female',28,'2017-07-10','bjeandetr@mysql.com','2018-09-29 21:03:44'),(33,'Wyndham','Fillimore','Norway','Bergen','Maple Wood','Male',29,'2017-11-16','wfillimores@friendfeed.com','2018-09-29 21:03:44'),(34,'Arlyn','Dymidowicz','Belarus','Kapyl’','Westend','Female',30,'2018-08-27','adymidowiczt@state.tx.us','2018-09-29 21:03:44'),(35,'Mayor','Lacelett','France','Marseille','Pine View','Male',31,'2016-02-21','mlacelettu@usa.gov','2018-09-29 21:03:44'),(36,'Tomlin','Molyneux','China','Dinggou','Northwestern','Male',32,'2016-07-16','tmolyneuxv@jalbum.net','2018-09-29 21:03:44'),(37,'Maddy','Tuite','Tunisia','Banbalah','Lunder','Female',33,'2016-04-23','mtuitew@blogs.com','2018-09-29 21:03:44'),(38,'Huntington','O\'Lennane','China','Tangqian','Manley','Male',34,'2016-09-17','holennanex@webeden.co.uk','2018-09-29 21:03:44'),(39,'Fitzgerald','Heigho','Serbia','Stari Banovci','Gulseth','Male',35,'2015-07-12','fheighoy@oaic.gov.au','2018-09-29 21:03:44'),(40,'Skipp','Hunn','China','Dianqian','Oak Valley','Male',36,'2016-09-30','shunnz@dmoz.org','2018-09-29 21:03:44'),(41,'Hope','Deer','Denmark','København','Blue Bill Park','Female',37,'2018-07-29','hdeer10@wikimedia.org','2018-09-29 21:03:44'),(42,'Kendre','Brough','China','Dehui','Rigney','Female',38,'2015-05-09','kbrough11@odnoklassniki.ru','2018-09-29 21:03:44'),(43,'Chandra','Pettyfer','Serbia','Mali Iđoš','David','Female',39,'2017-08-01','cpettyfer12@vistaprint.com','2018-09-29 21:03:44'),(44,'Bennett','Maggi','Indonesia','Ngarus','Spenser','Male',40,'2017-05-07','bmaggi13@soup.io','2018-09-29 21:03:44'),(45,'Joellyn','Lamden','Venezuela','Tucupido','Heath','Female',41,'2015-12-30','jlamden14@microsoft.com','2018-09-29 21:03:44'),(46,'Belicia','Halson','Greece','Skotoússa','Dapin','Female',42,'2018-04-03','bhalson15@salon.com','2018-09-29 21:03:44'),(47,'Christoper','Devereux','Egypt','Maţāy','Onsgard','Male',43,'2017-07-18','cdevereux16@dailymotion.com','2018-09-29 21:03:44'),(48,'Jonie','Bridden','New Zealand','Taradale','Delaware','Female',44,'2016-09-21','jbridden17@huffingtonpost.com','2018-09-29 21:03:44'),(49,'Ludwig','Biddlestone','Brazil','Ibiporã','Service','Male',45,'2018-01-08','lbiddlestone18@1und1.de','2018-09-29 21:03:44'),(50,'Kylila','Chapier','Russia','Zhulebino','Carioca','Female',46,'2015-04-01','kchapier19@princeton.edu','2018-09-29 21:03:44'),(51,'Carine','Adanez','Indonesia','Puger','Anhalt','Female',47,'2017-07-05','cadanez1a@adobe.com','2018-09-29 21:03:44'),(52,'Karil','Cubuzzi','Poland','Kolonowskie','Macpherson','Female',48,'2016-11-20','kcubuzzi1b@cisco.com','2018-09-29 21:03:44'),(53,'Waverley','Roots','Poland','Brzeszcze','Prairieview','Male',49,'2016-04-03','wroots1c@free.fr','2018-09-29 21:03:44'),(54,'Emmalynne','Gray','Sweden','Ekerö','Anderson','Female',50,'2017-10-25','egray1d@latimes.com','2018-09-29 21:03:44'),(55,'Angeline','Alleyn','Indonesia','Naebugis','Dakota','Female',51,'2018-04-15','aalleyn1e@washington.edu','2018-09-29 21:03:44'),(56,'Gabbie','Baude','Sweden','Strängnäs','Northfield','Female',52,'2017-05-17','gbaude1f@paypal.com','2018-09-29 21:03:44'),(57,'Byron','Pabel','Portugal','Ponte Nova','Boyd','Male',53,'2015-05-18','bpabel1g@gizmodo.com','2018-09-29 21:03:44'),(58,'Kristos','Alcorn','Indonesia','Cipesing','International','Male',54,'2015-02-01','kalcorn1h@github.com','2018-09-29 21:03:44'),(59,'Peterus','Gravenall','China','Yuanyang','Anhalt','Male',55,'2016-11-04','pgravenall1i@earthlink.net','2018-09-29 21:03:44'),(60,'Cleve','Lehemann','Poland','Tuchola','Nelson','Male',56,'2017-05-16','clehemann1j@privacy.gov.au','2018-09-29 21:03:44'),(61,'Korney','Stratz','Indonesia','Sulang Tengah','Caliangt','Female',57,'2015-12-14','kstratz1k@si.edu','2018-09-29 21:03:44'),(62,'Roldan','Kloisner','Ukraine','Horodne','Longview','Male',58,'2016-11-14','rkloisner1l@canalblog.com','2018-09-29 21:03:44'),(63,'Herman','Durie','Afghanistan','Qal‘ah-ye Kuhnah','Longview','Male',59,'2018-02-26','hdurie1m@yellowbook.com','2018-09-29 21:03:44'),(64,'Marlyn','Burgiss','China','Fanyang','Pawling','Female',60,'2015-12-25','mburgiss1n@ucoz.com','2018-09-29 21:03:44'),(65,'Ardith','Anselm','Canada','Marieville','Main','Female',61,'2018-04-15','aanselm1o@furl.net','2018-09-29 21:03:44'),(66,'Eloise','Oliva','Argentina','Totoras','Meadow Vale','Female',62,'2016-07-05','eoliva1p@narod.ru','2018-09-29 21:03:44'),(67,'Tiler','Minchella','Denmark','København','Carberry','Male',63,'2016-09-29','tminchella1q@fastcompany.com','2018-09-29 21:03:44'),(68,'Maribeth','Nanelli','Japan','Shimokizukuri','Redwing','Female',64,'2018-08-21','mnanelli1r@trellian.com','2018-09-29 21:03:44'),(69,'Lyndsie','Tidman','Brazil','Nazaré','Banding','Female',65,'2017-06-01','ltidman1s@amazon.de','2018-09-29 21:03:44'),(70,'Orv','Francioli','Faroe Islands','Eystur','Johnson','Male',66,'2018-04-12','ofrancioli1t@vinaora.com','2018-09-29 21:03:44'),(71,'Carmine','Harmeston','Indonesia','Waigete','Acker','Male',67,'2015-02-19','charmeston1u@biblegateway.com','2018-09-29 21:03:44'),(72,'Man','Yeoman','Kuwait','Salwá','Arrowood','Male',68,'2018-08-05','myeoman1v@bigcartel.com','2018-09-29 21:03:44'),(73,'Teodoor','Matteoni','Uruguay','Baltasar Brum','Northfield','Male',69,'2017-08-10','tmatteoni1w@dedecms.com','2018-09-29 21:03:44'),(74,'Roman','Glanton','Portugal','Vilarelho','Southridge','Male',70,'2016-04-19','rglanton1x@github.io','2018-09-29 21:03:44'),(75,'Rafferty','Frostick','Russia','Bogovarovo','Fairview','Male',71,'2018-06-28','rfrostick1y@blinklist.com','2018-09-29 21:03:44'),(76,'Anatole','Eastway','Indonesia','Simpang','5th','Male',72,'2015-04-28','aeastway1z@cbc.ca','2018-09-29 21:03:44'),(77,'Shantee','Soonhouse','Japan','Sasebo','Vermont','Female',73,'2017-10-18','ssoonhouse20@vistaprint.com','2018-09-29 21:03:44'),(78,'Nathalie','Venard','Greece','Gerakaroú','Hagan','Female',74,'2015-08-21','nvenard21@rediff.com','2018-09-29 21:03:44'),(79,'Lynne','Glasscott','Canada','Hudson','Bluestem','Female',75,'2017-11-18','lglasscott22@narod.ru','2018-09-29 21:03:44'),(80,'Irita','Moores','Peru','Pomahuaca','Parkside','Female',76,'2017-12-11','imoores23@hhs.gov','2018-09-29 21:03:44'),(81,'Valencia','Dorre','Russia','Anzhero-Sudzhensk','Prairieview','Female',77,'2018-07-07','vdorre24@xrea.com','2018-09-29 21:03:44'),(82,'Claus','Wainman','Colombia','Chigorodó','Twin Pines','Male',78,'2018-02-04','cwainman25@blog.com','2018-09-29 21:03:44'),(83,'Flossi','Trathen','France','Seynod','Carpenter','Female',79,'2018-05-17','ftrathen26@webs.com','2018-09-29 21:03:44'),(84,'Vasilis','Kinnie','Benin','Cové','Village Green','Male',80,'2016-03-05','vkinnie27@lycos.com','2018-09-29 21:03:44'),(85,'Olenolin','Twitchings','Mauritania','Sélibabi','Moulton','Male',81,'2015-04-29','otwitchings28@lulu.com','2018-09-29 21:03:44'),(86,'Elna','Chaise','Russia','Shadrinsk','Nelson','Female',82,'2015-03-20','echaise29@ifeng.com','2018-09-29 21:03:44'),(87,'Tiphani','Brushneen','North Korea','Hyesan-dong','Ludington','Female',83,'2016-02-24','tbrushneen2a@chron.com','2018-09-29 21:03:44'),(88,'Roby','Shillington','Philippines','Napnapan','Maywood','Female',84,'2017-01-27','rshillington2b@wordpress.com','2018-09-29 21:03:44'),(89,'Robb','Falconer','China','Lianhua','Schurz','Male',85,'2018-02-12','rfalconer2c@unc.edu','2018-09-29 21:03:44'),(90,'Rollie','Cookes','Indonesia','Bireun','Briar Crest','Male',86,'2016-05-23','rcookes2d@arstechnica.com','2018-09-29 21:03:44'),(91,'Anstice','Chitty','France','Dijon','Merchant','Female',87,'2017-10-04','achitty2e@desdev.cn','2018-09-29 21:03:44'),(92,'Bekki','Rey','Iran','Jīroft','Bay','Female',88,'2017-10-03','brey2f@dot.gov','2018-09-29 21:03:44'),(93,'Ariella','Reskelly','Ukraine','Krasnodon','Kingsford','Female',89,'2015-04-04','areskelly2g@dion.ne.jp','2018-09-29 21:03:44'),(94,'Gun','Clulow','Palestinian Territory','Majdal Banī Fāḑil','Brown','Male',90,'2017-11-22','gclulow2h@un.org','2018-09-29 21:03:44'),(95,'Sileas','Kohtler','Brazil','Araranguá','Commercial','Female',91,'2018-04-13','skohtler2i@nifty.com','2018-09-29 21:03:44'),(96,'Alexei','Koschke','China','Yong’an','Dwight','Male',92,'2017-08-05','akoschke2j@tuttocitta.it','2018-09-29 21:03:44'),(97,'Queenie','Jirek','Brazil','São Gabriel','Tennessee','Female',93,'2018-02-01','qjirek2k@admin.ch','2018-09-29 21:03:44'),(98,'Cam','Vellden','Guatemala','San Antonio Suchitepéquez','Dovetail','Male',94,'2017-12-13','cvellden2l@weather.com','2018-09-29 21:03:44'),(99,'Alayne','Beecraft','China','Yonggu','Tennyson','Female',95,'2018-01-10','abeecraft2m@reuters.com','2018-09-29 21:03:44'),(100,'Antonietta','Abson','Czech Republic','Zadní Mostek','Independence','Female',96,'2017-02-08','aabson2n@usatoday.com','2018-09-29 21:03:44'),(101,'Tova','Broadbear','Sweden','Stockholm','Corscot','Female',97,'2017-10-12','tbroadbear2o@edublogs.org','2018-09-29 21:03:44'),(102,'Reuben','Tremelling','Indonesia','Muesanaik','Maryland','Male',98,'2015-12-26','rtremelling2p@utexas.edu','2018-09-29 21:03:44'),(103,'Patrice','Whithorn','Netherlands','Arnhem','Summit','Male',99,'2016-05-09','pwhithorn2q@smh.com.au','2018-09-29 21:03:44'),(104,'Stepha','Di Frisco','Poland','Straszyn','East','Female',100,'2018-05-07','sdifrisco2r@nytimes.com','2018-09-29 21:03:44');
/*!40000 ALTER TABLE `PERSONS` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `skills`
--

DROP TABLE IF EXISTS `skills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `skills` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `CreateOn` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skills`
--

LOCK TABLES `skills` WRITE;
/*!40000 ALTER TABLE `skills` DISABLE KEYS */;
INSERT INTO `skills` VALUES (1,'.NET Framework','2018-09-28 22:29:57'),(2,'.NET Core','2018-09-28 22:30:09'),(3,'PHP','2018-09-28 22:30:37'),(4,'HTML5','2018-09-28 22:30:49'),(5,'CSS3','2018-09-28 22:30:53'),(6,'SQL Server','2018-09-28 22:30:59'),(7,'Oracle','2018-09-28 22:31:08'),(8,'Python','2018-09-28 22:56:44'),(9,'Go Lang','2018-09-28 22:56:49'),(10,'MongoDB','2018-09-28 22:56:58'),(11,'GraphQL','2018-09-28 22:57:09'),(12,'React','2018-09-28 22:57:13'),(13,'NodeJS','2018-09-28 22:57:57'),(14,'Swift','2018-09-28 22:58:04'),(15,'Android','2018-09-28 22:58:07'),(16,'PowerShell','2018-09-28 22:58:19'),(17,'UX Writer','2018-09-28 22:58:43'),(18,'Magento','2018-09-28 22:58:47'),(19,'OpenCart','2018-09-28 22:58:52'),(20,'Wordpress','2018-09-28 22:58:55'),(21,'Email Marketing','2018-09-28 22:59:16'),(22,'Criação de Conteúdo','2018-09-28 22:59:35'),(23,'Jornalismo Esportivo','2018-09-28 22:59:46'),(24,'Servidores Linux','2018-09-28 22:59:56'),(25,'Servidores Windows','2018-09-28 23:00:00');
/*!40000 ALTER TABLE `skills` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-06 21:10:07
