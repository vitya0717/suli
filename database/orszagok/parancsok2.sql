/*31. Mennyi Afrika népsűrűsége?*/
SELECT sum(nepesseg)*1000/ sum(terulet) as `Népsűrűség afrikában` FROM `orszagok` WHERE foldr_hely LIKE "%Afrika%";

/*32. Melyek a szigetországok?*/
SELECT orszag FROM `orszagok` WHERE orszag LIKE "%Sziget%";

/*33. Mely országok államformája hercegség, vagy királyság?*/ 
SELECT orszag FROM `orszagok` WHERE allamforma LIKE "%hercegség%" OR allamforma LIKE "%királyság%";  

/*34. Hány országnak nincs autójelzése?*/
SELECT COUNT(*) AS "Autójelzés nélküli országok" FROM `orszagok` WHERE autojel = null OR autojel = "";

/*35. Mennyi a váltószáma az aprópénznek azokban az országokban, ahol nem 100?*/
SELECT DISTINCT valtopenz FROM `orszagok` WHERE valtopenz != 100;

/*36. Hány ország területe kisebb Magyarországénál?*/
SELECT COUNT(*) AS "Magyarországnál kisebb területű országok száma" FROM `orszagok` WHERE terulet < (SELECT terulet FROM orszagok WHERE orszag = "Magyarország");

/*37. Melyik a legnagyobb területű ország, és mennyi a területe?*/
SELECT MAX(terulet) AS maxtelep, orszag  FROM `orszagok` WHERE terulet = (SELECT MAX(terulet) FROM orszagok);

/*38. Melyik a legkisebb területű ország, és mennyi a területe?*/
SELECT MIN(terulet) AS mintelep, orszag  FROM `orszagok` WHERE terulet = (SELECT MIN(terulet) FROM orszagok);

/*39. Melyik a legnépesebb ország, és hány lakosa van?*/
SELECT MAX(nepesseg) AS maxnep, orszag  FROM `orszagok` WHERE nepesseg = (SELECT MAX(nepesseg) FROM orszagok);

/*40. Melyik a legkisebb népességű ország, és hány lakosa van?*/
SELECT MIN(nepesseg) AS minnep, orszag  FROM `orszagok` WHERE nepesseg = (SELECT MIN(nepesseg) FROM orszagok);

/*41. Melyik a legsűrűbben lakott ország, és mennyi a népsűrűsége?*/
SELECT nepesseg*1000/terulet AS maxnepsuruseg, orszag  FROM `orszagok` ORDER BY `maxnepsuruseg` DESC LIMIT 1;

/*42. Melyik a legritkábban lakott ország, és mennyi a népsűrűsége?*/
SELECT nepesseg*1000/terulet AS minnepsuruseg, orszag  FROM `orszagok` ORDER BY `minnepsuruseg` ASC LIMIT 1;

/*43. Melyik a legnagyobb afrikai ország és mekkora?*/
SELECT terulet AS maxafrika, orszag  FROM `orszagok` WHERE orszag LIKE "%Afrika%" ORDER BY `maxafrika` DESC LIMIT 1;

/*44. Melyik a legkisebb amerikai ország és hányan lakják?*/
SELECT terulet AS minafrika, orszag  FROM `orszagok` WHERE orszag LIKE "%Afrika%" ORDER BY `minafrika` ASC LIMIT 1;

/*45. Melyik az első három legsűrűbben lakott "országméretű" ország (tehát nem város- vagy törpeállam)?*/
SELECT nepesseg AS megsurubben, orszag  FROM `orszagok` ORDER BY `megsurubben` DESC LIMIT 3;

/*46. Melyik a világ hat legnépesebb fővárosa?*/
SELECT nep_fovaros, fovaros FROM `orszagok` ORDER BY nep_fovaros DESC LIMIT 6;

/*47. Melyik tíz ország egy főre jutó GDP-je a legnagyobb?*/
SELECT gdp FROM orszagok order by gdp desc limit 10;
/*48. Melyik tíz ország össz-GDP-je a legnagyobb?*/
SELECT gdp*(nepesseg*1000) as "osszgdp" FROM orszagok order by osszgdp desc limit 10;
/*49. Melyik országban a legszegényebbek az emberek?*/
SELECT orszag FROM orszagok order by gdp asc limit 1;
/*50. Melyik a 40. legkisebb területű ország?*/
select orszag from orszagok order by terulet limit 1 offset 39 ;
/*51. Melyik a 15. legkisebb népsűrűségű ország?*/
select orszag from orszagok order by (nepesseg*1000)/terulet limit 1 offset 14 ;
/*52. Melyik a 61. legnagyobb népsűrűségű ország?*/
select orszag from orszagok order by (nepesseg*1000)/terulet desc limit 1 offset 60 ;

/*53. Melyik három ország területe hasonlít leginkább Magyaroszág méretéhez?*/
SELECT ABS(terulet-(SELECT terulet FROM orszagok WHERE orszag = "Magyarország")), orszag FROM `orszagok`
WHERE orszag != "Magyarország"
ORDER BY `ABS(terulet-(SELECT terulet FROM orszagok WHERE orszag = "Magyarország"))` ASC LIMIT 3;

/*54. Az emberek hányadrésze él Ázsiában?*/
select
(select sum(nepesseg*1000) from orszagok where foldr_hely like "%Ázsia%") as "AzsiaN",
(select sum(nepesseg*1000) from orszagok) as "OsszN",
(select AzsiaN/OsszN*100) as "AzsiaSzazalek";
/*55. A szárazföldek mekkora hányadát foglalja el Oroszország?*/
select
(select terulet from orszagok where orszag like "%Oroszország%") as "OroszT",
(select sum(terulet) from orszagok) as "ÖsszT",
(select OroszT/ÖsszT*100 ) as "OroszTeruletSzazalek";
/*56. Az emberek hány százaléka fizet euroval?*/
select
(select sum(nepesseg*1000) from orszagok where penznem="euró") as "EUR",
(select sum(nepesseg*1000)/EUR) as "eur";
/*57. Hányszorosa a leggazdagabb ország egy főre jutó GDP-je a legszegényebb ország egy*/
/*főre jutó GDP-jének?*/
select
(select max(gdp) from orszagok) /
(select gdp from orszagok order by gdp asc limit 1 offset 1)
as "gdpszorzat";
/*58. A világ össz-GDP-jének hány százalékát adja az USA?*/
select
(select sum(gdp) from orszagok) as "allx",
(select gdp from orszagok where country like "%USA%") as "USAGDP",
(select USAGDP/allx*100 ) as "USAGDPfromall";
/*59. A világ össz-GDP-jének hány százalékát adja az euroövezet?*/
select
(select sum(gdp) from orszagok) as "allGDP",
(select sum(gdp) from orszagok where penznem="euró") as "eurGDP",
(select eurGDP/allGDP*100 ) as "eurGDP";
/*60. Melyek azok az átlagnál gazdagabb országok, amelyek nem az európai vagy az*/
/*amerikai kontinensen találhatóak?*/
select orszag
from orszagok
where gdp>(select avg(gdp) from orszagok) and foldr_hely not like "%Európa" or "%Amerika%";

/*61. Milyen államformák léteznek Európában?*/
SELECT COUNT(DISTINCT allamforma) AS "Államforma db" FROM `orszagok` WHERE foldr_hely LIKE "%Európa%";

/*62. Hányféle államforma létezik a világon?*/
SELECT COUNT(DISTINCT allamforma) AS "Államforma db" FROM `orszagok`;

/*63. Hányféle fizetőeszközt használnak Európában az eurón kívül?*/
SELECT COUNT(*) AS "Nem euró európában" FROM `orszagok` WHERE foldr_hely LIKE "%Európa%" AND penznem != "euró";

/*64. Mely pénznemeket használják több országban is?*/
SELECT DISTINCT penznem FROM `orszagok` WHERE (SELECT COUNT(*) AS penznemdb FROM orszagok) > 2 GROUP BY penznem;

/*65. Mely országok államformája egyedi?*/
SELECT DISTINCT orszag FROM `orszagok` WHERE allamforma NOT LIKE "%monarchia%" AND allamforma NOT LIKE "%köztársaság%";
