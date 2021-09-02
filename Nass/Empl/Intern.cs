using System;

namespace Nass
{
    class Intern : Person
    {
        Random random = new Random();
        public Intern(string name, string surname, int salary, int years)
            : base(name, surname, salary, years)
        {

        }
        public Intern() : this("", "", 20000, 18)
        {
        }
        public new int Years()
        {
            return random.Next(16, 19);
        }
        public new int Salary()
        {
            return 500;
        }
    }
}
