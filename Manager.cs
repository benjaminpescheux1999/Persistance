using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Manager
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public List<Vendeur> vendeurs;
        public Manager(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }


    }
}
