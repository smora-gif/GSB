-- =====================================================
-- Projet GSB - Application Ordonnances
-- Script de création de la base de données MySQL
-- =====================================================
-- Auteur : Cours BTS SIO
-- SGBD cible : MySQL 8.0+ / MariaDB 10.3+
-- =====================================================

-- Création de la base si elle n'existe pas
CREATE DATABASE IF NOT EXISTS gsb_ordonnances
    DEFAULT CHARACTER SET utf8mb4
    DEFAULT COLLATE utf8mb4_unicode_ci;

USE gsb_ordonnances;

-- Suppression des tables existantes (ordre inverse de création
-- pour respecter les contraintes de clés étrangères)
DROP TABLE IF EXISTS ETRE_ALLERGIQUE;
DROP TABLE IF EXISTS CONTENIR;
DROP TABLE IF EXISTS ORDONNANCE;
DROP TABLE IF EXISTS ALLERGIE;
DROP TABLE IF EXISTS MEDICAMENT;
DROP TABLE IF EXISTS MEDECIN;
DROP TABLE IF EXISTS PATIENT;


-- -----------------------------------------------------
-- Table PATIENT
-- -----------------------------------------------------
CREATE TABLE PATIENT (
    numPatient      INT             NOT NULL AUTO_INCREMENT,
    nom             VARCHAR(50)     NOT NULL,
    prenom          VARCHAR(50)     NOT NULL,
    dateNaissance   DATE            NOT NULL,
    numeroSecu      CHAR(13)        NOT NULL UNIQUE,
    poids           INT             NOT NULL,
    taille          INT             NOT NULL,
    PRIMARY KEY (numPatient)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table MEDECIN
-- -----------------------------------------------------
CREATE TABLE MEDECIN (
    numMedecin      INT             NOT NULL AUTO_INCREMENT,
    nom             VARCHAR(50)     NOT NULL,
    prenom          VARCHAR(50)     NOT NULL,
    dateNaissance   DATE            NOT NULL,
    numeroRPPS      CHAR(11)        NOT NULL UNIQUE,
    specialite      VARCHAR(100)    NOT NULL,
    motDePasse      VARCHAR(255)    NOT NULL,
    PRIMARY KEY (numMedecin)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table MEDICAMENT
-- -----------------------------------------------------
CREATE TABLE MEDICAMENT (
    codeMedicament  INT             NOT NULL AUTO_INCREMENT,
    nom             VARCHAR(100)    NOT NULL,
    dosage          VARCHAR(50)     NOT NULL,
    PRIMARY KEY (codeMedicament)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table ALLERGIE
-- -----------------------------------------------------
CREATE TABLE ALLERGIE (
    codeAllergie    INT             NOT NULL AUTO_INCREMENT,
    libelle         VARCHAR(100)    NOT NULL UNIQUE,
    PRIMARY KEY (codeAllergie)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table ORDONNANCE
-- Issue des associations PRESCRIRE et CONCERNER :
-- numMedecin et numPatient sont des clés étrangères
-- -----------------------------------------------------
CREATE TABLE ORDONNANCE (
    numOrdonnance   INT             NOT NULL AUTO_INCREMENT,
    dateEmission    DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP,
    numMedecin      INT             NOT NULL,
    numPatient      INT             NOT NULL,
    PRIMARY KEY (numOrdonnance),
    CONSTRAINT fk_ordonnance_medecin
        FOREIGN KEY (numMedecin) REFERENCES MEDECIN(numMedecin)
        ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT fk_ordonnance_patient
        FOREIGN KEY (numPatient) REFERENCES PATIENT(numPatient)
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table CONTENIR
-- Issue de l'association porteuse n,n entre
-- ORDONNANCE et MEDICAMENT.
-- Clé primaire composite : (numOrdonnance, codeMedicament)
-- -----------------------------------------------------
CREATE TABLE CONTENIR (
    numOrdonnance       INT                 NOT NULL,
    codeMedicament      INT                 NOT NULL,
    posologie           VARCHAR(255)        NOT NULL,
    dureeJours          SMALLINT UNSIGNED   NOT NULL,
    PRIMARY KEY (numOrdonnance, codeMedicament),
    CONSTRAINT fk_contenir_ordonnance
        FOREIGN KEY (numOrdonnance) REFERENCES ORDONNANCE(numOrdonnance)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT fk_contenir_medicament
        FOREIGN KEY (codeMedicament) REFERENCES MEDICAMENT(codeMedicament)
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- -----------------------------------------------------
-- Table ETRE_ALLERGIQUE
-- Issue de l'association n,n entre PATIENT et ALLERGIE.
-- Clé primaire composite : (numPatient, codeAllergie)
-- -----------------------------------------------------
CREATE TABLE ETRE_ALLERGIQUE (
    numPatient      INT             NOT NULL,
    codeAllergie    INT             NOT NULL,
    PRIMARY KEY (numPatient, codeAllergie),
    CONSTRAINT fk_allergique_patient
        FOREIGN KEY (numPatient) REFERENCES PATIENT(numPatient)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT fk_allergique_allergie
        FOREIGN KEY (codeAllergie) REFERENCES ALLERGIE(codeAllergie)
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- =====================================================
-- Jeu de test
-- =====================================================

INSERT INTO MEDECIN
    (nom, prenom, dateNaissance, numeroRPPS, specialite, motDePasse)
VALUES
    ('DURAND', 'Paul',   '1970-01-15', '10101010101', 'Généraliste', 'secret'),
    ('MARTIN', 'Claire', '1982-06-20', '20202020202', 'Cardiologue', 'secret');

INSERT INTO PATIENT
    (nom, prenom, dateNaissance, numeroSecu)
VALUES
    ('DUPONT', 'Marie', '1985-03-14', '2850314123456'),
    ('LEROY',  'Jean',  '1960-07-22', '1600722123456');

INSERT INTO MEDICAMENT (nom, dosage) VALUES
    ('Doliprane',    '500 mg'),
    ('Amoxicilline', '1 g'),
    ('Aspirine',     '500 mg');

INSERT INTO ALLERGIE (libelle) VALUES
    ('Pénicilline'),
    ('Aspirine'),
    ('Iode');

-- Une ordonnance prescrite par Dr Durand pour Marie Dupont
INSERT INTO ORDONNANCE (dateEmission, numMedecin, numPatient) VALUES
    ('2026-05-11 10:30:00', 1, 1);

-- Deux médicaments sur cette ordonnance
INSERT INTO CONTENIR
    (numOrdonnance, codeMedicament, posologie, dureeJours)
VALUES
    (1, 1, '1 comprimé 3 fois par jour', 5),
    (1, 2, '1 comprimé matin et soir',   7);

-- Marie est allergique à la pénicilline
INSERT INTO ETRE_ALLERGIQUE (numPatient, codeAllergie) VALUES
    (1, 1);


-- =====================================================
-- Quelques requêtes de vérification
-- =====================================================

-- Liste des ordonnances avec le médecin et le patient
SELECT  o.numOrdonnance,
        o.dateEmission,
        CONCAT('Dr ', m.nom)        AS medecin,
        CONCAT(p.prenom, ' ', p.nom) AS patient
FROM    ORDONNANCE o
JOIN    MEDECIN m ON m.numMedecin = o.numMedecin
JOIN    PATIENT p ON p.numPatient = o.numPatient;

-- Détail d'une ordonnance avec ses médicaments
SELECT  o.numOrdonnance,
        med.nom         AS medicament,
        med.dosage,
        c.posologie,
        c.dureeJours
FROM    ORDONNANCE o
JOIN    CONTENIR   c   ON c.numOrdonnance  = o.numOrdonnance
JOIN    MEDICAMENT med ON med.codeMedicament = c.codeMedicament
WHERE   o.numOrdonnance = 1;

-- Liste des allergies d'un patient
SELECT  a.libelle
FROM    ETRE_ALLERGIQUE ea
JOIN    ALLERGIE        a ON a.codeAllergie = ea.codeAllergie
WHERE   ea.numPatient = 1;
