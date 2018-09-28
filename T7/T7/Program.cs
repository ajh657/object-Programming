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
            Papukaija papukaija = new Papukaija();

            kissa.asetaElaimenIka(int.MaxValue);
            kissa.asetaElaimenNimi("Boobies");
            kissa.AsetaOnLihanSyoja(true);

            koira.asetaElaimenIka(int.MaxValue / 3);
            koira.asetaElaimenNimi("Dick");
            koira.AsetaOnLihanSyoja(true);
            koira.asetaLiikumisNpeus(2139012);

            papukaija.asetaElaimenIka(938420);
            papukaija.asetaElaimenNimi("Birb");
            papukaija.aseteSiivenKoko(32443);

            Console.WriteLine(koira.PalautaElaimenNimi());
            Console.WriteLine(koira.PalautaElaimenika());
            Console.WriteLine(koira.PalautaOnLihanSyöjä());
            Console.WriteLine(koira.palautaLiikumisNopeus());

            Console.WriteLine();

            Console.WriteLine(papukaija.PalautaElaimenika());
            Console.WriteLine(papukaija.PalautaElaimenNimi());
            Console.WriteLine(papukaija.PalautaSiivenKoko());

            Console.WriteLine();

            Console.WriteLine(kissa.PalautaElaimenika());
            Console.WriteLine(kissa.PalautaElaimenNimi());
            Console.WriteLine(kissa.PalautaOnLihanSyöjä());



            Console.ReadKey();
        }
    }
}
