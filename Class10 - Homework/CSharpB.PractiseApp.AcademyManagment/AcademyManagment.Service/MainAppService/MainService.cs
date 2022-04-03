using AcademyManagment.Models;
using AcademyManagment.Models.BaseModel;
using AcademyManagment.Service.Helpers;
using AcademyManagment.Service.ManagmentServices;
using AcademyManagment.Service.ValidationServices;
using System;

namespace AcademyManagment.Service.MainAppService
{
    public class MainService
    {
        public static void StartApp()
        {
            bool isTrue = true;
            while (isTrue)
            {
                HelperService.ShowApplicationMessages("\n   LOG IN AS:\n1.Admin\n2.Trainer\n3.Student\n4.Exit\n*enter the number.");
                string loginChoice = InputService.GetValidInput(new string[] { "1", "2", "3", "4" });

                switch (loginChoice)
                {
                    case "1":
                        AdminMenu("1");
                        break;
                    case "2":
                        TrainerMenu("2");
                        break;
                    case "3":
                        StudentMenu("3");
                        break;
                    case "4":
                        isTrue = !isTrue;
                        break;
                }

            }

            // Showing all members only to check wether the app is working okay...
            HelperService.ShowAllAcademyMembers();
            Console.ReadLine();

            Console.Clear();
            HelperService.ShowApplicationMessages("\n\n\n\n\n\n\n                   *** THANK YOU FOR USING OUR APP ***");
            Console.ReadLine();

        }


        public static void AdminMenu(string inputChoice)
        {
            Admin logedAdmin = (Admin)LogInService.UserLogin(inputChoice);  // EXPLICIT CONVERSION ...(Admin)
            while (true)
            {
                HelperService.ShowApplicationMessages("Select your action: \n1.ADD:\n  => Admin\n  => Trainer\n  => Student \n\n2.REMOVE:\n  => Admin\n  => Trainer\n  => Student \n\n*Ex. Enter 1-1 to add Admin or 2-1 to remove Admin*");
                string selectedOption = InputService.GetValidInput(new string[] { "1-1", "1-2", "1-3", "2-1", "2-2", "2-3" });
                string findRole = string.Empty;
                findRole = selectedOption == "1-1" || selectedOption == "2-1" ? "Admin" : findRole;
                findRole = selectedOption == "1-2" || selectedOption == "2-2" ? "Trainer" : findRole;
                findRole = selectedOption == "1-3" || selectedOption == "2-3" ? "Student" : findRole;

                if (selectedOption == "1-1" || selectedOption == "1-2" || selectedOption == "1-3")
                {
                    if (selectedOption == "1-1")
                    {
                        Person newPerson = AdminService.CreatePerson(findRole);
                        AdminService.AddPerson(selectedOption, newPerson.FullName, newPerson.Password);
                        HelperService.ShowApprovalMessage($"The Admin {newPerson.FullName} has been successfully added.");
                    }
                    else if (selectedOption == "1-2")
                    {
                        Person newPerson = AdminService.CreatePerson(findRole);
                        AdminService.AddPerson(selectedOption, newPerson.FullName, newPerson.Password);
                        HelperService.ShowApprovalMessage($"The Trainer {newPerson.FullName} has been successfully added.");
                    }
                    else if (selectedOption == "1-3")
                    {
                        Person newPerson = AdminService.CreatePerson(findRole);
                        AdminService.AddPerson(selectedOption, newPerson.FullName, newPerson.Password);
                        HelperService.ShowApprovalMessage($"The Student {newPerson.FullName} has been successfully added.");
                    }
                }
                else if (selectedOption == "2-1" || selectedOption == "2-2" || selectedOption == "2-3")
                {
                    while (true)
                    {
                        try
                        {
                            if (selectedOption == "2-1")
                            {
                                Person newPerson = AdminService.CreatePerson(findRole, true);
                                if (newPerson.FullName == logedAdmin.FullName && newPerson.Password == logedAdmin.Password)
                                {
                                    HelperService.ThrowException("YOU CANNOT REMOVE YOURSELF. TRY AGAIN!");
                                }
                                AdminService.RemovePerson(selectedOption, newPerson.FullName, newPerson.Password);
                                HelperService.ShowApprovalMessage($"The Admin {newPerson.FullName} has been successfully removed.");
                                break;
                            }
                            else if (selectedOption == "2-2")
                            {
                                Person newPerson = AdminService.CreatePerson(findRole, true);
                                AdminService.RemovePerson(selectedOption, newPerson.FullName, newPerson.Password);
                                HelperService.ShowApprovalMessage($"The Trainer {newPerson.FullName} has been successfully removed.");
                                break;
                            }
                            else if (selectedOption == "2-3")
                            {
                                Person newPerson = AdminService.CreatePerson(findRole, true);
                                AdminService.RemovePerson(selectedOption, newPerson.FullName, newPerson.Password);
                                HelperService.ShowApprovalMessage($"The Student {newPerson.FullName} has been successfully removed.");
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            HelperService.ShowErrorMessage(ex.Message);
                        }
                    }
                }


                if (LogOutMenu())
                {
                    HelperService.ShowApprovalMessage($"Bye bye {logedAdmin.FullName}.");
                    logedAdmin.IsLoggedIn = false;
                    break;
                }
            }
        }


        public static void TrainerMenu(string inputChoice)
        {
            Trainer logedTrainer = (Trainer)LogInService.UserLogin(inputChoice);

            while (true)
            {
                HelperService.ShowApplicationMessages("     Choose an option:\n1.Show Students\n2.Show Subjects");
                string selectedOption = InputService.GetValidInput(new string[] { "1", "2" });

                if (selectedOption == "1")
                {
                    HelperService.ShowStudents();
                    HelperService.ShowApplicationMessages("Enter Student's full name: ");
                    TrainerService.PrintStudentSubjects();
                    if (LogOutMenu())
                    {
                        HelperService.ShowApprovalMessage($"Bye bye {logedTrainer.FullName}.");
                        logedTrainer.IsLoggedIn = false;
                        break;
                    }
                }
                else if (selectedOption == "2")
                {
                    TrainerService.PrintSubjectsAndAttendants();
                    if (LogOutMenu())
                    {
                        HelperService.ShowApprovalMessage($"Bye bye {logedTrainer.FullName}.");
                        logedTrainer.IsLoggedIn = false;
                        break;
                    }
                }
            }
        }


        public static void StudentMenu(string inputChoice)
        {
            Student logedStudent = (Student)LogInService.UserLogin(inputChoice);

            try
            {
                if (logedStudent.SubjectList == null)
                {
                    HelperService.ThrowException($"You haven't been assigned to any subject yet.");
                }
                HelperService.ShowStudentSubjects(logedStudent);
                HelperService.ShowApplicationMessages("\nPress any key to logout!");
                Console.ReadLine();
                HelperService.ShowApprovalMessage($"Bye bye {logedStudent.FullName}.");
                logedStudent.IsLoggedIn = false;
            }
            catch (Exception ex)
            {
                HelperService.ShowErrorMessage(ex.Message);
                HelperService.ShowApplicationMessages("\nPress any key to logout!");
                Console.ReadLine();
            }

        }


        public static bool LogOutMenu()
        {
            HelperService.ShowApplicationMessages("\n   Select Option:\n1.Perform another action\n2.Logout");
            string selectedOption = InputService.GetValidInput(new string[] { "1", "2" });
            if (selectedOption == "1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }









    }
}
