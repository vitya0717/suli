/*1. Listázza ki,az összes ügyfelet és az összes adatukat a bank táblából!*/
SELECT * FROM `bank`;
/*2. Listázza ki,az összes autót és az összes adatukat az auto táblából!*/
SELECT * FROM `auto`;
/*3. Listázza ki, hogy milyen várósból vannak ügyfelek a bank táblában, abc szerint csökkenő sorrendben és minden város csak egyszer szerepeljen!*/
SELECT DISTINCT(varos) FROM `bank` ORDER BY varos DESC;
/*4. Listázza ki, hogy milyen tipusú autók vannak az auto táblában, abc szerint növekvő sorrendben és minden autó csak egyszer szerepeljen!*/
SELECT DISTINCT(tipus) from `auto` ORDER BY tipus;
/*5. Listázza, hogy milyen színű autók vannak jelenleg a kereskedésbe, minden szín csak egyszer szerepeljen abc sorrendben!*/
SELECT DISTINCT(szin) from `auto` ORDER BY szin;
/*6. Listázza, hogy milyen keresztnevű ügyfelek vannak a bamk táblában, minden keresztnév csak egyszer szerepeljen csökkenő abc sorrendben!*/
SELECT DISTINCT(keresztnev) from `bank` ORDER BY keresztnev DESC;
/*7. A bank táblából írassa ki, hogy kinek van a legtöbb pénz a számláján!*/
SELECT MAX(egyenleg) FROM `bank`;
/*8. A bank táblából írassa ki, hogy kinek van a legkevesebb pénz a számláján!*/
SELECT MIN(egyenleg) FROM `bank`;
/*9. A bank táblából írassa ki, hogy ki az 5 leggazdagabb!*/
SELECT egyenleg FROM `bank` ORDER BY egyenleg DESC LIMIT 5;
/*10. A bank táblából írassa ki, hogy ki az 5 legszegényebb!*/
SELECT egyenleg FROM `bank` ORDER BY egyenleg ASC LIMIT 5;
/*11. Írassa ki azoknak az autóknak a nevét és rendszámát, amely piros színű vagy 2010 után gyártották!*/
SELECT tipus, rendszam, gyartas_datuma FROM `auto` WHERE szin = "piros" OR gyartas_datuma >= '2011-01-01';
/*12. Írassa ki azoknak az autóknak a nevét és rendszámát, amelyet 2005 és 2010 között gyártották!*/
SELECT tipus, rendszam FROM `auto` WHERE gyartas_datuma BETWEEN '2005-01-01' AND '2010-01-01';
/*13. Írassa ki azoknak az autóknak a nevét és rendszámát, amelyet 2005 előtt gyártottak!*/
SELECT tipus, rendszam, gyartas_datuma FROM `auto` WHERE szin = "piros" OR gyartas_datuma < '2005-01-01';
/*14. Írassa ki azoknak az autóknak a nevét és rendszámát, amelyet 2010 után gyártottak!*/
SELECT tipus, rendszam, gyartas_datuma FROM `auto` WHERE gyartas_datuma >= '2011-01-01';
/*15. Írassa ki a bank táblából azon ügyfelek neveit és lakcímét, akik Budapestiek és a számlájukon min. 100000 HUF van!*/
SELECT vezeteknev, keresztnev, lakcim 
FROM `bank` 
WHERE varos = "Budapest" 
AND egyenleg >= 10000;
/*16. Írassa ki a bank táblából azon ügyfelek neveit és lakcímét, akik Veszprémiek és a számlájukon kevesebb, mint 10000 HUF van!*/
SELECT vezeteknev, keresztnev, lakcim 
FROM `bank` 
WHERE varos = "Veszprém" 
AND egyenleg < 10000;
/*17. Írassa ki az 5 legújabb gyártású autó típusát!*/
SELECT tipus, gyartas_datuma FROM `auto` ORDER BY gyartas_datuma DESC LIMIT 5;
/*18. Írassa ki az 5 legrégebbi gyártású autó típusát!*/
SELECT tipus, gyartas_datuma FROM `auto` ORDER BY gyartas_datuma LIMIT 5;
/*19. Ki az a személy akinek a legkevesebb pénze van és irányítószáma 8200?*/
SELECT vezeteknev, keresztnev, egyenleg FROM bank WHERE iranyitoszam = "8200" ORDER BY egyenleg ASC LIMIT 1;
/*20. Ki az a személy akinek a legtöbb pénze van és irányítószáma 8200?*/
SELECT vezeteknev, keresztnev, egyenleg FROM bank WHERE iranyitoszam = "8200" ORDER BY egyenleg DESC LIMIT 1;
/*21. Bármi Áronnak milyen típusú és szinű autója van?*/
SELECT tipus, szin from `auto` WHERE utalo_fel_neve = "Bármi Áron";
/*22. Dil Emmának milyen típusú és szinű autója van?*/
SELECT tipus, szin from `auto` WHERE utalo_fel_neve = "Dil Emma";
/*23. Van-e a bank táblában Miskolci ügyfél, ha igen ki az?*/
SELECT DISTINCT(varos), vezeteknev, keresztnev FROM `bank` WHERE varos = "Miskolc";
/*24. Van-e a bank táblában Egri ügyfél, ha igen ki az?*/
SELECT DISTINCT(varos), vezeteknev, keresztnev FROM `bank` WHERE varos = "Eger";
/*25. Kinek a bankszámlája a HU987654321?*/
SELECT vezeteknev, keresztnev FROM `bank` WHERE szamlaszam = "HU987654321";
/*26. Kinek az autója egy kék szinű Citroen?*/
SELECT utalo_fel_neve, tipus, szin FROM `auto` WHERE szin = "kék" AND tipus="Citroen";
/*27. Kik azok a személyek, akiknak nincs megtakarítás a számlájukon?*/
SELECT vezeteknev, keresztnev FROM `bank` WHERE egyenleg < 0;
/*28. Kik azok a személyek, akiknak van megtakarítás a számlájukon?*/
SELECT vezeteknev, keresztnev FROM `bank` WHERE egyenleg > 0;
/*29. Van-e 5 ajtós autó az autók között, ha igen milyen tipusú?*/
SELECT DISTINCT(ajtok_szama), tipus FROM `auto` WHERE ajtok_szama = 5;
/*30. Van-e 2 ajtós autó az autók között, ha igen milyen tipusú, egy tipus csak egyszer szerepeljen?*/
SELECT DISTINCT(ajtok_szama), tipus FROM `auto` WHERE ajtok_szama = 2;