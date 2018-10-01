using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.model
{
    public class Auto
    {
        public Auto ()
        {

        }

        public int Id { get; set; }
        public decimal Hinta { get; set; }
        public DateTime Rekisteri_paivamaara { get; set; }
        public decimal Moottorin_tilavuus { get; set; }
        public int Mittarilukema { get; set; }
        public int AutonMerkki { get; set; }
        public int AutonMalli { get; set; }
        public int Varit { get; set; }
        public int Polttoaine { get; set; }
    }
}
