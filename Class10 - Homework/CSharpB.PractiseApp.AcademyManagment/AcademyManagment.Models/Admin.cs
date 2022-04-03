using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models
{
    public class Admin : Person
    {
        public Admin()
        {

        }
        public Admin(string fullName, int password, Role role = Role.Admin)
        {
            FullName = fullName;
            Password = password;
            Role = role;
        }












    }
}
