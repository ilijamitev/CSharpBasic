using AcademyManagment.Models.MembersDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Service.ManagmentServices
{
    public class StudentService
    {
        public static bool FindStudent(string fullName)
        {
            return AcademyMembers.StudentList.Exists(x => x.FullName == fullName);
        }

        public static bool FindStudentPassword(int password)
        {
            return AcademyMembers.StudentList.Exists(x => x.Password == password);
        }


    }
}
