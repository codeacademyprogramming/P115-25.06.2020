using _250620.Exceptions;
using System;
using System.Collections.Generic;

namespace _250620
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[] { "Aytac", "Ceyhun", "Fatime", "Sattar" };
            Console.WriteLine(adlar[8]);

            try
            {
                Console.WriteLine(adlar[8]);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Yazdiginiz nomre duzgun deyil, 0-{adlar.Length-1} yaza bilersiniz");
            }
        }
    }
}
