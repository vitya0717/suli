DROP DATABASE IF EXISTS kreta;
CREATE DATABASE IF NOT EXISTS kreta
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
USE kreta;
CREATE TABLE osztaly(
    az INT,
    nev VARCHAR(30),
    PRIMARY KEY (az)
);
CREATE TABLE csapat(
    az INT,
    nev VARCHAR(30),
    PRIMARY KEY (az)
);
CREATE TABLE tanulo(
    az INT,
    osztalyaz INT,
    nev VARCHAR(30),
    csapat int,
    PRIMARY KEY (az),
    INDEX(osztalyaz),
    INDEX(csapat),
    FOREIGN key (csapat) REFERENCES csapat(az),
    FOREIGN key (osztalyaz) REFERENCES osztaly(az)
);
CREATE TABLE tantargyak(
    az INT,
    nev VARCHAR(30),
    PRIMARY KEY (az)
);
CREATE TABLE tanar(
    az INT,
    nev VARCHAR(30),
    PRIMARY KEY (az)
);
CREATE TABLE valami(
    tanar_id INT,
    tantargy_id INT,
    FOREIGN key (tanar_id) REFERENCES tanar(az),
    FOREIGN key (tantargy_id) REFERENCES tantargyak(az),
    INDEX(tanar_id),
    INDEX(tantargy_id)
);
CREATE TABLE ertekeles(
    tanulo_id INT,
    tantargy_id INT,
    tanar_id int,
    ertekeles int,
    FOREIGN key (tanulo_id) REFERENCES tanulo(az),
    FOREIGN key (tantargy_id) REFERENCES tantargyak(az),
    FOREIGN key (tanar_id) REFERENCES tanar(az),
    INDEX(tanulo_id),
    INDEX(tantargy_id),
    INDEX(tanar_id)
);
INSERT INTO csapat(az, nev) VALUES 
    (1, "SyntaxError");

/*	az	nev	*/
INSERT INTO osztaly(az, nev) VALUES (1, "13.D");

/*az	osztalyaz	nev	csapat(index)	*/
INSERT INTO tanulo(az, osztalyaz, nev, csapat) VALUES 
    (1, 1, "Kutasi Erzsébet", 1),
    (2, 1, "Kiss Gergő", 1),
    (3, 1, "Tóth Viktor", 1);

/*az	nev	*/
INSERT INTO tanar(az, nev) VALUES 
    (1, "Kerényi Róbert Nándor"),
    (2, "Németh Bence"),
    (3, "Csontos Dénes"),
    (4, "Németh József"),
    (5, "Deák Csaba");

/*	az	nev	*/
INSERT INTO tantargyak(az, nev) VALUES 
    (1, "Szakmai angol"),
    (2, "Osztályfőnöki"),
    (3, "Adatbázis-kezelés I."),
    (4, "Asztali alkalmazások fejlesztése"),
    (5, "IKT projektmunka I."),
    (6, "Informatikai és távközlési alapok I."),
    (7, "Informatikai és távközlési alapok II."),
    (8, "Programozási alapok"),
    (9, "Szoftvertesztelés"),
    (10, "Webprogramozás");

/*tanulo_id	tantargy_id	tanar_id ertekeles*/
INSERT INTO ertekeles(tanulo_id, tantargy_id, tanar_id, ertekeles) VALUES
    /*Angol jegyek*/
    (1, 1, 4, 5),
    (2, 1, 4, 5),
    (3, 1, 4, 5);
    /*Adatbázis I. jegyek*/
    (1, 3, 3, 5),
    (2, 3, 3, 5),
    (3, 3, 3, 5);