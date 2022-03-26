using System;

namespace SEDC.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n============= SumOfEven =============\n");

            int numberOfInputs = 6;
            int[] integerArray = new int[numberOfInputs];
            int result = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.WriteLine($"Enter Integer Number {i + 1}");
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out int numberInput);

                if (checkInput)
                {
                    integerArray[i] = numberInput;
                    result = integerArray[i] % 2 == 0 ? result += integerArray[i] : result;
                }
                else
                {
                    i--;  
                    Console.WriteLine("ENTER VALID INTEGER !");
                }
            }

            Console.WriteLine($"\nThe result is {result}.");

            Console.ReadLine();
        }
    }
}
