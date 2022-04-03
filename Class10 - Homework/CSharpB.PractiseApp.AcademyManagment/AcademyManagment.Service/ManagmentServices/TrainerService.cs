using AcademyManagment.Models;
using AcademyManagment.Models.Enums;
using AcademyManagment.Models.MembersDatabase;
using AcademyManagment.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Service.ManagmentServices
{
    public class TrainerService
    {
        public static bool FindTrainer(string fullName)
        {
            return AcademyMembers.TrainerList.Exists(x => x.FullName == fullName);
        }

        public static bool FindTrainerPassword(int password)
        {
            return AcademyMembers.TrainerList.Exists(x => x.Password == password);
        }

        public static Student GetStudent()
        {
            while (true)
            {
                try
                {
                    string studentNameInput = Console.ReadLine();
                    if (!StudentService.FindStudent(studentNameInput))
                    {
                        HelperService.ThrowException("NO STUDENT WITH THAT NAME! Try again.");
                    }
                    for (int i = 0; i < AcademyMembers.StudentList.Count; i++)
                    {
                        if (AcademyMembers.StudentList[i].FullName == studentNameInput)
                        {
                            return AcademyMembers.StudentList[i];
                        }
                    }
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }

            }
        }

        public static void PrintStudentSubjects()
        {
            try
            {
                Student selectedStudent = GetStudent();
                if (selectedStudent.SubjectList == null)            // Empty collection == null !!!!
                {
                    HelperService.ThrowException("THERE AREN'T ANY ASSIGNED SUBJECTS YET.");
                }
                else
                {
                    HelperService.ShowStudentSubjects(selectedStudent);
                }
            }
            catch (Exception ex)
            {
                HelperService.ShowErrorMessage(ex.Message);
            }
        }


        public static void PrintSubjectsAndAttendants()
        {
            int htmlCounter = 0;
            int cssCounter = 0;
            int basicJS = 0;
            int advancedJS = 0;
            int basicCSharp = 0;
            int advancedCSharp = 0;

            for (int i = 0; i < AcademyMembers.StudentList.Count; i++)
            {
                if (AcademyMembers.StudentList[i].SubjectList == null)
                {
                    continue;
                }
                for (int j = 0; j < AcademyMembers.StudentList[i].SubjectList.Count; j++)
                {
                    if (AcademyMembers.StudentList[i].SubjectList[j].CurrentSubject)
                    {
                        switch (AcademyMembers.StudentList[i].SubjectList[j].Subject.ToString())
                        {
                            case "HTML5":
                                htmlCounter++;
                                break;
                            case "CSS3":
                                cssCounter++;
                                break;
                            case "BasicJS":
                                basicJS++;
                                break;
                            case "AdvancedJS":
                                advancedJS++;
                                break;
                            case "BasicCSharp":
                                basicCSharp++;
                                break;
                            case "AdvancedCSharp":
                                advancedCSharp++;
                                break;
                        }
                    }
                }
            }

            HelperService.ShowInformation($"1.{Subject.HTML5}\n *Attending: {htmlCounter} students");
            HelperService.ShowInformation($"2.{Subject.CSS3}\n *Attending: {cssCounter} students");
            HelperService.ShowInformation($"3.{Subject.BasicJS}\n *Attending: {basicJS} students");
            HelperService.ShowInformation($"4.{Subject.AdvancedJS}\n *Attending: {advancedJS} students");
            HelperService.ShowInformation($"5.{Subject.BasicCSharp}\n *Attending: {basicCSharp} students");
            HelperService.ShowInformation($"6.{Subject.AdvancedCSharp}\n *Attending: {advancedCSharp} students");

        }
    }
}
