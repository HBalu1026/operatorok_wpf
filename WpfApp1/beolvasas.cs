using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class beolvasas
    {
        int op1, op2;
        string operato;

        public beolvasas(int op1, int op2, string operato)
        {
            this.op1 = op1;
            this.op2 = op2;
            this.operato = operato;
        }

        /* old meg az alábbi feladatsort wpf-ben! A fájlok beolvasásakor hozz létre egyúj osztályt és read all line-t használj!
           A következő feladatban kifejezéseket tartalmazó szöveges állományból kell adatokat kinyernie és feldolgoznia.
A megoldás során vegye figyelembe a következőket:
'A képernyőre Írást igénylő részfeladatok eredményének megjelenĺtése előtt Írja a képernyőre a feladat sorszámát (például: 3. feladat:)!
'Az egyes feladatokban a kiírásokat a minta szerint készítse el!
•Az ékezetmentes azonosítók és kiírások is elfogadottak.
'Az azonosítókat kis- és nagybetűkkel is kezdheti.
•A program megírásakor az állományban lévő adatok helyes szerkezetét nem kell ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.
'Megoldását úgy készítse el, hogy az azonos szerkezetú, de tetszőleges bemeneti adatok mellett is helyes eredményt adjon!
A kifej ezesek. txt forrásállomány soraiban aritmetikai kifejezések találhatók a következő leírás szerint:
• Soronként az első adat a kifejezés első operandusa. Feltételezheti, hogy egész számra alakítható.
KORLÁTOZOTT TERJESZTÉSŰ!		1. sz. példány
'A második adat szöveges típusú, maximum három karakter hosszúságú. Az operátort határozza meg! Lehet olyan eset, hogy az operátor nem értelmezhető aritmetikai operátorként.
•A harmadik adat a kifejezés második operandusa. Feltételezheti, hogy egész számra alakítható.
'Az adatokat szóközökkel választottuk el, például:
500 mod 265
780 / 114
814 div 200
470 - 531
802 * 553
76€ 767

Készítsen konzolos alkalmazást (projektet) a következő feladatok megoldásához, melynek projektjét Operátorok néven mentse el!
1.	Olvassa be a kifej ezesek . txt állomány sorait és tárolja az adatokat egy olyan összetett adatszerkezetben (pl. vektor, lista stb.), amely használatával a további feladatok megoldhatók!
2.	Határozza meg és írja ki a képernyőre, hogy az állomány hány kifejezést tartalmaz!
3.	A maradékos osztás operátorát a mod szóval jelöltük az állományban. Határozza meg és Írja a képernyőre a maradékos osztást tartalmazó kifejezések számát!
    051C 4. Döntse el, hogy a forrásállományban található-e olyan kifejezés, amelyben mindkét operandus maradék nélkül osztható tízzel! Az eldöntés eredményét Írja a képernyőre! A keresést ne folytassa, ha a választ meg tudja adni!
5.	Az egész osztás operátorát a div szóval jelöltük az állományban. Készítsen statisztikát az összeadás (+), kivonás (—), szorzás (*), valós osztás (/), egész osztás (div) és maradékos osztás (mod) operátorokat tartalmazó kifejezések számáról!
6.	Készítsen szöveges típusú adattal visszatérő függvényt, metódust vagy jellemzőt a kifejezés éltékének meghatározására! A függvény az előző feladatban felsorolt operátorokat tudja kezelni, ismeretlen operátor esetén térjen vissza a „Hibás operátor!” üzenettel! Helyes operátor esetén sem lehet egy kifejezés értékét mindig meghatározni (pl. túlcsordulás, nullával való osztás stb.), ilyen esetben a függvény térjen vissza az „Egyéb hiba!” üzenettel!
7.	Kérjen be a felhasználótól egy kifejezést, amiről feltételezheti, hogy a forrás  állományban lévő kifejezések leírásának megfelel! Határozza meg az előző feladatban definiált mggvény felhasználásával a kifejezés értékét, majd írja ki azt a minták szerint! A feladatot ismételje a „vége” inputig!
8.	Készítsen szöveges állományt eredmenyek . txt néven a minta szerint, melyben meghatározza a forrásállományban lévő kifejezések eredményeit!
*/
    }
}
