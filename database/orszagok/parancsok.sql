/*15. Hány 100 km2-nél kisebb területű ország van?*/
SELECT COUNT(*) FROM orszagok WHERE terulet < 100;
/*16. Hány 20.000 főnél kevesebb lakosú ország van?*/
SELECT COUNT(*) FROM orszagok WHERE (nepesseg*1000) < 20000;
/*17. Hány országra igaz, hogy területe kisebb 100 km2-nél, vagy pedig a lakossága kevesebb 20.000 főnél?*/
SELECT COUNT(*) FROM orszagok WHERE terulet < 100 OR (nepesseg*1000) < 20000;
/*18. Hány ország területe 50.000 és 150.000 km2 közötti?*/
SELECT COUNT(*) FROM orszagok WHERE terulet >= 50000 AND terulet <= 150000;
/*19. Hány ország lakossága 8 és 12 millió közötti?*/
SELECT COUNT(*) FROM orszagok WHERE nepesseg*1000 >= 8000000 AND (nepesseg*1000) <= 12000000;
/*20. Mely fővárosok népesebbek 20 millió főnél?*/
SELECT capital FROM orszagok WHERE (nep_fovaros*1000) > 20000000;
/*21. Mely országok népsűrűsége nagyobb 500 fő/km2-nél?*/
SELECT orszag, (SELECT SUM(nepesseg*1000) / SUM(terulet)) AS Nepsuruseg FROM orszagok WHERE (SELECT SUM(nepesseg*1000) / SUM(terulet)) > 500;
/*22. Hány ország államformája köztársaság?*/
SELECT COUNT(*) FROM orszagok WHERE allamforma  LIKE "%köztársaság%";
/*23. Mely országok pénzneme a kelet-karib dollár?*/
SELECT COUNT(*) FROM orszagok WHERE penznem = "kelet-karib dollár";
/*24. Hány ország nevében van benne az &quot;ORSZÁG&quot; szó?*/
SELECT count(*) FROM orszagok WHERE orszag LIKE "%ORSZÁG%";
/*25. Mely országokban korona a hivatalos fizetőeszköz?*/
SELECT orszag FROM orszagok WHERE allamforma LIKE "%Korona%";
/*26. Mennyi Európa területe?*/
SELECT SUM(terulet) FROM orszagok WHERE foldr_hely LIKE "%Európa%";
/*27. Mennyi Európa lakossága?*/
SELECT SUM(nepesseg*1000) FROM orszagok WHERE foldr_hely LIKE "%Európa%";
/*28. Mennyi Európa népsűrűsége?*/
SELECT (SUM(nepesseg*1000)/ SUM(terulet)) AS "Európa népsűrűség" FROM orszagok WHERE foldr_hely LIKE "%Európa%";
/*29. Hány ország van Afrikában?*/
SELECT COUNT(*) FROM orszagok WHERE foldr_hely LIKE "%Afrika%";
/*30. Mennyi Afrika lakossága?*/
SELECT SUM((nepesseg * 1000)) AS "Afrika lakossága" FROM orszagok WHERE foldr_hely LIKE "%Afrika%";