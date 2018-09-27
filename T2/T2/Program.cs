using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa();
            Koira koira = new Koira();

            Console.WriteLine("Anna Kissalle nimi");
            if (kissa.asetaKissanNimi(Console.ReadLine()))
            {
                Console.WriteLine();
                Console.WriteLine("Onnistui");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ei Onistunut: Nimi ei saa olla Hilda");
            }

            Console.WriteLine("Anna Koiralle nimi");
            if (koira.asetaKoiranNimi(Console.ReadLine()))
            {
                Console.WriteLine();
                Console.WriteLine("Onnistui");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ei Onistunut: Nimi ei saa olla Haukkuli");
            }

            Console.WriteLine();

            Console.WriteLine(kissa.PalautaKissanika());
            Console.WriteLine(kissa.PalautaKissanNimi());
            Console.ReadKey();
        }
    }
}
