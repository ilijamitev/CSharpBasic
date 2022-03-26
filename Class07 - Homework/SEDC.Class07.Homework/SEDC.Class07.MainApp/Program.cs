using SEDC.Class07.AppLibrary.Enums;
using SEDC.Class07.AppLibrary.Models;
using System;

namespace SEDC.Class07.MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "     ***MyGoogle Inc.***";

            SalesPerson ilija = new SalesPerson("Ilija", "Mitev");
            ilija.AddSuccessRevenue(500);
            // Console.WriteLine(ilija.GetSalary());

            Manager trajan = new Manager("Trajan", "Stevkovski", 5000, Department.Development);
            trajan.AddBonus(1000);
            // Console.WriteLine(trajan.GetSalary());
            // Console.WriteLine($"TRAJAN IS MANAGER OF {trajan.Department}");

            Manager kiko = new Manager("Kristijan", "Karanfilovski", 4000, Department.Finance);
            Contractor bobi = new Contractor("Bobi", "Bobsky", 4, 50, kiko);
            Contractor pink = new Contractor("Pink", "Panther", 3, 150, trajan);
            // Console.WriteLine(bobi.CurrentPosition());
            // Console.WriteLine(bobi.GetSalary());
            // Console.WriteLine(pink.Responsible.FirstName);
            // Console.WriteLine("=================================================");

            Employee[] employees = { ilija, trajan, kiko, bobi, pink };
            CEO sofija = new CEO("Sofija", "Vergara", 7000, employees, 50);
            sofija.AddSharesPrice(200);
            sofija.GetSalary();
            sofija.PrintInfo();
            sofija.PrintEmployees();





            Console.ReadLine();
        }
    }
}
