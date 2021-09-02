using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nass.StructurCompany
{
  public class Departaments
    {
        public string Name { get; set; }
        public List<Employee> Employees;
        public Departaments(string name, List<Employee> employees)
        {
            this.Name = name;
            this.Employees = employees;
        }
    }
}
