/*Az adatbázis a következő táblákat tartalmazza:
kozetek (id, nev)
id egész szám, a kőzet azonosítója, elsődleges kulcs
nev szöveges, a kőzet elnevezése

torpek (id, nev, klan, nem, suly, magassag)
id egész szám, a törpe azonosítója, elsődleges kulcs
nev szöveges, a törpe neve
klan szöveges, a törpe klánjának neve
nem szöveges, a törpe neme
suly szám, a törpe súlya
magassag szám, a törpe testmagassága

tarnak (id, nev, kozet_id)
id egész szám, elsődleges kulcs
nev szöveges, a tárna neve
kozet_id egész szám, a tárnában bányászott kőzet azonosítója, idegenkulcs


kihol (torpe_id, tarna_id, kitermelt_mennyiseg)
torpe_id egész szám, a tárnában dolgozó törpe azonosítója,
elsődleges és idegenkulcs
tarna_id egész szám, a tárna azonosítója, elsődleges és idegenkulcs
kitermelt_mennyiseg egész szám, a törpe által adott tárnában kitermelt kőzetmennyiség*/
DROP DATABASE IF EXISTS TorpeTarna;
CREATE DATABASE TorpeTarna COLLATE "utf8_hungarian_ci" CHARACTER SET UTF8;
USE TorpeTarna;

CREATE TABLE kozetek(
	id int,
	nev varchar(64),
	PRIMARY KEY(id)
);

CREATE TABLE torpek(
	id int,
	nev varchar(64),
	klan VARCHAR(64),
	nem VARCHAR(10),
	suly int,
	magassag int,
	PRIMARY KEY(id)
);

CREATE TABLE tarnak(
	id int,
	nev varchar(64),
	kozet_id int,
	PRIMARY KEY(id),
	FOREIGN KEY(kozet_id) REFERENCES kozetek(id)
);

CREATE TABLE kihol(
	torpe_id int,
	tarna_id int,
	kitermelt_mennyiseg int,
	FOREIGN key (torpe_id) REFERENCES torpek(id),
	FOREIGN key (tarna_id) REFERENCES tarnak(id)
);

ALTER TABLE `kihol` ADD INDEX(`torpe_id`);
ALTER TABLE `kihol` ADD INDEX(`tarna_id`);