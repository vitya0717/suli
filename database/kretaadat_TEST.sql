DROP DATABASE IF EXISTS kreta;
CREATE DATABASE IF NOT EXISTS kreta
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
USE kreta;
CREATE TABLE osztaly(
    osztaly_id INT,
    nev VARCHAR(30),
    PRIMARY KEY (osztaly_id)
);
CREATE TABLE tanulo(
    tanulo_id INT,
    osztaly_id INT,
    nev text,
    PRIMARY KEY (tanulo_id),
    INDEX(osztaly_id),
    FOREIGN key (osztaly_id) REFERENCES osztaly(osztaly_id)
);
CREATE TABLE tantargyak(
    tantargy_id INT,
    nev text,
    PRIMARY KEY (tantargy_id)
);
CREATE TABLE tanar(
    tanar_id INT,
    nev text,
    PRIMARY KEY (tanar_id)
);

CREATE TABLE dtipus(
    tipus_id int,
    tipus text,
    PRIMARY key (tipus_id)
);

CREATE TABLE dolgozat(
    dolgozat_id int,
    tema text,  
    mod_id int,
    suly FLOAT,
    PRIMARY KEY(dolgozat_id),
    FOREIGN key (mod_id) REFERENCES dtipus(tipus_id),
    index(mod_id)
);

CREATE TABLE ertekeles(
    tanulo_id INT,
    tantargy_id INT,
    tanar_id int,
    dolgozat INT,
    ertekeles int,
    datum date,
    megjegyzes text,
    FOREIGN key (tanulo_id) REFERENCES tanulo(tanulo_id),
    FOREIGN key (tantargy_id) REFERENCES tantargyak(tantargy_id),
    FOREIGN key (tanar_id) REFERENCES tanar(tanar_id),
    FOREIGN key (dolgozat) REFERENCES dolgozat(dolgozat_id),
    INDEX(tanulo_id),
    INDEX(tantargy_id),
    INDEX(tanar_id),
    INDEX(dolgozat)
);

INSERT INTO dtipus(tipus_id, tipus) VALUES 
    (1, "E-learning feladat"),
    (2, "Beszámoló"),
    (3, "Órai munka"),
    (4, "Szorgalmi feladat"),
    (5, "Szóbeli felelet"),
    (6, "Beadandó feladat");

/*	az	nev	*/
INSERT INTO osztaly(osztaly_id, nev) VALUES 
    (1, "13.D");

/*az	osztalyaz	nev	csapat(index)	*/
INSERT INTO tanulo(tanulo_id, osztaly_id, nev) VALUES 
    (1, 1, "Kutasi Erzsébet"),
    (2, 1, "Kiss Gergő"),
    (3, 1, "Tóth Viktor");

/*az	nev	*/
INSERT INTO tanar(tanar_id, nev) VALUES 
    (1, "Kerényi Róbert Nándor"),
    (2, "Németh Bence"),
    (3, "Csontos Dénes"),
    (4, "Németh József"),
    (5, "Deák Csaba"),
    (6, "Takács István"),
    (7, "Sike László"),
    (8, "Fülöp Tibor"),
    (9, "Juhász Sándor Lászlóné"),
    (10,"Barnáné Szilágyi Judit"),
    (11,"Négyesi Gábor");


/*	az	nev	*/
INSERT INTO tantargyak(tantargy_id, nev) VALUES 
    (1, "Szakmai angol"),
    (2, "Osztályfőnöki"),
    (3, "Adatbázis-kezelés I."),
    (4, "Asztali alkalmazások fejlesztése"),
    (5, "IKT projektmunka I."),
    (6, "Informatikai és távközlési alapok I."),
    (7, "Informatikai és távközlési alapok II."),
    (8, "Programozási alapok"),
    (9, "Szoftvertesztelés"),
    (10, "Webprogramozás"),
    (11, "Munkavállalói ismeretek");

/*mod_id INT,
    tema text,
    ertekeles int,
    datum date,
    PRIMARY KEY(mod_id)*/

/*tanulo_id	tantargy_id	tanar_id ertekeles

INSERT INTO ertekeles(tanulo_id, tantargy_id, tanar_id, dolgozat,ertekeles,datum) VALUES
    (2, 1, 10, 1, 5,  "2023-03-03");*/