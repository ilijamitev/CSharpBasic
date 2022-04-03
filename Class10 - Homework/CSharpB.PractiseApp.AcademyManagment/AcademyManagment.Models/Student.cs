using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models
{
    public class Student : Person
    {
        public List<StudentSubject> SubjectList { get; set; }
        public Student()
        {

        }
        public Student(string fullName, int password)
        {
            FullName = fullName;
            Password = password;
        }

        public Student(string fullName, int password, List<StudentSubject> subjectList, Role role = Role.Student)
        {
            FullName = fullName;
            Password = password;
            SubjectList = subjectList;
            Role = role;
        }





    }
}
