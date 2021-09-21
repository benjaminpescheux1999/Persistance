using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Vendeur
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string fonction { get; set; }
        public string nomdumanager { get; set; }
        public Vendeur()
        {
            this.nom = nom;
            this.prenom = prenom;
            this.fonction = fonction;
            this.nomdumanager = nomdumanager;
        }
    }
}
