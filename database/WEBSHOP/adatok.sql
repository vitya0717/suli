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
    varos_azon INT AUTO_INCREMENT,
    iranyito_szam INT,
    varos_neve VARCHAR(64),
    PRIMARY KEY(varos_azon)
);

CREATE TABLE utca(
    utca_azon INT AUTO_INCREMENT,
    utca_neve VARCHAR(64),
    hazszam INT,
    PRIMARY KEY(utca_azon)
);

CREATE TABLE felhasznalo(
    felhasz_azon INT AUTO_INCREMENT,
    varos_azon INT,
    utca_azon INT,
    felhasznev VARCHAR(64),
    jelszo VARCHAR(128),
    email VARCHAR(64),
    INDEX(felhasz_azon),
    INDEX(varos_azon),
    INDEX(utca_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(varos_azon),
    FOREIGN KEY(utca_azon) REFERENCES utca(utca_azon)
);

CREATE TABLE beszallito(
    beszallito_azon INT AUTO_INCREMENT,
    varos_azon INT,
    utca_azon INT,
    beszallito_telszam VARCHAR(64),
    INDEX(beszallito_azon),
    INDEX(varos_azon),
    INDEX(utca_azon),
    FOREIGN KEY(varos_azon) REFERENCES varos(varos_azon),
    FOREIGN KEY(utca_azon) REFERENCES utca(utca_azon)
);

CREATE TABLE raktar(
    raktar_azon INT AUTO_INCREMENT,
    termek_mennyiseg INT,
    INDEX(raktar_azon)
);

CREATE TABLE termek(
    termek_azon INT AUTO_INCREMENT,
    raktar_azon INT,
    termek_neve VARCHAR(64),
    termek_ara INT,
    INDEX(termek_azon),
    INDEX(raktar_azon),
    FOREIGN KEY(raktar_azon) REFERENCES raktar(raktar_azon)
);

CREATE TABLE rendeles(
    rendeles_azon INT AUTO_INCREMENT,
    termek_azon INT,
    beszallito_azon INT,
    felhasznalo_azon INT,
    rendeles_datuma DATE,
    fizetendo_osszeg INT,
    INDEX(termek_azon),
    INDEX(beszallito_azon),
    INDEX(felhasznalo_azon),
    PRIMARY KEY(rendeles_azon),
    FOREIGN KEY(termek_azon) REFERENCES termek(termek_azon),
    FOREIGN KEY(beszallito_azon) REFERENCES beszallito(beszallito_azon),
    FOREIGN KEY(felhasznalo_azon) REFERENCES felhasznalo(felhasz_azon)
);
INSERT INTO varos(varos_azon, iranyito_szam, varos_neve) VALUES 
(1, "3500", "Miskolc"),
(2, "1011", "Budapest"),
(3, "2640", "Nógrád");

INSERT INTO utca(utca_azon, utca_neve, hazszam) VALUES 
(1,"Kis Pista", 43),
(2, "Fiastyúk", 243),
(3, "Terhes utca", 65);

INSERT INTO felhasznalo(felhasz_azon, varos_azon, utca_azon, felhasznev, jelszo, email) VALUES 
(1, 2, 2, "gerimester2009", "Alma12345X", "gerimester200@gmail.com"),
(1, 1, 2, "yummmiiiOTP", "Jelszo", "lazlo.mail@freemail.com"),
(1, 2, 2, "ZsalmaLeves", "Naananaaa23", "zalma.lev10@citromail.com");
