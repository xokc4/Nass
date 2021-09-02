using System;

namespace Nass
{
    class AssociateDirector : Person
    {
        Random random = new Random();
        public AssociateDirector(string name, string surname, int salary, int years)
           : base(name, surname, salary, years)
        {

        }
        public AssociateDirector() : this("", "", 20000, 18)
        {
        }
        public new int Salary(int salary)
        {
            salary = 1500000;
            return salary;
        }
        public new int Years()
        {
            return random.Next(39, 40);
        }
    }
}
