using AcademyManagment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagment.Models.MembersDatabase
{
    public class AcademyMembers
    {

        public static List<Admin> AdminList = new List<Admin>()
        {
             new Admin("Ilija Mitev", 223305),
             new Admin("Marko Markovski", 1234),
        };


        public static List<Trainer> TrainerList = new List<Trainer>()
        {
            new Trainer("Kristijan Karanfilovski", 1111),
            new Trainer("Aneta Stankovska", 1111),
        };


        public static List<Student> StudentList = new List<Student>()
        {

            new Student("Stefan Ivanovski", 1111, new List<StudentSubject>()
            {
                new StudentSubject(Subject.HTML5, "5"),
                new StudentSubject(Subject.CSS3, "5"),
                new StudentSubject(Subject.BasicJS, "5"),
                new StudentSubject(Subject.AdvancedJS, "5"),
                new StudentSubject(Subject.BasicCSharp, "5"),
                new StudentSubject(Subject.AdvancedCSharp, true)
            }),
            new Student("Aleksandar Zivkovic", 2222, new List<StudentSubject>()
            {
                new StudentSubject(Subject.HTML5, "2"),
                new StudentSubject(Subject.CSS3, "3"),
                new StudentSubject(Subject.BasicJS, "5"),
                new StudentSubject(Subject.AdvancedJS, "5"),
                new StudentSubject(Subject.BasicCSharp, "4"),
                new StudentSubject(Subject.AdvancedCSharp, true),
            }),
            new Student("Maja Nikolikj", 3333, new List<StudentSubject>()
            {
                new StudentSubject(Subject.HTML5, "3"),
                new StudentSubject(Subject.CSS3, "4"),
                new StudentSubject(Subject.BasicJS, true),
            }),
            new Student("Marija Kolevska", 4444, new List<StudentSubject>()
            {
                new StudentSubject(Subject.HTML5, "5"),
                new StudentSubject(Subject.CSS3, "5"),
                new StudentSubject(Subject.BasicJS, "5"),
                new StudentSubject(Subject.AdvancedJS, true)
            }),
            new Student("Pink Panther", 5555, new List<StudentSubject>()
            {
                new StudentSubject(Subject.HTML5, "5"),
                new StudentSubject(Subject.CSS3, "5"),
                new StudentSubject(Subject.BasicJS, "5"),
                new StudentSubject(Subject.AdvancedJS, "5"),
                new StudentSubject(Subject.BasicCSharp, true)
            })

        };



















    }
}
