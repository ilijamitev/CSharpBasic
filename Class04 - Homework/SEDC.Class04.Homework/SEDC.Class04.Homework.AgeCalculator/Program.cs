using System;

namespace SEDC.Class04.Homework.AgeCalculator
{
    class Program
    {
        //Homework Class 4 📒

        //Make a method called AgeCalculator
        //The method will have one input parameter, your birthday date
        //The method should return your age
        //Show the age of a user after he inputs a date
        //Note: take into consideration if the birthday is today, after or before today

        public static string AgeCalculator(DateTime inputDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Subtract(inputDate).Days / 365;
            string showAge = string.Empty;

            if (age > 120 || age < 0)
            {
                showAge = $"STOP LYING. YOU AREN'T {age} YEARS OLD !";
            }
            else if (currentDate.Day == inputDate.Day && currentDate.Month == inputDate.Month)
            {
                showAge = $"HAPPY BIRTHDAY TO YOU! You are {age} years old as of today. BE AWESOME !!!";
            }
            else if (currentDate.Day - 1 == inputDate.Day)
            {
                showAge = $"Happy yesterday's birthday! You've turned {age}. Good for you :D";
            }
            else if (currentDate.Day + 1 == inputDate.Day)
            {
                showAge = $"Tomorrow is a big day for you! You are turning {age} years.";
            }
            else
            {
                showAge = $"You are {age} years old.";
            }

            return showAge;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n ========== AgeCalculator ========== \n");

            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("\n\n ENTER YOUR BIRTH DATE IN ONE OF THE FOLLOWING FORMATS:\n MM/dd/yyyy\n MM.dd.yyyy\n MM/dd/yy\n To exit app press \"E\"");
                string dateInput = Console.ReadLine();
                bool checkInputDate = DateTime.TryParse(dateInput, out DateTime birthDate);

                if (checkInputDate)
                {
                    Console.WriteLine($"\n{AgeCalculator(birthDate)}");
                    Console.ReadLine();
                }
                else if (dateInput.ToUpper() == "E")
                {
                    isTrue = !isTrue;
                }
                else
                {
                    Console.WriteLine("\nPLEASE ENTER A VALID DATE !");
                }
            }


            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n          *** Thank you for using our AgeCalculator app ***\n\n\n\n\n\n\n");
            Console.ReadLine();
        }
    }
}
