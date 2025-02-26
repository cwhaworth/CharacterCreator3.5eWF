-- MySQL Script generated by MySQL Workbench
-- Sat Jan 23 16:15:06 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema CharacterCreatorDnDe3.5
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema CharacterCreatorDnDe3.5
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `CharacterCreatorDnDe3.5` DEFAULT CHARACTER SET utf8 ;
USE `CharacterCreatorDnDe3.5` ;

-- -----------------------------------------------------
-- Table `CharacterCreatorDnDe3.5`.`Races`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CharacterCreatorDnDe3.5`.`Races` (
  `idRaces` INT(10) NOT NULL AUTO_INCREMENT,
  `RaceName` VARCHAR(45) NOT NULL,
  `FClass` VARCHAR(45) NOT NULL,
  `Size` VARCHAR(45) NOT NULL,
  `Speed` INT(10) NOT NULL,
  `AdjustStr` INT(10) NOT NULL,
  `AdjustDex` INT(10) NOT NULL,
  `AdjustCon` INT(10) NOT NULL,
  `AdjustInt` INT(10) NOT NULL,
  `AdjustWis` INT(10) NOT NULL,
  `AdjustCha` INT(10) NOT NULL,
  PRIMARY KEY (`idRaces`),
  UNIQUE INDEX `idRaces_UNIQUE` (`idRaces` ASC) VISIBLE)
ENGINE = InnoDB;

USE `CharacterCreatorDnDe3.5`;

DELIMITER $$
USE `CharacterCreatorDnDe3.5`$$
CREATE DEFINER = CURRENT_USER TRIGGER `mydb`.`Races_BEFORE_INSERT` BEFORE INSERT ON `Races` FOR EACH ROW
BEGIN

END
$$


DELIMITER ;
CREATE USER 'cwhaworth' IDENTIFIED BY 'R3d50x#358';
GRANT ALL PRIVILEGES ON 'CharacterCreatorDnDe3.5'.* to 'cwhaworth'@'localhost';


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
