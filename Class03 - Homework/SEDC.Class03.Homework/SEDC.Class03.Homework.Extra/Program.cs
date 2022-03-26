using System;

namespace SEDC.Class03.Homework.Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ========== Creating Array In Array ========== ");

            int[][] intArray = new int[4][];

            intArray[0] = new int[2] { 1, 2 };
            intArray[1] = new int[2] { 3, 4 };
            intArray[2] = new int[2] { 5, 6 };
            intArray[3] = new int[2] { 7, 8 };

            Console.WriteLine($"The items in index 2 ===> {intArray[2]}\n");  // System.Int32[]  vrakja vaka zosto treba da se iziterira (niza e)

            foreach (int item in intArray[2])
            {
                Console.WriteLine($"This way with foreach is okay ==> {item}\n");
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                foreach (int item in intArray[i])
                {
                    Console.WriteLine($"{item}\n");
                }
            }



            Console.WriteLine("\n ========== Task 01 ========== \n");
            /*
               Make a new console application.
               Create an array of 10 whole numbers (integers).
               Find the minimum and maximum and print them in the console.
            */

            //int[] numArray = { -25, 0, 0, 20, 0, 0, 0, 0, 0, 1 };
            //int[] numArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] numArray = { 1, 124, 23, 23, -123, -23, 15, 2, 333, 3 };
            int max = 0;
            int min = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                //max = numArray[i] > max ? max = numArray[i] : max;    // nemora da stoi  max =  posle prasalnikot
                max = numArray[i] > max ? numArray[i] : max;
                min = numArray[i] < min ? numArray[i] : min;
            }

            if (max == min)
            {
                Console.WriteLine("Both of the numbers are equal, neither max nor min.");
            }
            else
            {
                Console.WriteLine($" The max number in the array is {max}.\n The min number is {min}.");
            }




            Console.ReadLine();
        }
    }
}
