using System;

namespace SEDC.Class04.ExtraHomework.Tasks
{
    class Program
    {
        //## Task 1:
        //Create a function to say whether a string is symmetric(a palindrome). For example, "RADAR" is a palindrome.
        public static string PalindromeString(string inputString)
        {
            //Type checkInput = typeof(string);            // just wanted to handle if the user inputs something other than string...
            //if (checkInput == inputString.GetType())
            //{
            //    return "ERROR";
            //}
            inputString = inputString.ToUpper();
            char[] charactersArray = inputString.ToCharArray();
            Array.Reverse(charactersArray);
            string reversedString = new string(charactersArray);

            return inputString == reversedString ? $@"The string ""{inputString}"" is a palindrome." : $@"The string ""{inputString}"" is not a palindrome.";
        }


        //## Task 2:
        //Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.
        public static string TheLargestNumber(double[] numbersArray)
        {
            double max = 0;
            foreach (double number in numbersArray)
            {
                max = Math.Min(0, number);
                // ako go ostavime max 0, a arrayot e sostaven samo od negativni broevi, ke ni vrati 0,
                // vaka go stavame da bide najmaliot broj od nizata
            }
            for (int i = 0; i < numbersArray.Length; i++)
            {
                max = max < numbersArray[i] ? numbersArray[i] : max;
            }

            return $"The largest number is {max}";
        }


        //## Task 3:
        //Create a two function that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains.
        //It will accept one parameter parameter: the string that we want to search,
        //* Function 1 should return the number of digits, 
        //* Function 2 should return the number of vowels. 
        //# Do not name them function1 and 2 :)
        public static string AmountOfDigits(string inputString)
        {
            char[] checkString = inputString.ToCharArray();
            int integerCounter = 0;

            foreach (char item in checkString)
            {
                integerCounter = char.IsDigit(item) ? integerCounter += 1 : integerCounter;
            }

            //char[] digitsArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    foreach (char item in digitsArr)
            //    {
            //        integerCounter = inputString[i] == item ? integerCounter += 1 : integerCounter;
            //    }
            //}

            return $@"The string ""{inputString}"" has {integerCounter} digits.";
        }
        public static string AmountOfVowels(string inputString)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelsCounter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    vowelsCounter = inputString[i] == vowel ? vowelsCounter += 1 : vowelsCounter;
                }
            }

            return $@"The string ""{inputString}"" has {vowelsCounter} vowels.";
        }


        //## Task 4:
        //Create a function to read a sentence from input and replace lowercase characters by uppercase and vice-versa.
        public static string ReplaceLowwerAndUpperCase(string inputString)
        {
            string[] charArray = new string[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] >= 'a' && inputString[i] <= 'z')
                {
                    charArray[i] = inputString[i].ToString().ToUpper();
                }
                else if (inputString[i] >= 'A' && inputString[i] <= 'Z')
                {
                    charArray[i] = inputString[i].ToString().ToLower();
                }
                else
                {
                    charArray[i] = inputString[i].ToString();
                }
            }

            return string.Join("", charArray);
        }


        //## Task 5:
        //Create a function to check whether a character is an alphabet or not and if so go to check for the case.
        public static string CheckCharacter(char charInput)
        {
            string showInfo = string.Empty;

            if (charInput >= 'A' && charInput <= 'Z')
            {
                showInfo = $"The character '{charInput}' is an alphabet and it's uppercased.";
            }
            else if ((charInput >= 'a' && charInput <= 'z'))
            {
                showInfo = $"The character '{charInput}' is an alphabet and it's lowercased.";
            }
            else
            {
                showInfo = $"The character '{charInput}' is not an alphabet.";
            }

            return showInfo;
        }


        //## Task 6:
        //Create a function to find the number of times a substring appears in a given string.
        public static string FindSubstringRepeats(string inputString, string inputSubstring)
        {
            int counter = (inputString.Length - inputString.Replace(inputSubstring, "").Length) / inputSubstring.Length;
            return $@"The substring ""{inputSubstring}"" appears {counter} times in the string ""{inputString}"".";
        }


        //## Task 7:
        //Create a function that calculates the result of raising an integer to another integer (eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125). 
        public static double NumberToPow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }






        static void Main(string[] args)
        {
            Console.WriteLine("\n ================= Extra Homework ================= \n");

            Console.WriteLine("\n========== TASK01 ==========");
            Console.WriteLine(PalindromeString("radar"));
            Console.WriteLine(PalindromeString("radarrr"));
            Console.WriteLine(PalindromeString("1212112121"));
            // Console.WriteLine(PalindromeString(12)); ==> I supose this is an advanced topic 

            Console.WriteLine("\n========== TASK02 ==========");
            Console.WriteLine(TheLargestNumber(new double[] { 234.2423, 234, 234, 111, -123.42, 0, 12, 3333 }));  //3333
            Console.WriteLine(TheLargestNumber(new double[] { -1, -2, -3, -4, -5 }));  //-1
            Console.WriteLine(TheLargestNumber(new double[] { 10, -1 }));  //10

            Console.WriteLine("\n========== TASK03 ==========");
            Console.WriteLine(AmountOfDigits("gdsff 23fd -123.42fsd"));
            Console.WriteLine(AmountOfVowels("gdsff 23fd -123.42fsd"));
            Console.WriteLine(AmountOfDigits("gSDF2fds3 -123aei"));
            Console.WriteLine(AmountOfVowels("gSDF2fds3 -123aei"));

            Console.WriteLine("\n========== TASK04 ==========");
            Console.WriteLine(ReplaceLowwerAndUpperCase("aaBBccDDeeFF"));
            Console.WriteLine(ReplaceLowwerAndUpperCase("lowercased! + UPPERCASED!"));

            Console.WriteLine("\n========== TASK05 ==========");
            Console.WriteLine(CheckCharacter('g'));
            Console.WriteLine(CheckCharacter('G'));
            Console.WriteLine(CheckCharacter('1'));
            Console.WriteLine(CheckCharacter('/'));

            Console.WriteLine("\n========== TASK06 ==========");
            Console.WriteLine(FindSubstringRepeats("Hello Hello", "ll"));
            Console.WriteLine(FindSubstringRepeats("Substring Substring", "ing"));
            Console.WriteLine(FindSubstringRepeats("Substring Substring Substring stri", "stri"));

            Console.WriteLine("\n========== TASK07 ==========");
            Console.WriteLine(NumberToPow(5, 3)); //125
            Console.WriteLine(NumberToPow(2, 3)); //8





            Console.ReadLine();
        }
    }
}
