/*Update műveletek*/
/*1. UPDATE:*/
UPDATE `felhasznalo` SET `email`= 'gerimester100@gmail.com' WHERE felhasznev = "gerimester2009";
/*2. UPDATE:*/
UPDATE `felhasznalo` SET `felhasznev`= 'DagiMitter' WHERE felhasznev = "yummmiiiOTP";
/*3. UPDATE:*/
UPDATE `beszallito` SET `beszallito_telszam`= '+3656498776' WHERE bolt_azon = 2;


/*Törlés műveletek*/
/*1. DELETE*/
DELETE FROM `beszallito` WHERE bolt_azon = (SELECT bolt_azon FROM `bolt` WHERE bolt_neve = "Ipon");
DELETE FROM `bolt` WHERE bolt_neve = "Ipon";
/*2. DELETE*/
DELETE FROM `rendeles` WHERE felhasznalo_azon = 3;
DELETE FROM `felhasznalo` WHERE felhasz_azon = 3;
/*3. DELETE*/
DELETE FROM `termek` WHERE termek_azon = 5;