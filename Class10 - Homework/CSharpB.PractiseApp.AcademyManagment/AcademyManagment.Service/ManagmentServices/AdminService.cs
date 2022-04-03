using AcademyManagment.Models;
using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.Enums;
using AcademyManagment.Models.MembersDatabase;
using AcademyManagment.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyManagment.Service.ManagmentServices
{
    public class AdminService
    {

        public static void AddPerson(string inputChoise, string fullName, int password)
        {
            switch (inputChoise)
            {
                case "1-1":
                    AcademyMembers.AdminList.Add(new Admin(fullName, password));
                    break;
                case "1-2":
                    AcademyMembers.TrainerList.Add(new Trainer(fullName, password));
                    break;
                case "1-3":
                    AcademyMembers.StudentList.Add(new Student(fullName, password));
                    break;
            }
        }

        public static void RemovePerson(string inputChoise, string fullName, int password)
        {
            switch (inputChoise)
            {
                case "2-1":
                    for (int i = 0; i < AcademyMembers.AdminList.Count; i++)
                    {
                        if (AcademyMembers.AdminList[i].FullName == fullName && AcademyMembers.AdminList[i].Password == password)
                        {
                            AcademyMembers.AdminList.Remove(AcademyMembers.AdminList[i]);
                        }
                    }
                    break;
                case "2-2":
                    for (int i = 0; i < AcademyMembers.TrainerList.Count; i++)
                    {
                        if (AcademyMembers.TrainerList[i].FullName == fullName && AcademyMembers.TrainerList[i].Password == password)
                        {
                            AcademyMembers.TrainerList.Remove(AcademyMembers.TrainerList[i]);
                        }
                    }
                    break;
                case "2-3":
                    for (int i = 0; i < AcademyMembers.TrainerList.Count; i++)
                    {
                        if (AcademyMembers.StudentList[i].FullName == fullName && AcademyMembers.StudentList[i].Password == password)
                        {
                            AcademyMembers.StudentList.Remove(AcademyMembers.StudentList[i]);
                        }
                    }
                    break;
            }
        }

        public static bool FindAdminName(string fullName)
        {
            return AcademyMembers.AdminList.Exists(x => x.FullName == fullName);
        }

        public static bool FindAdminPassword(int password)
        {
            return AcademyMembers.AdminList.Exists(x => x.Password == password);
        }


        public static Person CreatePerson(string choosenOption = "Admin", bool removePerson = false)
        {
            string inputName = string.Empty;
            int inputPassword = 0;

            while (true)
            {
                try
                {
                    HelperService.ShowApplicationMessages("Enter Full Name :");
                    inputName = Console.ReadLine();
                    if (choosenOption == "Admin")
                    {
                        if (removePerson && FindAdminName(inputName))
                        {
                            break;
                        }
                        else if (removePerson && !FindAdminName(inputName))
                        {
                            HelperService.ThrowException("NO ADMIN WITH THAT NAME FOUND!");
                        }
                        else if (FindAdminName(inputName))
                        {
                            HelperService.ThrowException("THERE IS ALREADY AN ADMIN WITH THAT NAME! TRY AGAIN.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (choosenOption == "Trainer")
                    {
                        if (removePerson && TrainerService.FindTrainer(inputName))
                        {
                            break;
                        }
                        else if (removePerson && !TrainerService.FindTrainer(inputName))
                        {
                            HelperService.ThrowException("NO TRAINER WITH THAT NAME FOUND!");
                        }
                        else if (TrainerService.FindTrainer(inputName))
                        {
                            HelperService.ThrowException("THERE IS ALREADY A TRAINER WITH THAT NAME! TRY AGAIN.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (choosenOption == "Student")
                    {
                        if (removePerson && StudentService.FindStudent(inputName))
                        {
                            break;
                        }
                        else if (removePerson && !StudentService.FindStudent(inputName))
                        {
                            HelperService.ThrowException("NO STUDENT WITH THAT NAME FOUND!");
                        }
                        else if (StudentService.FindStudent(inputName))
                        {
                            HelperService.ThrowException("THERE IS ALREADY A STUDENT WITH THAT NAME! TRY AGAIN.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentNullException)       // zosto ne mi go fakja ovoj error...koga ke se vnese samo space da dava greska !!!
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
                    HelperService.ShowApplicationMessages("Enter Password :");
                    inputPassword = int.Parse(Console.ReadLine());
                    if (removePerson)
                    {
                        if (choosenOption == "Admin" && !AdminService.FindAdminPassword(inputPassword))
                        {
                            HelperService.ThrowException("ENTER A CORRECT PASSWORD!");
                        }
                        else if (choosenOption == "Trainer" && !TrainerService.FindTrainerPassword(inputPassword))
                        {
                            HelperService.ThrowException("ENTER A CORRECT PASSWORD!");
                        }
                        else if (choosenOption == "Student" && !StudentService.FindStudentPassword(inputPassword))
                        {
                            HelperService.ThrowException("ENTER A CORRECT PASSWORD!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentNullException)
                {
                    HelperService.ShowErrorMessage("PLEASE ENTER A VALUE!");
                }
                catch (FormatException)
                {
                    HelperService.ShowErrorMessage("ENTER A VALID INTEGER!");
                }
                catch (OverflowException)
                {
                    HelperService.ShowErrorMessage("ENTER A SMALLER INTEGER!");
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }

            return new Person(inputName, inputPassword);
        }


    }
}
