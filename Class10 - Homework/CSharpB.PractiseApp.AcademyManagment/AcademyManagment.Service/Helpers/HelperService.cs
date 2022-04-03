using AcademyManagment.Models;
using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.MembersDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Service.Helpers
{
    public class HelperService
    {
        public static void ShowErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowApprovalMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowApplicationMessages(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ShowInformation(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ThrowException(string text)
        {
            throw new Exception(text);
        }



        public static void ShowAdmins()
        {
            for (int i = 0; i < AcademyMembers.AdminList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{i + 1}. {AcademyMembers.AdminList[i].FullName}");
                Console.ResetColor();
            }
        }

        public static void ShowTrainers()
        {
            for (int i = 0; i < AcademyMembers.TrainerList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{i + 1}. {AcademyMembers.TrainerList[i].FullName}");
                Console.ResetColor();
            }
        }

        public static void ShowStudents()
        {
            for (int i = 0; i < AcademyMembers.StudentList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{i + 1}. {AcademyMembers.StudentList[i].FullName}");
                Console.ResetColor();
            }
        }

        public static void ShowAllAcademyMembers()
        {
            Console.WriteLine("\nADMINS\n");
            HelperService.ShowAdmins();
            Console.WriteLine("\nTRAINERS\n");
            HelperService.ShowTrainers();
            Console.WriteLine("\nSTUDENTS\n");
            HelperService.ShowStudents();
        }

        public static void ShowStudentSubjects(Student student)
        {
            string currentSubject = string.Empty;
            for (int i = 0; i < student.SubjectList.Count; i++)
            {
                if (student.SubjectList[i].CurrentSubject)
                {
                    currentSubject = student.SubjectList[i].Subject.ToString();
                    break;
                }
                else
                {
                    currentSubject = "Not available!";
                }
            }
            for (int i = 0; i < student.SubjectList.Count; i++)
            {
                ShowInformation($"{i + 1}. {student.SubjectList[i].Subject} \n==>Grade: {student.SubjectList[i].SubjectGrade} \n");
            }
            ShowInformation($"Current subject: {currentSubject}.");
        }











    }



}
