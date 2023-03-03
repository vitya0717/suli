DROP DATABASE IF EXISTS Kreta;
CREATE DATABASE Kreta COLLATE "utf8_hungarian_ci" CHARACTER SET UTF8;
USE Kreta;

CREATE TABLE tanulo(
	id int PRIMARY KEY,
	nev VARCHAR(30)
);

CREATE TABLE tantargy(
	id int PRIMARY KEY,
	tanar_id int,
	neve VARCHAR(64)
);

CREATE TABLE tanar(
	id int PRIMARY KEY,
	tantargy_id int,
	neve VARCHAR(32)
);

CREATE TABLE ertekeles(
	tantargy_id int,
	tanulo_id int,
	tanar_id int,
	tema VARCHAR(254)
);

