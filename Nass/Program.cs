using System;
using System.Collections.Generic;

namespace Nass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>();
            List<StructurCompany.Bureu> bureus = new List<StructurCompany.Bureu>();
            List<StructurCompany.Departaments> departaments = new List<StructurCompany.Departaments>();
            List<Employee> employees = new List<Employee>();
            int r = Convert.ToInt32(Console.ReadLine());
            for(int i= 0; i<r; i++)
            {
                bureus.Add(new StructurCompany.Bureu()
                {
                    Name = Console.ReadLine(),
                    Departaments = departaments
                });
                
                

                int global = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < global; j++)
                {
                    departaments.Add(new StructurCompany.Departaments()
                    { 
                     Name = "departaments"+j,
                     Employees = employees
                    });
                    int u = Convert.ToInt32(Console.ReadLine());
                    for(int y=0; y<u; y++)
                    {
                        employees.Add(new Employee()
                        {
                            Name = "Имя" + y,
                            Surname = "Фамилия" + y,
                            Salary = 100,
                            Years = 19

                        });
                    }
                }
            }
            companies.Add(new Company()
            {

            }
            );
        }
    }
}
