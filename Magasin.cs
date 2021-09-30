using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class Magasin
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string city { get; set; }
        public Magasin(string id, string nom, string city)
        {
            this.id = id;
            this.nom = nom;
            this.city = city;
        }
    }
}
