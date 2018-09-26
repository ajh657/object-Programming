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
            Kissa kissa = new Kissa(int.MinValue,"Numa");

            Console.WriteLine(kissa.PalautaKissanika());
            Console.WriteLine(kissa.PalautaKissanNimi());
            Console.ReadKey();
        }
    }
}
