using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Class08.NumbersQueue
{
    class Program
    {
        /*
                    Homework Class 8 📒
            Task 1
            Give the user an option to input numbers
            After inputing each number ask them if they want to input another with a Y/N question
            Store all numbers in a QUEUE
            When the user is done adding numbers print the number in the order that the user entered them from the QUEUE
          
         */
        static void Main(string[] args)
        {
            Console.WriteLine("============== Homework Class08 =============");

            Queue<int> numbersQueue = new Queue<int>();

            while (true)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER: ");
                string inputNumber = Console.ReadLine();
                bool isValidNumber = int.TryParse(inputNumber, out int parsedNumber);

                if (isValidNumber)
                {
                    numbersQueue.Enqueue(parsedNumber);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ENTER VALID NUMBER!");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine("Enter another (Y). Exit app (N).");
                string inputChoice = Console.ReadLine();

                if (inputChoice == "N".ToLower())
                {
                    break;
                }
                else
                {
                    continue;
                }

            }

            Console.Clear();
            Console.WriteLine("==== Entered numbers ====");
            foreach (int number in numbersQueue)
            {
                Console.WriteLine(number);
            }






            Console.ReadLine();
        }

    }
}
