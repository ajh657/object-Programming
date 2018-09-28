using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Koira koira = new Koira();
            Kissa kissa = new Kissa();
            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                int KoiraIka = rnd.Next(0, 16);
                int KissanIka = rnd.Next(1, 11);

                koira.asetaKoiranIka(KoiraIka);
                kissa.asetaKissanIka(KissanIka);

                Console.WriteLine("Koira on: " + KoiraIka + " vuotta" + " Kissa on: " + KissanIka + " vuotta");

                if (KoiraIka > KissanIka)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
