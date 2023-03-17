/*4. Tervezze meg egy internetes áruház adatbázisát! Az adatbázisban nyilvántartjuk
• a regisztrált felhasználókat
• a beszállítók adatait
• a forgalmazott termékek adatait
• a raktári készletet
• a vásárlások adatait*/

/*
felhasznalo_tabla: felhasznalo(felhasznalo_azon, varos_azon, felhasznev, jelszo, email)
utca_tabla: utca(utca_azon, varos_azon, utca_neve)
varos_tabla: varos(varos_azon, iranyito_szam)
beszallito_tabla: beszallito(beszallito_azon, varos_azon, utca_azon, hazszam, beszallito_telszam)
termek_tabla: felhasznalo(termek_azon, termek_neve, termek_ara)
raktar_tabla: raktar(raktar_azon, termek_azon, termek_mennyiseg); 
rendeles_tabla: rendeles(rendeles_azon, termek_azon, beszallito_azon, felhasznalo_azon, rendeles_datuma, fizetendo_osszeg)
*/

DROP DATABASE IF EXISTS webshop;
CREATE DATABASE IF NOT EXISTS webshop
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
USE webshop;


/*Táblák: varos, bolt, felhasznalo, beszallito, termek, rendeles*/
CREATE TABLE varos(
    varos_azon INT,
    iranyitoszam INT,
    varos_neve VARCHAR(64),
    utca_neve VARCHAR(64),
    hazszam INT,
    PRIMARY KEY(varos_azon)
);

CREATE TABLE bolt(
    bolt_azon INT AUTO_INCREMENT,
    bolt_neve VARCHAR(64),
    PRIMARY KEY(bolt_azon)
);

CREATE TABLE felhasznalo(
    felhasz_azon INT AUTO_INCREMENT,
    varos_azon INT,
    felhasznev VARCHAR(64),
    jelszo VARCHAR(128),
    email VARCHAR(64),
    PRIMARY KEY(felhasz_azon),
    INDEX(varos_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(varos_azon)
);

CREATE TABLE beszallito(
    bolt_azon INT,
    varos_azon INT,
    beszallito_telszam VARCHAR(64),
    INDEX(varos_azon),
    INDEX(bolt_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(varos_azon),
    FOREIGN KEY(bolt_azon) REFERENCES bolt(bolt_azon)
);

CREATE TABLE termek(
    termek_azon INT AUTO_INCREMENT,
    termek_neve VARCHAR(64),
    termek_ara INT,
    raktar_elerhetoseg BOOLEAN,
    raktar_termek_mennyiseg INT,
    INDEX(termek_azon)
);

CREATE TABLE rendeles(
    rendeles_azon INT AUTO_INCREMENT,
    bolt_azon INT,
    termek_azon INT,
    felhasznalo_azon INT,
    rendeles_datuma DATE,
    fizetendo_osszeg INT,
    INDEX(termek_azon),
    INDEX(felhasznalo_azon),
    INDEX(bolt_azon),
    PRIMARY KEY(rendeles_azon),
    FOREIGN KEY(termek_azon) REFERENCES termek(termek_azon),
    FOREIGN KEY(bolt_azon) REFERENCES bolt(bolt_azon),
    FOREIGN KEY(felhasznalo_azon) REFERENCES felhasznalo(felhasz_azon)
);
INSERT INTO varos(varos_azon, iranyitoszam, varos_neve, utca_neve, hazszam) VALUES 
    (1, 3500, "Miskolc", "Kis Pista", 34),
    (2, 3500, "Miskolc", "Kis NemPista", 52),
    (3, 1011, "Budapest", "Móra Ferenc", 54),
    (4, 2640, "Nógrád", "Kelepes utca", 24),
    (5, 9786, "Ózd", "Rézműves utca", 35),
    (6, 9786, "Ózd", "Rézműves utca", 36),
    (7, 5432, "Mezőcsát", "Temető út", 56),
    (8, 7685, "Eger", "Vár utca", 27),
    (9, 1011, "Budapest", "Móra Ferenc", 58);

INSERT INTO bolt(bolt_azon, bolt_neve) VALUES 
    (1, "Media Markt"),
    (2, "Euronics"),
    (3, "Emag"),
    (4, "Ipon"),
    (5, "PCX");

INSERT INTO felhasznalo(felhasz_azon, varos_azon, felhasznev, jelszo, email) VALUES 
    (1, 1, "gerimester2009", SHA2("Alma12345X", 256), "gerimester200@gmail.com"),
    (2, 4, "yummmiiiOTP", SHA2("Jelszo", 256), "lazlo.mail@freemail.com"),
    (3, 5, "KolomposRikardo", SHA2("Naananaaa23", 256), "zalma.lev10@citromail.com");

INSERT INTO beszallito(bolt_azon, varos_azon, beszallito_telszam) VALUES 
    (1, 9, "1(81)732-99-69"),
    (2, 2, "18(907)185-01-03"),
    (3, 3, "99(93)278-79-70"),
    (4, 3, "43(743)238-70-87"),
    (5, 3, "23(63)222-66-80");

INSERT INTO termek(termek_azon, termek_neve, termek_ara, raktar_elerhetoseg, raktar_termek_mennyiseg) VALUES
    (1, "Samsung Galaxy S21 Ultra", 399000, true, 50),
    (2, "Apple MacBook Air (2021)", 599000, true, 12),
    (3, "Asus ROG 64GB, 5TB SDD", 9000000, true, 1),
    (4, "Samsung TV", 50000, false, 0),
    (5, "Levono IDEJAPAD", 250000, true, 25);

INSERT INTO rendeles(rendeles_azon, termek_azon, bolt_azon, felhasznalo_azon, rendeles_datuma, fizetendo_osszeg) VALUES 
    (1, 4, 2, 3, "2023-03-12", 50000),
    (2, 1, 3, 2, "2023-03-12", 250000),
    (3, 3, 5, 1, "2023-01-24", 9000000);

/*Update műveletek*/
/*1. UPDATE:*/
UPDATE `felhasznalo` SET `email`= 'gerimester100@gmail.com' WHERE felhasznev = "gerimester2009";
/*2. UPDATE:*/
UPDATE `felhasznalo` SET `felhasznev`= 'DagiMitter' WHERE felhasznev = "yummmiiiOTP";
/*3. UPDATE:*/
UPDATE `beszallito` SET `beszallito_telszam`= '+3656498776' WHERE bolt_azon = 2;


/*Törlés műveletek*/
/*1. DELETE*/
DELETE FROM `beszallito` WHERE bolt_azon = (SELECT bolt_azon FROM `bolt` WHERE bolt_neve = "Ipon");
DELETE FROM `bolt` WHERE bolt_neve = "Ipon";
/*2. DELETE*/
DELETE FROM `rendeles` WHERE felhasznalo_azon = 3;
DELETE FROM `felhasznalo` WHERE felhasz_azon = 3;
/*3. DELETE*/
DELETE FROM `termek` WHERE termek_azon = 5;