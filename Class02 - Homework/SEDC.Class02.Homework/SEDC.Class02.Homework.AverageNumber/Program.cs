using System;

namespace SEDC.Class02.Homework.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ AverageNumber ============");
            Console.WriteLine("");

            Console.WriteLine("Please enter the FIRST Number");
            string firstNumInput = Console.ReadLine();
            Console.WriteLine("Please enter the SECOND Number");
            string secondNumInput = Console.ReadLine();
            Console.WriteLine("Please enter the THIRD Number");
            string thirdNumInput = Console.ReadLine();
            Console.WriteLine("Please enter the FOURTH Number");
            string fourthNumInput = Console.ReadLine();

            bool validateFirstNum = double.TryParse(firstNumInput, out double firstNum);
            bool validateSecondNum = double.TryParse(secondNumInput, out double secondNum);
            bool validateThirdNum = double.TryParse(thirdNumInput, out double thirdNum);
            bool validateFourthNum = double.TryParse(fourthNumInput, out double fourthNum);

            if (validateFirstNum && validateSecondNum && validateThirdNum && validateFourthNum)
            {
                double result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
                Console.WriteLine("The average of " + firstNum + ", " + secondNum + ", " + thirdNum + " and " + fourthNum + " is " + result);
            }
            else
            {
                Console.WriteLine("ENTER VALID NUMBERS !");
            }



        }
    }
}
