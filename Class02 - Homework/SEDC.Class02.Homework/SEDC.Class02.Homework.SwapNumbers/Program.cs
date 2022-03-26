using System;

namespace SEDC.Class02.Homework.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ SwapNumbers ============");
            Console.WriteLine("");

            Console.WriteLine("Please enter the FIRST Number");
            string firstNumInput = Console.ReadLine();
            Console.WriteLine("Please enter the SECOND Number");
            string secondNumInput = Console.ReadLine();

            bool validateFirstNum = double.TryParse(firstNumInput, out double firstNum);
            bool validateSecondNum = double.TryParse(secondNumInput, out double secondNum);

            if (validateFirstNum && validateSecondNum)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("First number: " + firstNum);
                Console.WriteLine("Second number: " + secondNum);
                Console.WriteLine("");

                //  [firstNum,secondNum] = [secondNum,firstNum];      MISS JAVASCRIPT ALREADY ?!?!  :D

                double holdThis = firstNum;
                firstNum = secondNum;
                secondNum = holdThis;

                Console.WriteLine("After swapping: ");
                Console.WriteLine("First number: " + firstNum);
                Console.WriteLine("Second number: " + secondNum);
            }
            else
            {
                Console.WriteLine("ENTER VALID NUMBERS !");
            }



        }
    }
}
