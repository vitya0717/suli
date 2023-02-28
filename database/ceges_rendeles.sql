DROP DATABASE IF EXISTS ceges_rendeles;
CREATE DATABASE ceges_rendeles;
USE ceges_rendeles;
CREATE TABLE cegek(
	nev VARCHAR(64),
	telepules VARCHAR(64),
	ceg_kod VARCHAR(64) PRIMARY KEY
 );

CREATE TABLE termekek(
	nev VARCHAR(64),
	egysegar int,
	egyseg VARCHAR(64),
	termek_kod VARCHAR(64) PRIMARY KEY
 );

CREATE TABLE rendelesek(
	az INT,
	termek_kod VARCHAR(64),
	ceg_kod VARCHAR(64),
	datum DATE,
	ar INT ,
	mennyiseg INT, 
	PRIMARY KEY (az),
	FOREIGN KEY (termek_kod) REFERENCES termekek (termek_kod),
	FOREIGN KEY (ceg_kod) REFERENCES cegek (ceg_kod)
);

INSERT INTO cegek(ceg_kod, nev, telepules) VALUES (23256, "Szöszi KFT", "LYUKÓ"),(847568, "Yaaaakuza", "Szalonna"), (438756, "Sinter ZRT", "ÓZD");
INSERT INTO termekek(termek_kod, nev, egysegar, egyseg) VALUES (2325, "Kecskebábú", 43555, 20),(2525, "Macskabábú", 43555, 10), (2725, "Kutaybábú", 435535, 120);
INSERT INTO rendelesek(az, termek_kod, ceg_kod,datum,ar,mennyiseg) VALUES (1,2325,3233,'2019-05-06',5000,20), (2,2525,32233,'2018-05-06',6000,10), (3,2725,3293,'2016-05-06',7000,50);