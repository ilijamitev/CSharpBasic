using System;

namespace SEDC.Class06.ExerciseONE
{
    class Program
    {

        public static string NumberStats(double inputNumber)
        {
            string isPositive = inputNumber > 0 ? "positive" : "negative";
            string oddOrEven = inputNumber % 2 == 0 ? "even" : "odd";
            string decimalOrInteger = inputNumber % 1 != 0 ? "decimal" : "integer";

            return $"The number entered {inputNumber} is {isPositive}, {oddOrEven} and {decimalOrInteger}";
        }


        public static void StartApp()
        {
            while (true)
            {
                Console.WriteLine("Enter a number to check the stats");
                bool isValidate = double.TryParse(Console.ReadLine(), out double inputNum);
                if (isValidate)
                {
                    Console.WriteLine(NumberStats(inputNum));
                    break;
                }
                else
                {
                    Console.WriteLine("ENTER A VALID NUMBER");
                    continue;
                }
            }
        }


        static void Main(string[] args)
        {
            StartApp();

            while (true)
            {
                Console.WriteLine("Select Y to try again and X to exit !");
                string endMenu = Console.ReadLine();

                if (endMenu == "Y")
                {
                    StartApp();
                }
                else if (endMenu == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using our app");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("SELECT VALID OPTION !");
                }
            }
        }
    }
}
