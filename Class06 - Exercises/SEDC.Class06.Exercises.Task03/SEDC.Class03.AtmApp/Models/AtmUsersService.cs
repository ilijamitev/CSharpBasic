using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.AtmApp.Models
{
    public class AtmUsersService
    {
        public AtmUsers LogedInUser { get; set; }


        public void LogIn(ref AtmUsers[] usersArr)
        {
            Console.WriteLine($"\n      *** LOG IN MENU ***\n");
            AtmUsers userLogedIn = new AtmUsers();
            long parsedCardNumber = 0;
            bool isTrue = true;
            bool isTrue2 = true;

            while (isTrue)
            {
                Console.WriteLine("Please enter your Card Number: ");
                Console.WriteLine(@"Format: ####-####-####-####");

                string inputCardNumber = Console.ReadLine();

                string pattern = "^[1-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$";
                var regexp = new System.Text.RegularExpressions.Regex(pattern);

                if (!regexp.IsMatch(inputCardNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER A VALID CARD NUMBER !\n");
                    Console.ResetColor();
                    continue;
                }

                parsedCardNumber = long.Parse(inputCardNumber.Replace("-", ""));
                bool showErrorMsg = false;
                for (int i = 0; i < usersArr.Length; i++)
                {
                    if (parsedCardNumber == usersArr[i].CardNumber)
                    {
                        isTrue = !isTrue;
                        showErrorMsg = false;
                        break;
                    }
                    else
                    {
                        showErrorMsg = true;
                    }
                }

                if (showErrorMsg)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO USER WITH THAT CARD NUMBER FOUND!\n");
                    Console.ResetColor();
                }
            }

            while (isTrue2)
            {
                Console.WriteLine("Please enter your Pin: ");
                bool validateInputPin = int.TryParse(Console.ReadLine(), out int inputPin);
                if (!validateInputPin)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER VALID PIN !");
                    Console.ResetColor();
                    continue;
                }

                bool showErrorMsg = false;
                foreach (AtmUsers user in usersArr)
                {
                    if (parsedCardNumber == user.CardNumber && inputPin == user.CardPin)
                    {
                        LogedInUser = user;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n   WELCOME {user.FullName.ToUpper()}!");
                        Console.ResetColor();
                        showErrorMsg = false;
                        isTrue2 = !isTrue2;
                        break;
                    }
                    else
                    {
                        showErrorMsg = true;
                    }
                }

                if (showErrorMsg)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER THE CORRECT PIN !");
                    Console.ResetColor();
                }
            }
        }


        public void Register(ref AtmUsers[] usersArr)
        {
            Console.WriteLine($"\n      *** REGISTER MENU ***\n");
            long parsedCardNumber = 0;
            int cardPin = 0;


            Console.WriteLine("Enter your full name: ");
            string newUserFullName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\nRegister New Card: ");
                Console.WriteLine(@"Format: ####-####-####-####");
                string inputCardNumber = Console.ReadLine();

                string pattern = "^[1-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$";
                var regexp = new System.Text.RegularExpressions.Regex(pattern);
                bool showErrorMsg = false;

                if (!regexp.IsMatch(inputCardNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER A VALID CARD NUMBER !\n");
                    Console.ResetColor();
                    continue;
                }
                parsedCardNumber = long.Parse(inputCardNumber.Replace("-", ""));

                foreach (AtmUsers user in usersArr)
                {
                    if (user.CardNumber == parsedCardNumber)
                    {
                        showErrorMsg = true;
                        break;
                    }
                }

                if (showErrorMsg)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THAT CARD NUMBER HAS ALREADY BEEN TAKEN!\n");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("\nPlease enter your new Pin: ");
                bool validateInputPin = int.TryParse(Console.ReadLine(), out cardPin);
                if (!validateInputPin)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER VALID PIN !");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    Array.Resize(ref usersArr, usersArr.Length + 1);
                    usersArr[usersArr.Length - 1] = new AtmUsers(newUserFullName, parsedCardNumber, cardPin);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your card has been registered. Please LogIn to validate your account and make a deposit.");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
