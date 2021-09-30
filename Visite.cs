using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Visite
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string flag { get; set; }
        public string magasin { get; set; }
        public string commercial { get; set; }

        public Visite()
        {

        }

        public Visite(string id, DateTime datevisite, string flag, string magasin, string commercial)
        {
            this.id = id;
            this.date = datevisite;
            this.flag = flag;
            this.magasin = magasin;
            this.commercial = commercial;
        }
    }
}
