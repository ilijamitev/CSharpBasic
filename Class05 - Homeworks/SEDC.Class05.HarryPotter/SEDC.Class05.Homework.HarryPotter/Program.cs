using SEDC.Class05.Homework.HarryPotter.Models;
using System;

namespace SEDC.Class05.Homework.HarryPotter
{
    class Program
    {
        // MAIN TASK
        public static string DuelCreature(Wizards wizard, Creatures creatureToDuel)
        {
            string showDuelStats = string.Empty;
            if (!creatureToDuel.Tamed)
            {
                showDuelStats = wizard.PowerLevel > creatureToDuel.PowerLevel ? $"The wizard {wizard.Name} won the duel with {creatureToDuel.Name}." : $"The wizard {wizard.Name} lost the duel with {creatureToDuel.Name}.";
                creatureToDuel.Tamed = !creatureToDuel.Tamed;
            }
            else
            {
                showDuelStats = $"The creature {creatureToDuel.Name} has already been tamed!";
            }
            return showDuelStats;
        }

        // EXTRA TASK
        public static string DuelTeams(Wizards[] wizardsArr, Creatures[] creaturesArr)
        {
            string showDuelStats = "\nAll the creatures are tamed. Team Wizards wins!";

            for (int i = 0; i < wizardsArr.Length; i++)
            {
                foreach (Creatures creature in creaturesArr)
                {
                    if (wizardsArr[i].PowerLevel > creature.PowerLevel)
                    {
                        creature.Tamed = true;
                    }
                }
            }
            foreach (Creatures creature in creaturesArr)
            {
                if (!creature.Tamed)
                {
                    showDuelStats = $"\nThe creature {creature.Name} cannot be tamed!";
                    break;
                }
            }

            return showDuelStats;
        }




        static void Main(string[] args)
        {
            Console.Title = "  *** Harry Potter and The Web Developer *** ";

            Wizards harryPotter = new Wizards("Harry Potter", 10, 40, new DateTime(09 / 15 / 2001), true);
            Wizards ilija = new Wizards("Ilija Potter", 7, 26, new DateTime(09 / 15 / 2011), false);
            Wizards tijana = new Wizards("Tijana Potter", 8, 25, new DateTime(09 / 15 / 2011), false);
            Wizards ivica = new Wizards("Ivica Potter", 8, 26, new DateTime(09 / 15 / 2011), false);

            //Creatures dementor = new Creatures("Dementor", 1000, 11);     //cannot be tamed
            Creatures dementor = new Creatures("Dementor", 1000, 9);
            Creatures dragon = new Creatures("Hungarian Horntail", 100, 9);
            Creatures troll = new Creatures("Troll", 150, 6);
            Creatures threeHeadedDog = new Creatures("Fluffy", 200, 7);

            Wizards[] teamWizzards = new Wizards[] { harryPotter, ilija, tijana, ivica };
            Creatures[] teamCreatures = new Creatures[] { dementor, dragon, troll, threeHeadedDog };


            // MAIN TASK

            //Console.WriteLine(dementor.Tamed);
            //Console.WriteLine(DuelCreature(ilija, dementor));
            //Console.WriteLine(dementor.Tamed);

            // EXTRA TASK

            Console.WriteLine(DuelTeams(teamWizzards, teamCreatures));




            Console.ReadLine();
        }
    }
}
