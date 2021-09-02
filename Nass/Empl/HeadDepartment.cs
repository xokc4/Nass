using System;

namespace Nass
{
    class HeadDepartment : Person
    {

        Random random = new Random();
        public HeadDepartment(string name, string surname, int salary, int years)
           : base(name, surname, salary, years)
        {

        }
        public HeadDepartment() : this("", "", 20000, 18)
        {
        }
        public new int Salary(int quantity)
        {

            return quantity * 15;
        }
        public new int Years()
        {
            return random.Next(26, 33);
        }
    }
}
