using System;

namespace Nass
{
   public class Employee : Person
    {
        Random random = new Random();
        public Employee(string name, string surname, int salary, int years)
           : base(name, surname, salary, years)
        {

        }
        public Employee() : this("", "", 20000, 18)
        {
        }
        public new int oiualary(int salary)
        {
            salary = salary * 8;
            return salary * 28;
        }
        public new int weears()
        {
            return random.Next(19, 28);
        }
    }
}
