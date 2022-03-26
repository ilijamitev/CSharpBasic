using SEDC.Class07.AppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.AppLibrary.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Department Department { get; set; }

        public Manager(string firstName, string lastName, double salary, Department department)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Department = Department.TechicalSupport;
            EmployeeRole = Role.Manager;
            Department = department;
        }

        public void AddBonus(double bonusInput)
        {
            Bonus = bonusInput;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }

    }
}
