A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE maratonvalto CHARACTER SET UTF8 COLLATE UTF8_hungarian_ci;

3. feladat:
INSERT INTO `eredmenyek`(`futo`, `kor`, `ido`) VALUES (1044,4,15765);

4. feladat:
SELECT fnev as "futo", szulev FROM `futok` WHERE ffi = 0 ORDER BY futo;

5. feladat:
SELECT fnev as "futo", 2016-szulev as "kor" FROM `futok` WHERE 2016-szulev >= 42 ORDER BY kor DESC, szulho;

6. feladat:
SELECT fnev as "futo" FROM `futok` INNER JOIN eredmenyek ON eredmenyek.futo = futok.fid WHERE futok.ffi = 1 ORDER BY eredmenyek.ido LIMIT 10;

7. feladat:
SELECT csapat as "csapat", SUM(eredmenyek.ido) as "csapatido" FROM `futok` INNER JOIN eredmenyek ON eredmenyek.futo = futok.fid GROUP BY csapat ORDER BY csapatido ASC;
