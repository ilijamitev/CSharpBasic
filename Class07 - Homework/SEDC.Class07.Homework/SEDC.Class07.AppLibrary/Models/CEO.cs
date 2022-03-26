using SEDC.Class07.AppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.AppLibrary.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }
        public CEO(string firstName, string lastName, double salary, Employee[] employeesArr, int shares)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmployeeRole = Role.CEO;
            Employees = employeesArr;
            SharesProperty = shares;
        }

        public void AddSharesPrice(double sharesPriceInput)
        {
            SharesPrice = sharesPriceInput;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.EmployeeRole}: {employee.FirstName} {employee.LastName}.");
            }
        }

        public override double GetSalary()
        {
            double result = Salary + SharesProperty * SharesPrice;
            return result;
        }

    }
}
