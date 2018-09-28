using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11
{
    class Elain
    {
        private int ika;
        public String nimi;
        bool OnLihanSyoja;

        public Elain() {}

        public Elain(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void asetaElaimenNimi(String nimi)
        {
            this.nimi = nimi;
        }

        public void asetaElaimenIka(int ika)
        {
            if (ika >= 0)
            {
                this.ika = ika;
            }
        }

        public String PalautaElaimenNimi()
        {
            return nimi;
        }

        public int PalautaElaimenika()
        {
            return ika;
        }

        public void AsetaOnLihanSyoja(bool Boolean)
        {
            OnLihanSyoja = Boolean;
        }

        public bool PalautaOnLihanSyöjä()
        {
            return OnLihanSyoja;
        }
    }
}
