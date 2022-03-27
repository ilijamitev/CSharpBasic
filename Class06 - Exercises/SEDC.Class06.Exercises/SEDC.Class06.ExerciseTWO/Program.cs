using SEDC.Class06.ExerciseTWO.Models;
using System;

namespace SEDC.Class06.ExerciseTWO
{
    class Program
    {
        public static void LogIn(ref User[] userArray)
        {
            Console.WriteLine("LOG IN");
            while (true)
            {
                Console.WriteLine("Enter username");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("Enter password");
                string inputPassword = Console.ReadLine();

                foreach (User ourUser in userArray)
                {
                    if (inputUsername != ourUser.Username && inputPassword != ourUser.Password)
                    {
                        Console.WriteLine("USER NOT FOUND !");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Welcome {ourUser.Username}. Here are your messages: \n==> {ourUser.Messages[0]}\n==> {ourUser.Messages[1]}");
                        break;
                    }
                }
                break;
            }
        }

        public static void RegisterUser(ref User[] userArr)  // referencira na memorijata kaj sto e vnesenata arr
        {
            Console.WriteLine("REGISTER NEW USER");
            foreach (User userName in userArr)
            {
                while (true)
                {
                    Console.WriteLine("Enter ID");
                    bool isValid = int.TryParse(Console.ReadLine(), out int idInput);
                    Console.WriteLine("Enter username");
                    string inputUsername = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string inputPassword = Console.ReadLine();

                    if (inputUsername != userName.Username && isValid && idInput != userName.Id)
                    {
                        Array.Resize(ref userArr, userArr.Length + 1);
                        userArr[userArr.Length - 1] = new User(idInput, inputUsername, inputPassword, new string[] { $"hi {inputUsername}", "hhh" });
                        foreach (User newUser in userArr)
                        {
                            Console.WriteLine($"{newUser.Id}. {newUser.Username}");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ENTER VALID INFO !");
                        continue;
                    }
                }
                break;
            }
        }

        public static void StartApp()
        {
            User ilija = new User(1, "Ilija", "pass1", new string[] { "hi ilija", "welcome ilija" });
            User vlatko = new User(2, "Vlatko", "pass2", new string[] { "hi vlatko", "welcome vlatko" });
            User kiko = new User(3, "Kiko", "pass3", new string[] { "hi kiko", "welcome kiko" });
            User[] userArray = { ilija, vlatko, kiko };

            while (true)
            {
                Console.WriteLine("\nPlease select option: \n1)LOGIN \n2)REGISTER \n3)EXIT");
                string startMenu = Console.ReadLine();

                if (startMenu == "1")
                {
                    LogIn(ref userArray);
                }
                else if (startMenu == "2")
                {
                    RegisterUser(ref userArray);
                }
                else if (startMenu == "3")
                {
                    Console.Clear();
                    Console.WriteLine("BYE BYE");
                    break;
                }
            }
        }


        static void Main(string[] args)
        {
            StartApp();
        }
    }
}
