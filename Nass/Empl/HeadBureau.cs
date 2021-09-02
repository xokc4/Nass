using System;

namespace Nass
{
    class HeadBureau : Person
    {
        Random random = new Random();
        public HeadBureau(string name, string surname, int salary, int years)
           : base(name, surname, salary, years)
        {

        }
        public HeadBureau() : this("", "", 20000, 18)
        {
        }
        public new int Salary(int salary)
        {
            salary = 1000000;
            return salary;
        }
        public new int Years()
        {
            return random.Next(30, 38);
        }
    }
}
