using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Koira
    {
        private int ika;
        public String nimi;

        public Koira() { this.nimi = "Haukkuli"; }

        public Koira(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public bool asetaKoiranNimi(String nimi)
        {
            if (nimi != "Musti")
            {
                this.nimi = nimi;
                return true;
            }
            else
            {
                return false;
            }


        }

        public void asetaKoiranIka(int ika)
        {
            if (ika >= 0)
            {
                this.ika = ika;
            }
        }

        public String PalautaKoiranNimi()
        {
            return nimi;
        }

        public int PalautaKoiranika()
        {
            return ika;
        }
    }
}
