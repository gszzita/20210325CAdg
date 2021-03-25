using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20210324CAdg
{
    class Program
    {
        static Random rnd = new Random();

        //static int[] tomb = new int[100];

        static void Main()
        {

            Feladat();

            //RandomSzsamok();

            Console.ReadKey();
        }

        /*static void RandomSzsamok()
        {
            int rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                int szam = rnd.Next(1000, 10000);
                while (szam % 5 != 0)
                    szam = rnd.Next(1000, 10000);
                tomb[i] = szam;
            }
            Console.WriteLine(tomb);
        }*/

        private static void Feladat();
        {
            /*for (int i = 0; i< tomb.Length; i++)
            {
                Random rnd = new Random();
                int szam = rnd.Next(1000, 10000);
                while (szam % 5 != 0) szam = rnd.Next(1000, 10000);
                tomb[i] = szam;
                Console.WriteLine(tomb[i]);
            }*/



            int[] tomb = new int[100];
            for (int i = 0; i<tomb.Length; i++)
            {
                int szamok = rnd.Next(1000, 10000);
                //while (szamok % 5 == 0)
                while (szamok % 5 != 0)
                {
                    tomb[i] = szamok;
                }


                Console.Write(tomb[i] + "  ");
                if ( if % 10 == 0) Console.Write("\n");


                if ((i +1) % 7 == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = Console.Clear();
            }


                Console.WriteLine($"Tömb elemeinek összege: {tomb.Sum()}");


            int KNszamok = 0;
            for (int i = 0; i < tomb.Lenght; i++)
            {
                if (4000 <= tomb[i] && tomb[i] > 5000)
                    KNszamok += tomb[i];
                KNszamok++;
            }
            Console.WriteLine($"400-nél nem nagyobb, de 5000-nél nem kisebb elemek átlaga: {KNszamok / (float)KNszamok.Length}")


                        while (i < tomb.Length && tomb[i] % 65 != 0) i++;
            Console.WriteLine($"65 első többszörösének értéke és indexe: {tomb[i}, {i}");


            int harommmalKezdodo = 0;
            foreach (int 3000 <= tomb[i] && 4000 > tomb[i]) harommmalKezdodo += 1;

            Console.WriteLine($"{harommmalKezdodo} db 3-sal kezdődő szám van a tömbben.");


            int o = 0;
            while (o < tomb.Length && tomb[i] < 3000)
            {
                i++;
                if (o > tomb[i]) Console.WriteLine($"Az első általam gondolt junior szf. órabérének mértéke és indexe: {tomb[i]}, {i}");
                else Console.WriteLine("Nem szerepel elfogadható számadat a tömbben");
            }


            int[] szazasok = new int[tomb.Length];
            int sz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 100 == 0)
                {
                    szazasok[sz] = tomb[i];
                    sz++;
                }
                Console.WriteLine(sz);
            }


            int szulEv = 1997;
            switch (szulEv)
            {
                case 6:
                case 1: -1;
                case 7:
                case 2: -2;
                case 8:
                case 3: +2;
                case 9:
                case 4: +1;
                //case 10:
               //case 5: +0;

                    return kerekitett;
            }

            Console.WriteLine($"Születési évem a kerekítési szabály szerint: {kerekitett}");

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == kerekitett) Console.WriteLine($"\t A szám szerepel a tömbben.");
                else Console.WriteLine($"\t A szám nem szerepel a tömbben.");
            }
        }
    }
}
