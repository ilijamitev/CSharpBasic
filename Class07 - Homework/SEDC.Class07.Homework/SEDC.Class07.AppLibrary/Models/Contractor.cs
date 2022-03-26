using SEDC.Class07.AppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.AppLibrary.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager manager)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = manager;
            EmployeeRole = Role.Contractor;
            Salary = 0;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public Department CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
