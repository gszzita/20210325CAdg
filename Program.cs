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
        static int[] tomb = new int[100];

        public static void RandomSzamokTombje()
        {
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int szam = rnd.Next(1000, 10000);
                while (szam % 5 != 0)
                {
                    szam = rnd.Next(1000, 10000);
                }
                tomb[i] = szam;
                Console.WriteLine(tomb[i]);
            }
        }
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(tomb[i]);        }
    }
}
