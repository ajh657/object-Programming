using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace T6
{
    class Kissa
    {
        private int ika;
        public String nimi;

        public Kissa() { this.nimi = "Kisuli"; }

        public Kissa(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public bool asetaKissanNimi(String nimi)
        {
            if (nimi != "Hilda")
            {
                this.nimi = nimi;
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public void asetaKissanIka(int ika)
        {
            if (ika >= 0)
            {
                this.ika = ika;
            }
        }

        public String PalautaKissanNimi()
        {
            return nimi;
        }

        public int PalautaKissanika()
        {
            return ika; 
        }
    }
}