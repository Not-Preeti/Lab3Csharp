/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Csharp
{
    class Employees {

        class Employee
        {
            public string EmpName { get; set; }
            public int Salary { get; set; }
            public string Address { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){EmpName="Angela",Salary=40000 ,Address="Kathmandu"},
                new Employee(){EmpName="Ganga",Salary=60000 ,Address="Pokhara"},
                new Employee(){EmpName="Imili",Salary=100000 ,Address="Kathmandu"},
                new Employee(){EmpName="Nabina",Salary=80000 ,Address="Kathmandu"},
                new Employee(){EmpName="Urmila",Salary=20000 ,Address="Dhading"}
            };
            var result = from emp in list
                         where emp.Salary > 50000 && emp.Address == "Kathmandu"
                         select emp.EmpName;
            Console.WriteLine("Employee names:");
            foreach (var name in result)
            {
                Console.WriteLine(name);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
*/