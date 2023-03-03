DROP DATABASE IF EXISTS sportcentrum;
CREATE DATABASE sportcentrum COLLATE "utf8_hungarian_ci" CHARACTER SET UTF8;
USE sportcentrum;

CREATE TABLE ugyfelek(
    az INT,
    nev VARCHAR(30),
    email VARCHAR(30),
    PRIMARY KEY (az)
);

CREATE TABLE tevekenysegek(
    az INT,
    nev VARCHAR(30),
    ar double,
    PRIMARY KEY (az)
);

create table szolgaltatasok(
    az INT,
    datum DATE,
    ugyfelAz int,
    tevAz int,
    PRIMARY key (az),
    FOREIGN key (ugyfelAz) REFERENCES ugyfelek(az),
    FOREIGN key (tevAz) REFERENCES tevekenysegek(az)
);



INSERT INTO ugyfelek (az, nev,email) VALUES 
(1,'Nagy Gergő','xd@gmail.yeet'), 
(2,'Gibsz Jakab','a@gmail.yeet'), 
(3,'Cement János','lol@gmail.yeet');

INSERT INTO tevekenysegek (az,nev,ar) VALUES
(1,'foci',1000),
(2,'másik foci',1200),
(3,'golf',1850);

INSERT INTO szolgaltatasok (az,datum,ugyfelAz,tevAz) VALUES
(1,'2023-01-11',1,1),
(2,'2023-02-11',1,3),
(3,'2023-02-22',2,2);