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


/*Táblák: beszállító, termék, felhasznalo, rendelés, raktár*/
CREATE TABLE varos(
    iranyito_szam INT,
    varos_neve VARCHAR(64),
    PRIMARY KEY(iranyito_szam)
);

CREATE TABLE utca(
    utca_azon INT AUTO_INCREMENT,
    utca_neve VARCHAR(64),
    PRIMARY KEY(utca_azon)
);

CREATE TABLE bolt(
    bolt_azon INT AUTO_INCREMENT,
    bolt_neve VARCHAR(64),
    PRIMARY KEY(bolt_azon)
);

CREATE TABLE felhasznalo(
    felhasz_azon INT AUTO_INCREMENT,
    varos_azon INT,
    utca_azon INT,
    hazszam INT,
    felhasznev VARCHAR(64),
    jelszo VARCHAR(128),
    email VARCHAR(64),
    PRIMARY KEY(felhasz_azon),
    INDEX(varos_azon),
    INDEX(utca_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(iranyito_szam),
    FOREIGN KEY(utca_azon) REFERENCES utca(utca_azon)
);

CREATE TABLE beszallito(
    bolt_azon INT,
    varos_azon INT,
    utca_azon INT,
    beszallito_telszam VARCHAR(64),
    INDEX(varos_azon),
    INDEX(utca_azon),
    INDEX(bolt_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(iranyito_szam),
    FOREIGN KEY(utca_azon) REFERENCES utca(utca_azon),
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
INSERT INTO varos(iranyito_szam, varos_neve) VALUES 
    (3500, "Miskolc"),
    (1011, "Budapest"),
    (2640, "Nógrád");

INSERT INTO utca(utca_azon, utca_neve) VALUES 
    (1, "Kis Pista"),
    (2, "Móra Ferenc"),
    (3, "Kelepes utca");

INSERT INTO bolt(bolt_azon, bolt_neve) VALUES 
    (1, "Media Markt"),
    (2, "Euronics"),
    (3, "Emag"),
    (4, "Ipon"),
    (5, "PCX");

INSERT INTO felhasznalo(felhasz_azon, varos_azon, utca_azon, hazszam, felhasznev, jelszo, email) VALUES 
    (1, 3500, 1, 43, "gerimester2009", SHA2("Alma12345X", 256), "gerimester200@gmail.com"),
    (2, 1011, 2, 34, "yummmiiiOTP", SHA2("Jelszo", 256), "lazlo.mail@freemail.com"),
    (3, 2640, 3, 21, "KolomposRikardo", SHA2("Naananaaa23", 256), "zalma.lev10@citromail.com");

INSERT INTO beszallito(bolt_azon, varos_azon, utca_azon, beszallito_telszam) VALUES 
    (1, 1011, 3, "1(81)732-99-69"),
    (5, 3500, 2, "18(907)185-01-03"),
    (4, 2640, 1, "70(693)288-79-87");

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