using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Magasin
    {
        public string City { get; set; }
        public string Name { get; set; }

        public Magasin(string city, string name)
        {
            City = city;
            Name = name;
        }
    }
}
