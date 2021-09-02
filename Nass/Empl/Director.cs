using System;

namespace Nass
{
    class Director : Person
    {
        Random random = new Random();
        public Director(string name, string surname, int salary, int years)
           : base(name, surname, salary, years)
        {

        }
        public Director() : this("", "", 20000, 18)
        {
        }
        public new int Salary(int salary)
        {
            salary = 2500000;
            return salary;
        }
        public new int Years()
        {
            return random.Next(42, 45);
        }
    }
}
