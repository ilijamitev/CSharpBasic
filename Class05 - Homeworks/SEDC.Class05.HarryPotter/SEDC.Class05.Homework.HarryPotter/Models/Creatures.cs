using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class05.Homework.HarryPotter.Models
{
    public class Creatures
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }

        public bool Tamed = false;

        public Creatures(string name, int age, int powerLevel)
        {
            Name = name;
            Age = age;
            PowerLevel = powerLevel;
        }


    }
}
