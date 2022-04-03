using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models.BaseModel
{
    public class Person
    {
        public string FullName { get; set; }
        public int Password { get; set; }
        public Role Role { get; set; }
        public bool IsLoggedIn = false;

        public Person()
        {

        }

        public Person(string fullName, int password)
        {
            FullName = fullName;
            Password = password;
        }

    }
}
