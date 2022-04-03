using AcademyManagment.Models;
using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.MembersDatabase;
using AcademyManagment.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyManagment.Service.ManagmentServices
{
    public class LogInService
    {

        public static Person UserLogin(string loginChoice)
        {
            string fullName = string.Empty;
            int password = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Full Name :");
                    fullName = Console.ReadLine();
                    if (loginChoice == "1")
                    {
                        if (!AdminService.FindAdminName(fullName))
                        {
                            HelperService.ThrowException("NO ADMIN BY THAT NAME. TRY AGAIN!\n");
                        }
                        break;
                    }
                    else if (loginChoice == "2")
                    {
                        if (!TrainerService.FindTrainer(fullName))
                        {
                            HelperService.ThrowException("NO TRAINER BY THAT NAME. TRY AGAIN!\n");
                        }
                        break;
                    }
                    else if (loginChoice == "3")
                    {
                        if (!StudentService.FindStudent(fullName))
                        {
                            HelperService.ThrowException("NO STUDENT BY THAT NAME. TRY AGAIN!\n");
                        }
                        break;
                    }
                }
                catch (ArgumentNullException)
                {
                    HelperService.ShowErrorMessage("PLEASE ENTER A VALUE!");
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Password :");
                    password = int.Parse(Console.ReadLine());
                    if (loginChoice == "1")
                    {
                        if (!AdminService.FindAdminPassword(password))
                        {
                            HelperService.ThrowException("INCORRECT PASSWORD. TRY AGAIN !\n");
                        }
                        break;
                    }
                    else if (loginChoice == "2")
                    {
                        if (!TrainerService.FindTrainerPassword(password))
                        {
                            HelperService.ThrowException("INCORRECT PASSWORD. TRY AGAIN !\n");
                        }
                        break;
                    }
                    else if (loginChoice == "3")
                    {
                        if (!StudentService.FindStudentPassword(password))
                        {
                            HelperService.ThrowException("INCORRECT PASSWORD. TRY AGAIN !\n");
                        }
                        break;
                    }
                }
                catch (ArgumentNullException)
                {
                    HelperService.ShowErrorMessage("PLEASE ENTER A VALUE!");
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }


            if (loginChoice == "1")
            {
                Admin loggedInAdmin = AcademyMembers.AdminList.First(x => x.FullName == fullName && x.Password == password);
                loggedInAdmin.IsLoggedIn = true;
                HelperService.ShowApprovalMessage($"\n        Welcome Admin {loggedInAdmin.FullName}!\n");
                return loggedInAdmin;
            }
            else if (loginChoice == "2")
            {
                Trainer loggedInTrainer = AcademyMembers.TrainerList.First(x => x.FullName == fullName && x.Password == password);
                loggedInTrainer.IsLoggedIn = true;
                HelperService.ShowApprovalMessage($"\n        Welcome Trainer {loggedInTrainer.FullName}!\n");
                return loggedInTrainer;
            }
            else
            {
                Student loggedInStudent = AcademyMembers.StudentList.First(x => x.FullName == fullName && x.Password == password);
                loggedInStudent.IsLoggedIn = true;
                HelperService.ShowApprovalMessage($"\n        Welcome Student {loggedInStudent.FullName}!\n");
                return loggedInStudent;
            }
        }

















    }
}
