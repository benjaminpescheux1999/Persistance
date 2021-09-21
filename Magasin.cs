using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Magasin
    {
        public string Ville { get; set; }
        public string Enseigne { get; set; }
        public string Nom { get; set; }

        public Magasin(string ville, string enseigne, string nom)
        {
            this.Ville = ville;
            this.Enseigne = enseigne;
            this.Nom = enseigne + " " + ville;
        }
    }
}
