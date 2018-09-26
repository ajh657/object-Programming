using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5.Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Hevonen
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen hevonen = new Hevonen();

            hevonen.Nimi = "Nulle";
            hevonen.Paino = int.MaxValue;
            Console.WriteLine(hevonen.Nimi + " " + hevonen.Paino + "kg");
            Console.ReadKey();
        }
    }
}
