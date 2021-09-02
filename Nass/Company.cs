using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nass
{
   public  class Company
    {
        public string Name { get; set; }

        public List<StructurCompany.Bureu> Bureus;

        public Company(string Name, List<StructurCompany.Bureu> bureus)
        {
            this.Name = Name;
            this.Bureus = bureus;
        }
    }
}
