using System;

namespace SEDC.Class02.Homework.FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ FindStatistics (extra homework) ============");
            Console.WriteLine("");
            //Create new console application “FindStatistics”. Input 2 numbers. If the two of them are even, print their sum, if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result, but also the whole operation. Treat zero as even. Please find example below:
            //Test Data:
            //Input the First Number: 8
            //Input the Second Number: 5
            //Expected Output:
            //One of the numbers is odd.The operation and result are 8 - 5 = 3.

            Console.WriteLine("Enter the FIRST number");
            bool validateFirstNum = int.TryParse(Console.ReadLine(), out int firstNum);
            Console.WriteLine("Enter the SECOND number");
            bool validateSecondNum = int.TryParse(Console.ReadLine(), out int secondNum);
            Console.WriteLine("");

            if (validateFirstNum && validateSecondNum)
            {
                if (firstNum % 2 == 0 && secondNum % 2 == 0)
                {
                    Console.WriteLine($"Both even: {firstNum} + {secondNum} = {firstNum + secondNum}");
                }
                else if (firstNum % 2 == 0 || secondNum % 2 == 0)
                {
                    Console.WriteLine($"One even, one odd: {firstNum} - {secondNum} = {firstNum - secondNum}");
                }
                else
                {
                    Console.WriteLine($"Both odd: {firstNum} * {secondNum} = {firstNum * secondNum}");
                }
            }
            else
            {
                Console.WriteLine("ENTER VALID NUMBERS !!!");
            }

            Console.ReadLine();
        }
    }
}
