using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.AtmApp.Models
{
    public class AtmApplication
    {

        AtmUsers[] UsersArr =
        {
            new AtmUsers("Ilija Mitev", 1234123412341234, 1234),
            new AtmUsers("Petko Petkovski", 1111222233334444, 1111),
            new AtmUsers("Bob Bobski", 2222333344445555, 2222)
        };


        public void CashMenu(AtmUsers logedUser)
        {
            AtmCashService cashService = new AtmCashService();
            while (true)
            {
                Console.WriteLine("\n   Select one of the options: \n 1.Check Balance\n 2.Cash Withdraw\n 3.Cash Deposit\n 4.Exit");
                string chooseCashOperation = Console.ReadLine();
                if (chooseCashOperation == "1")
                {
                    cashService.CheckBalance(logedUser);
                }
                else if (chooseCashOperation == "2")
                {
                    cashService.CashWithdrew(logedUser);
                }
                else if (chooseCashOperation == "3")
                {
                    cashService.CashDeposit(logedUser);
                }
                else
                {
                    break;
                }
            }
        }


        public void AtmMain()
        {
            AtmUsersService userService = new AtmUsersService();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n     WELCOME TO ATM APP\n 1)LogIn\n 2)Register\n 3)Exit");
                Console.ResetColor();

                string welcomeMenu = Console.ReadLine();

                if (welcomeMenu == "1")
                {
                    userService.LogIn(ref UsersArr);
                    CashMenu(userService.LogedInUser);
                }
                else if (welcomeMenu == "2")
                {
                    userService.Register(ref UsersArr);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\n\n\n\n\n\n             *** THANK YOU FOR USING OUR ATM APP. BE WELL! ***");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
