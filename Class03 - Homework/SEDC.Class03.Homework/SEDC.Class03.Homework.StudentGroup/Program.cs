using System;

namespace SEDC.Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n============= StudentGroup =============\n");

            string[] studentsG1 = { "Ilija", "Kristijan", "Stefan", "Maja", "Aneta" };
            string[] studentsG2 = { "Marija", "Aleksandar", "Krale", "Slave", "Igor" };
            bool isTrue = true;

            Array.Sort(studentsG1);
            Array.Sort(studentsG2);

            while (isTrue)
            {
                Console.WriteLine("Enter student group (1 or 2)");
                string selectedGroup = Console.ReadLine();

                if (selectedGroup == "1")
                {
                    isTrue = !isTrue;
                    Console.WriteLine("\n The students in G1 are:\n");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine($" => {student}\n");
                    }
                }
                else if (selectedGroup == "2")
                {
                    isTrue = !isTrue;
                    Console.WriteLine("\n The students in G2 are:\n");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine($" => {student}\n");
                    }
                }
                else
                {
                    Console.WriteLine("PLEASE SELECT 1 OR 2 !");
                }

            }

            Console.ReadLine();
        }
    }
}
