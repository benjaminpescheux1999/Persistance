using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class Visite
    {
        public string idvisite { get; set; }
        public string datevisite { get; set; }
        public string flag { get; set; }
        public string magasin { get; set; }
        public string commercial { get; set; }

        public Visite(string idvisite, string datevisite, string flag, string commercial, string magasin)
        {
            this.idvisite = idvisite;
            this.datevisite = datevisite;
            this.flag = flag;
            this.magasin = magasin;
            this.commercial = commercial;
        }
    }
}