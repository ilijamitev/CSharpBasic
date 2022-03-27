using SEDC.Class03.AtmApp.Models;
using System;

namespace SEDC.Class03.AtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "   *** ATM MACHINE ***";
            AtmApplication atm = new AtmApplication();
            atm.AtmMain();
        }
    }
}
