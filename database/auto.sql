DROP DATABASE IF EXISTS autoszerviz;
CREATE DATABASE autoszerviz;
USE autoszerviz;
CREATE TABLE auto(
	rendszam VARCHAR(64) PRIMARY KEY,
	alvazszam VARCHAR(64),
	hiba VARCHAR(64),
	evjarat INT
);
CREATE TABLE tulajdonos(
	tulaj_id VARCHAR(64) PRIMARY KEY,
	neve VARCHAR(64),
	cime VARCHAR(64),
	telszam VARCHAR(64)
);
CREATE TABLE szervizeles(
	sorszam INT PRIMARY KEY,
	auto_id VARCHAR(64),
	tulaj_id VARCHAR(64),
	datum DATE,
	teljes_ar INT,
	FOREIGN KEY (auto_id) REFERENCES auto (rendszam),
	FOREIGN KEY (tulaj_id) REFERENCES tulajdonos (tulaj_id)
 );
 