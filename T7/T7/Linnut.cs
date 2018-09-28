using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Linnut : Elain
    {
        public int SiipienKoko;

        public void aseteSiivenKoko(int koko) { this.SiipienKoko = koko; }
        public int PalautaSiivenKoko() { return SiipienKoko; }
    }
}
