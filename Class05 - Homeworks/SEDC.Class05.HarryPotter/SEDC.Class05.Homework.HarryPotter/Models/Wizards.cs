using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class05.Homework.HarryPotter.Models
{
    public class Wizards
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public DateTime StartedHogwarts { get; set; }
        public bool Gradueted { get; set; }

        public Wizards(string name, int powerLevel, int age, DateTime dateStartingHogwarts, bool graduated)
        {
            Name = name;
            PowerLevel = powerLevel;
            Age = age;
            StartedHogwarts = dateStartingHogwarts;
            Gradueted = graduated;
        }
    }
}
