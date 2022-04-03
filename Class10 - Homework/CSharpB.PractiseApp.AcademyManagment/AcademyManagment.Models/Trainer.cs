using AcademyManagment.Models.BaseModel;
using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models
{
    public class Trainer : Person
    {
        public Trainer()
        {

        }
        public Trainer(string fullName, int password, Role role = Role.Trainer)
        {
            FullName = fullName;
            Password = password;
            Role = role;
        }












    }
}
