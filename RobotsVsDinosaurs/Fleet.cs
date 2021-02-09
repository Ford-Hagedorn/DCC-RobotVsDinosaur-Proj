using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    //Robots stored in fleet, dinosaurs stored in herd
    //Robot: name, health, power level, weapon type, atk power
 
    class Fleet
    {


        public List<Robot> robots;
        public List<Weapon> weaponChoice;
        
        

        public Fleet()
        { 
            weaponChoice = new List<Weapon>();

            Weapon weapon1 = new Weapon("Double Tool C & D", "Large drill for left arm, circular saw for right.", "Recommended for Power Tool Dragon.");
            Weapon weapon2 = new Weapon("Twin Flails", "Two spiked flails attached to the arms.", "Recommended for Spikebot.");
            Weapon weapon3 = new Weapon("Mechanical Fists", "Gauntlets attached to the hands", "Recommended for Steel Ogre Grotto #2.");
            weaponChoice.Add(weapon1);
            weaponChoice.Add(weapon2);
            weaponChoice.Add(weapon3);


            robots = new List<Robot>();
            
            Robot robot1 = new Robot("Power Tool Dragon", 250, 700, 23, weapon1);
            Robot robot2 = new Robot("Spikebot", 170, 400, 18, weapon2);
            Robot robot3 = new Robot("Steel Ogre Grotto #2", 220, 600, 19, weapon3);
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }
       


    }
}
