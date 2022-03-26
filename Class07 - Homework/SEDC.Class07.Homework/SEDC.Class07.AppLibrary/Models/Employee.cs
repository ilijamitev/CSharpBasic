using SEDC.Class07.AppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.AppLibrary.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role EmployeeRole { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {EmployeeRole} and recives {Salary}$.");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
