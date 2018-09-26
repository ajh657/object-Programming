using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Kissa
    {
        private int ika;
        public String nimi;

        public Kissa() { }

        public Kissa(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void asetaKissanNimi(String nimi)
        {
            this.nimi = nimi;
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
