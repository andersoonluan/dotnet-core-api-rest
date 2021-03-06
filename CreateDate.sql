



CREATE TABLE `persons` (
	`Id` int(10) UNSIGNED NULL DEFAULT NULL,
	`Name` VARCHAR(50) NULL DEFAULT NULL,
	`LastName` VARCHAR(50) NULL DEFAULT NULL,
	`Country` VARCHAR(50) NULL DEFAULT NULL,
    `City` VARCHAR(50) NULL DEFAULT NULL,
    `Address` VARCHAR(50) NULL DEFAULT NULL,
	`Gender` VARCHAR(50) NULL DEFAULT NULL,
    `Age`  INTEGER NULL DEFAULT NULL,
    `Birthday` DATE NULL DEFAULT NULL,
    `Email` VARCHAR(50) NULL DEFAULT NULL,
    `CreateOn` DATETIME  DEFAULT now()
)
ENGINE=InnoDB
;


selecT* from persons


CREATE TABLE `books` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `Author` longtext,
  `LaunchDate` datetime(6) NOT NULL,
  `Price` decimal(65,2) NOT NULL,
  `Title` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `skills` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `Name` VARCHAR(50) NOT NULL ,
  `CreateOn` DATETIME 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `interests` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `Name` VARCHAR(50) NOT NULL ,
  `CreateOn` DATETIME 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE `login` (
	`ID` INT(10) NOT NULL AUTO_INCREMENT,
	`LoginUser` VARCHAR(50) UNIQUE NOT NULL,
	`AccessKey` VARCHAR(50) NOT NULL,
	PRIMARY KEY (`ID`)
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB;

INSERT INTO `login` (`LoginUser`, `AccessKey`) VALUES ('anderson','senha123');