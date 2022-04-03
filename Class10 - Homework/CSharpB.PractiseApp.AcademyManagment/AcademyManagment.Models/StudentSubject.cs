using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models
{
    public class StudentSubject
    {
        public Subject Subject { get; set; }
        public bool CurrentSubject { get; set; }
        public string SubjectGrade { get; set; }

        public StudentSubject(Subject subjectInput, string subjectGradeInput, bool currentSubject = false)
        {
            Subject = subjectInput;
            if (!currentSubject)
            {
                SubjectGrade = subjectGradeInput;
            }
            CurrentSubject = currentSubject;
        }

        public StudentSubject(Subject subjectInput, bool currentSubject = false)
        {
            Subject = subjectInput;
            CurrentSubject = currentSubject;
        }
    }
}
