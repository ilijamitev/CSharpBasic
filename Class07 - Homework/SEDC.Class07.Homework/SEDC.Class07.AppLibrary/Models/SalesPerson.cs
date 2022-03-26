using SEDC.Class07.AppLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.AppLibrary.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            EmployeeRole = Role.Sales;
        }

        public void AddSuccessRevenue(double num)
        {
            SuccessSaleRevenue = num;
        }

        public override double GetSalary()
        {
            double salary = Salary;
            salary = SuccessSaleRevenue <= 2000 ? salary + 500 : salary;
            salary = SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000 ? salary + 1000 : salary;
            salary = SuccessSaleRevenue > 5000 ? salary + 1500 : salary;
            return salary;
        }
    }
}
