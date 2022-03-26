using System;


namespace SEDC.Clas05.ExtraHome.GuessTheNumber
{
    class Program
    {
        public static void GuessNumber(int playMode, int numOfTries)
        {
            int randomNumber = new Random().Next(0, playMode);
            Console.WriteLine(randomNumber);
            for (int i = 0; i < numOfTries; i++)
            {
                Console.WriteLine($"\n*** It's your {i + 1} try. Please enter a number !");
                bool validateInput = int.TryParse(Console.ReadLine(), out int inputNumber);
                if (validateInput)
                {
                    if ((i == 0) && (inputNumber == randomNumber))
                    {
                        Console.WriteLine($"YOU SHOULD PLAY LOTO! Good job you guessed the number in your first try.\nEntered number: {inputNumber}.\nGuessing number: {randomNumber}.");
                        break;
                    }
                    else if (inputNumber == randomNumber)
                    {
                        Console.WriteLine($"NAILED IT!\nNumber entered: {inputNumber}.\nGuessing number: {randomNumber}.");
                        break;
                    }
                    else if (i == numOfTries - 1)
                    {
                        Console.WriteLine($"SORRY, NO LUCK THIS TIME! THE NUMBER WAS {randomNumber}.");
                        break;
                    }
                    else if (inputNumber > randomNumber)
                    {
                        if (inputNumber >= randomNumber + 10)
                        {
                            Console.WriteLine($"Your number {inputNumber} is far too high. Try again!");
                        }
                        else if (inputNumber >= randomNumber + 1)
                        {
                            Console.WriteLine($"Your number {inputNumber} is little bit higher. Try again!");
                        }
                    }
                    else if (inputNumber < randomNumber)
                    {
                        if (inputNumber <= randomNumber - 10)
                        {
                            Console.WriteLine($"Your number {inputNumber} is far too low. Try again!");
                        }
                        else if (inputNumber <= randomNumber - 1)
                        {
                            Console.WriteLine($"Your number {inputNumber} is little bit lower. Try again!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ENTER VALID NUMBER !");
                    i--;
                }
            }
        }


        public static void StartGame()
        {
            bool appFlow = true;
            while (appFlow)
            {
                Console.WriteLine("  \nPlease select difficulty : \n 1.Easy \n 2.Normal \n 3.Hard \n*enter the number");
                string selectedDifficulty = Console.ReadLine();

                switch (selectedDifficulty)
                {
                    case "1":
                        Console.WriteLine(" ===> YOU'VE SELECTED THE *EASY* MODE. YOU HAVE 9 TRIES TO GUESS THE NUMBER FROM 0 TO 100!");
                        GuessNumber(100, 9);
                        appFlow = !appFlow;
                        break;
                    case "2":
                        Console.WriteLine(" ===> YOU'VE SELECTED THE *NORMAL* MODE. YOU HAVE 7 TRIES TO GUESS THE NUMBER FROM 0 TO 500!");
                        GuessNumber(500, 7);
                        appFlow = !appFlow;
                        break;
                    case "3":
                        Console.WriteLine(" ===> YOU'VE SELECTED THE *HARD* MODE. YOU HAVE 5 TRIES TO GUESS THE NUMBER FROM 0 TO 1000!");
                        GuessNumber(1000, 5);
                        appFlow = !appFlow;
                        break;
                    default:
                        Console.WriteLine("SELECT VALID OPTION !");
                        break;
                }
            }
        }



        static void Main(string[] args)
        {
            Console.Title = "   *** GUESS THE NUMBER ***";
            Console.WriteLine("  *** Welcome to GuessTheNumber ***");
            StartGame();
            Console.ReadLine();

            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("\n\n Press 1 to start a new game, press 2 to quit game !");
                string endingMenu = Console.ReadLine();
                if (endingMenu == "1")
                {
                    StartGame();
                }
                else if (endingMenu == "2")
                {
                    isTrue = !isTrue;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n               * * *  THANK YOU FOR PLAYING OUR GAME, SEE YOU SOON !  * * *");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("SELECT VALID OPTION !");
                }
            }



            //Console.ReadLine();
        }
    }
}
