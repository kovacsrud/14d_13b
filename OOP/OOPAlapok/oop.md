# Objektum-orientált programozás(OOP)

Struktúrált programozás
 - szekvencia,szelekció,iteráció

## Szoftver krízis

A megoldandó feladatok bonyolultabbá válása miatt új szemlélet kellett, ez az OOP.

Az OOP programozás alapeleme az osztály(class)
Egy adott osztályt általában valamilyen jól meghatározható feladatra készítenek.

Pl.
+--------------------------------------+
| Ember                                |
+--------------------------------------+
| Kor                                  |
| Magasság                             |
| Súly                                 |
| Név                                  |
| Neme                                 |
|                                      |
+--------------------------------------+
|                                      |
|  Mozog()                             |
|  Alszik()                            |
|  Beszél()                            |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
|                                      |
+--------------------------------------+

Az osztály tartalmaz adatokat (adattag,mező)
Az osztály tartalmazhat metódusokat (ez ugyanaz mint a függvény)

Az adatok és a metódusok vannak "bezárva" az osztályba.
A bezártság (encapsulation) azt jelenti, hogy csak az férhet hozzá az osztályhoz, akinek ezt megengedjük.
Az osztály adataihoz csak metódusokon keresztül lehet hozzáférni.
      
**Konstruktor**
Olyan speciális metódus, ami az osztály példányosításakor fut le, az
adattagok kezdeti értékeinek megadására(inicializálás)  használjuk. Lehet paraméteres, illetve paraméter nélküli is. Több konstruktort is tartalmazhat az osztály, de a paraméterlistáiknak eltérőnek kell lenniük.

**Property**
A property az adattag és az ennek értékét beállító/lekérdező metódust jelenti.
A get, illetve set metódusok kifejtésével megadhatóak a megfelelő ellenőrzések/tevékenységek, ha szükséges.