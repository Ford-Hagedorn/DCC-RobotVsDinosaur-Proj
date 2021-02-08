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


        public List<Robot> robotChoice;
        public List<Weapon> weaponChoice;
        

        public Fleet()
        { 
            weaponChoice = new List<Weapon>();

            Weapon weapon1 = new Weapon("Plasma Cannon", "Fires 3 powerful shots per attack.", "Recommended for Barrel Dragon.");
            Weapon weapon2 = new Weapon("Twin Flails", "Two spiked flails attached to the arms.", "Recommended for Spikebot.");
            Weapon weapon3 = new Weapon("Mechanical Fists", "Gauntlets attached to the hands", "Recommended for Steel Ogre Grotto #2.");
            weaponChoice.Add(weapon1);
            weaponChoice.Add(weapon2);
            weaponChoice.Add(weapon3);
        
        
            robotChoice = new List<Robot>();
            
            Robot robot1 = new Robot("Barrel Dragon", 230, 700, 26, weapon1);
            Robot robot2 = new Robot("Spikebot", 170, 400, 18, weapon2);
            Robot robot3 = new Robot("Steel Ogre Grotto #2", 220, 600, 19, weapon3);
            robotChoice.Add(robot1);
            robotChoice.Add(robot2);
            robotChoice.Add(robot3);
        }
        
        
    }
}
