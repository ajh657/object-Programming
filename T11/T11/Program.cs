using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGenerator;

namespace T11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Hevonen hevonen = new Hevonen();
            Kissa kissa = new Kissa();
            Koira koira = new Koira();
            Papukaija papukaija = new Papukaija();

            int Length = int.Parse(Console.ReadLine());
            for (int i = 0; i < Length; i++)
            {
                hevonen.asetaElaimenNimi(NameGenerator.GenerateFirstName(Gender.Male));
                kissa.asetaElaimenNimi(NameGenerator.GenerateFirstName(Gender.Male));
                koira.asetaElaimenNimi(NameGenerator.GenerateFirstName(Gender.Male));
                papukaija.asetaElaimenNimi(NameGenerator.GenerateFirstName(Gender.Male));

                hevonen.asetaElaimenIka(rnd.Next(1, 13));
                kissa.asetaElaimenIka(rnd.Next(1, 13));
                koira.asetaElaimenIka(rnd.Next(1, 13));
                papukaija.asetaElaimenIka(rnd.Next(1, 13));

                hevonen.AsetaOnLihanSyoja(true);
                kissa.AsetaOnLihanSyoja(true);
                koira.AsetaOnLihanSyoja(true);
                papukaija.AsetaOnLihanSyoja(false);

                papukaija.aseteSiivenKoko(rnd.Next(1, 13));
                koira.asetaLiikumisNopeus(rnd.Next(1, 13));

                Console.WriteLine();

                Console.WriteLine(hevonen.PalautaElaimenNimi());
                Console.WriteLine(hevonen.PalautaElaimenika());
                Console.WriteLine(hevonen.PalautaOnLihanSyöjä());
                Console.WriteLine();
                Console.WriteLine(kissa.PalautaElaimenNimi());
                Console.WriteLine(kissa.PalautaElaimenika());
                Console.WriteLine(kissa.PalautaOnLihanSyöjä());
                Console.WriteLine();
                Console.WriteLine(koira.PalautaElaimenNimi());
                Console.WriteLine(koira.PalautaElaimenika());
                Console.WriteLine(koira.PalautaOnLihanSyöjä());
                Console.WriteLine(koira.palautaLiikumisNopeus());
                Console.WriteLine();
                Console.WriteLine(papukaija.PalautaElaimenNimi());
                Console.WriteLine(papukaija.PalautaElaimenika());
                Console.WriteLine(papukaija.PalautaOnLihanSyöjä());
                Console.WriteLine(papukaija.PalautaSiivenKoko());
            }

            Console.ReadKey();
        }
    }
}
