using System;

namespace Nass
{
   public  class Person
    {
        Random random = new Random();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Years { get; set; }
        public int YearsPerson()
        {
            return random.Next(18, 30);
        }

        public int SalaryPerson(int Salary)
        {
            return Salary * 28;
        }
        public Person(string name, string surname, int salary, int years)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = SalaryPerson(salary);
            this.Years = YearsPerson();
        }
        public Person() : this("", "", 20000, 18)
        {
        }
    }
}
