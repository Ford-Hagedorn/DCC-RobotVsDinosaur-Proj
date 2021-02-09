using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    //where they fight
    class Battlefield
    {
        //member variables
        
        public string intro;
        public string fieldName;
        public string robotIntro;
        public string dinoIntro;
        public Fleet fleet;
        public Herd herd;
        

        public Battlefield()
        {
            intro = "Welcome to the battle arena! Today, we are in for a treat! It's a showdown between a team of robots and a team of dinosaurs!";
            fieldName = "Today's arena will be the Thunderdrome! It's a large, round chamber with no places for cover, so the competitors will be unable to shield themselves from their opponents' attacks!";
            robotIntro = "Let's welcome to the field, the robot team!";
            fleet = new Fleet();
            dinoIntro = "Now let's welcome the dinosaurs to the arena!";
            herd = new Herd();

            // herd.dinos[0].health -= fleet.robots[0].attackPower;
            





        }
        public void BattleStart()
        {

            Console.WriteLine("Let's get this battle started!");
            Console.WriteLine($"Up first, {fleet.robots[0].robotName} vs {herd.dinoChoice[0].name}!");
            Console.WriteLine($"Looks like {fleet.robots[0].robotName} is equipped with {fleet.weaponChoice[0].weaponName}!");
            Console.WriteLine("This should be interesting! Let the battle begin!");

        }
        
        public void Battle()
        {
            Console.WriteLine("They're attacking each other!");
            Console.WriteLine("");
            while (herd.dinoChoice[].health > 0 && fleet.robots[].health > 0)
            {
                Console.WriteLine("They're attacking each other!");
                Console.WriteLine($"{herd.dinoChoice[0].name} attacks with {herd.dinoChoice[0].atkName}!");
                Console.WriteLine($"{fleet.robots[0].robotName} takes {herd.dinoChoice[0].atkPower} damage!");
                fleet.robots[0].health -= herd.dinoChoice[0].atkPower;
                Console.WriteLine($"{fleet.robots[0].robotName} strikes back with its {fleet.weaponChoice[0].weaponName}!");
                Console.WriteLine($"{herd.dinoChoice[0].name} takes {fleet.robots[0].atkPower} damage!");
                herd.dinoChoice[0].health -= fleet.robots[0].atkPower;
                if (herd.dinoChoice[0].health <= 0)
                {
                    Console.WriteLine($"{herd.dinoChoice[0].name} was defeated!");
                    List<Herd> dinoChoice = new List<Herd> dinoChoice()0, 1, 2;
                    herd.Remove(0);


                }
                else if (fleet.robots[0].health <= 0)
                {
                    Console.WriteLine($"{fleet.robots[0].robotName} bites the dust!");
                }
                else
                {
                    continue;
                }
                
            }
            
            
        }
            
        














        //public void TheThunderdrome()
        //{
        //    Console.WriteLine("The battle will take place at the Thunderdrome");
        //    Console.WriteLine("The Thunderdrome is a large solarium with a flat titanium floor.");
        //    Console.WriteLine("The area within the arena is 150 feet high with a square footage of 2000.");
        //    Console.WriteLine("All active competitors will be able to freely move around the arena with ample space.");
        //    Console.WriteLine("It contains a sitting area for the competitors that aren't currently battling");
        //    Console.WriteLine("The sitting area is a solid box with a bulletproof window so that the inactive competitors may view the current battle.");
        //    Console.WriteLine("Within the Thunderdrome, there are no places to get cover.");
        //    Console.WriteLine("This means that all attacks will either have to be dodged or taken.");
        //    Console.WriteLine("For aesthetic purposes, a thunderstorm hologram with sound will be projected during the battles.");
        //    Console.WriteLine("This means that the lightning visuals and thunder sounds should not adversely affect the current competitors.");


        //}
        
    }
}
