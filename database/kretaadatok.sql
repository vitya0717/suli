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
    (6, "Beadandó feladat"),
    (7, "Teszt feladat"),
    (8, "Írásbeli röpdolgozat"),
    (9, "Projektmunka"),
    (10, "Házi dolgozat"),
    (11, "Gyakorlati feladat"),
    (12, "Írásbeli témazáró dolgozat"),
    (13, "Csoportmunka");

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

INSERT INTO `dolgozat` (`dolgozat_id`, `tema`, `mod_id`, `suly`) VALUES 
    ('1', NULL, '6', '100'),
    ('2', 'Házi feladatok', '6', '100'),
    ('3', 'Vocabulary', '1', '100'),
    ('4', 'TK 15.o. 3. Definitions', '5', '100'),
    ('5', 'Wordwall nyelvtani feladatok', '4', '100'),
    ('6', 'Computing quiz', '1', '100'),
    ('7', 'Reading and translating', '3', '100'),
    ('8', 'Networking', '2', '100'),
    ('9', 'Vocabulary', '1', '100');

INSERT INTO ertekeles(tanulo_id, tantargy_id, tanar_id, dolgozat, ertekeles,datum) VALUES
    (3, 1, 10, 9, 5, "2023-01-18"),
    (3, 1, 10, 8, 5, "2023-01-18"),
    (3, 1, 10, 7, 5, "2022-12-09"),
    (3, 1, 10, 6, 5, "2022-11-18"),
    (3, 1, 10, 5, 5, "2022-11-04"),
    (3, 1, 10, 4, 5, "2022-11-04"),
    (3, 1, 10, 3, 5, "2022-10-28"),
    (3, 1, 10, 2, 5, "2022-10-28"),
    (3, 1, 10, 1, 5, "2022-09-26");