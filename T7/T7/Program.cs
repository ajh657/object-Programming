using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa();
            Koira koira = new Koira();

            kissa.asetaElaimenIka(int.MaxValue);
            kissa.asetaElaimenNimi("Boobies");
            kissa.AsetaOnLihanSyoja(true);

            koira.asetaElaimenIka(int.MaxValue / 3);
            koira.asetaElaimenNimi("Dick");
            koira.AsetaOnLihanSyoja(true);

            Console.WriteLine(koira.PalautaElaimenNimi());
            Console.WriteLine(koira.PalautaElaimenika());
            Console.WriteLine(koira.PalautaOnLihanSyöjä());

            Console.WriteLine(kissa.PalautaElaimenika());
            Console.WriteLine(kissa.PalautaElaimenNimi());
            Console.WriteLine(kissa.PalautaOnLihanSyöjä());

            Console.ReadKey();
        }
    }
}
