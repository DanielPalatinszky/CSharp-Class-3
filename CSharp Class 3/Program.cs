using System;
using System.Linq;

namespace CSharp_Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb: adott típusból egyszerre többet tárolhatunk
            //Létrehozás adott mérettel
            var tomb1 = new int[4];

            //Létrehozás az elemek megadásával
            var tomb2 = new int[4] {0, 1, 2, 3};

            //Rövidebben
            var tomb3 = new int[] {0, 1, 2, 3};

            //Még rövidebben (var nem használható)
            int[] tomb4 = {0, 1, 2, 3};

            //Elemek elérése indexeléssel
            //Első elem indexe: 0
            //Utolsó elem indexe: tömb hossza - 1

            //Olvasás
            var elso = tomb4[0];
            var utolso = tomb4[tomb4.Length - 1];

            //Írás
            tomb4[1] = 10;

            //Túlindexelés esetén hiba
            //Console.WriteLine(tomb4[10]);

            //Tömb bejárása for ciklussal
            var random = new Random();
            for (int i = 0; i < tomb4.Length; i++)
            {
                tomb4[i] = random.Next(1, 10);
            }

            for (int i = 0; i < tomb4.Length; i++)
            {
                Console.WriteLine(tomb4[i]);
            }

            //string-re vigyázzunk
            var szamok = new int[5];
            var szovegek = new string[5];

            //Működik
            Console.WriteLine(szamok[0].ToString());
            //NullReferenceException
            Console.WriteLine(szovegek.Length);

            //Elemek bejárása foreach-el
            //Egyszerűbb, ha nem kell az index
            foreach (var elem in szamok)
            {
                Console.WriteLine(elem);
            }

            //Tömböknek rengeteg hasznos metódusa van
            var osszeg = szamok.Sum();
            var max = szamok.Max();
            var min = szamok.Min();
            var novekvo = szamok.OrderBy(e => e);
            var csokkeno = szamok.OrderByDescending(e => e);
            var tartalmazE = szamok.Contains(2);
            var egyediElemek = szamok.Distinct();
            var forditott = szamok.Reverse();
            var elsoElem = szamok.First();
            var utolsoElem = szamok.Last(); //stb.

            //Egymásba ágyazott tömbök
            //pl. 2x2-es mátrix
            var m = new int[2, 2];
            m[0, 1] = 10;

            //Adott dimenzió elemszámának elérése GetLength-el
            //Elemek kiírása
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }

                Console.WriteLine();
            }

            //Elemek kiírása foreach-el
            foreach (var elem in m)
            {
                Console.WriteLine(elem);
            }

            //Akárhány dimenzió lehet
            var m2 = new int[2, 3, 4, 5, 2, 10];

            //Az egyes beágyazott tömböket nem érhetjük el külön, azaz nem működik
            //var beagyazottTomb = m2[0];

            //Azonban létrehozhatjuk máshogy is
            var m3 = new int[2][];

            //Viszont így csak a külső tömb méretét tudjuk megadni, a többi tömböt deklarálni kell
            for (int i = 0; i < m3.GetLength(0); i++)
            {
                m3[i] = new int[2];
            }

            //Cserébe a beágyazott tömböket külön is elérhetjük
            var beagyazott = m3[0];

            //Sőt, a beágyazott tömbök különböző méretűek lehetnek
            for (int i = 0; i < m3.GetLength(0); i++)
            {
                m3[i] = new int[random.Next(1, 4)];
            }

            //string karaktereit is elérhetjük indexeléssel
            var str = "asd";
            var masodik = str[1];

            //stringnek is sok hasznos metódusa van
            var str2 = "Almafa";
            var alma = str2.Substring(0, 4); //stb.
        }
    }
}
