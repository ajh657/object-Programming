using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11
{
    class Nisakkaat : Elain
    {
        public int LiikumisNopeus;

        public void asetaLiikumisNopeus(int Nopeus) { this.LiikumisNopeus = Nopeus; }

        public int palautaLiikumisNopeus() { return LiikumisNopeus; }
    }
}
