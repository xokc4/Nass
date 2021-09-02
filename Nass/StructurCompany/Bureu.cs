using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nass.StructurCompany
{
   public  class Bureu
    {
        public string Name { get; set; }
        public List<Departaments> Departaments;
        public Bureu(string name, List<Departaments> departaments)
        {
            this.Name = name;
            this.Departaments = departaments;
        }

    }
}
