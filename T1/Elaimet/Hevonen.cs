using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hevonen
{   //Esitellään luokka-class. Koodi olisi voinut olla Program.cs tiedostossa mutta selkeyden takia luomme jokaisen luokan omaan tiedostoonsa
    class Hevonen
    {
        private string nimi;
        private int paino;
        //Konstruktori jossa ei ola parametreja, joten kaikki luokasta synnytetyt oliot ovat samanlaisia
        public Hevonen()
        {
            //Konstruktorissa voi olla oletusarvoja
            //Luokan sisällä voidaan käyttää privaatti kenttiä
            nimi = "";
            paino = 0;
        }
        //getterillä ja setterillä annetaan luokan ulkopuolisille sovelluksille mahdollisuus 
        //asettaa tai hakea kenttiä
        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public int Paino
        {
            get
            {
                return paino;
            }

            set
            {
                paino = value;
            }
        }
    }
}
