using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.AtmApp.Models
{
    public class AtmCashService 
    {
        public void CheckBalance(AtmUsers user)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"You have {user.CashBalance}$ on your account.");
            Console.ResetColor();
        }

        public void CashWithdrew(AtmUsers user)
        {
            while (true)
            {
                if (user.CashBalance == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU ARE BROKE! GO MAKE SOME MONEY!");
                    Console.ResetColor();
                    break;
                }

                Console.WriteLine("\nEnter the amount of money you wish to withdraw: ");
                bool isValidInput = int.TryParse(Console.ReadLine(), out int withdrawAmount);

                if (!isValidInput || withdrawAmount < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER VALID NUMBER!");
                    Console.ResetColor();
                    continue;
                }

                if (withdrawAmount > user.CashBalance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INSUFICIEND FUNDS!");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    user.CashBalance -= withdrawAmount;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"You withdrewed {withdrawAmount}$. You have {user.CashBalance}$ left on your account.");
                    Console.ResetColor();
                    break;
                }
            }
        }

        public void CashDeposit(AtmUsers user)
        {
            while (true)
            {
                Console.WriteLine("\nEnter the amount of money you wish to deposit: ");
                bool isValidInput = int.TryParse(Console.ReadLine(), out int depositAmount);

                if (!isValidInput || depositAmount < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER VALID NUMBER!");
                    Console.ResetColor();
                    continue;
                }

                user.CashBalance += depositAmount;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Your deposit is {depositAmount}$. You now have {user.CashBalance}$ on your account.");
                Console.ResetColor();
                break;
            }
        }


    }
}
