using System;

namespace SEDC.Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ RealCalculator ============");
            Console.WriteLine("");

            Console.WriteLine("Please enter the FIRST Number");
            bool validateFirstNum = double.TryParse(Console.ReadLine(), out double firstNum);
            Console.WriteLine("Please enter the SECOND Number");
            bool validateSecondNum = double.TryParse(Console.ReadLine(), out double secondNum);


            double result = 0;

            if (validateFirstNum && validateSecondNum)
            {
                Console.WriteLine("Please select operation by typing '+,-,* or /'");
                string operatorInput = Console.ReadLine();

                switch (operatorInput)
                {
                    case "+":
                        result = firstNum + secondNum;
                        //Console.WriteLine("The result of " + firstNum + " " + operatorInput + " " + secondNum + " is " + result);
                        Console.WriteLine($"The result of {firstNum} {operatorInput} {secondNum} is {result}");
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        Console.WriteLine($"The result of {firstNum} {operatorInput} {secondNum} is {result}");
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        Console.WriteLine($"The result of {firstNum} {operatorInput} {secondNum} is {result}");
                        break;
                    case "/":
                        if (secondNum == 0)
                        {
                            Console.WriteLine("YOU CANNOT DIVIDE BY ZERO !");
                            break;
                        }
                        result = firstNum / secondNum;
                        Console.WriteLine($"The result of {firstNum} {operatorInput} {secondNum} is {result}");
                        break;
                    default:
                        Console.WriteLine("ENTER A VALID OPERATOR !");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ENTER VALID NUMBERS !");
            }



        }
    }
}
