using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
   
   
    class Robot
    {
        
        public string robotName;
        public double health;
        public double powerLevel;
        public double atkPower;
        public Weapon weapon;

        public Robot(string robotName, double health, double powerLevel, double atkPower, Weapon weapon)
        {
            this.robotName = robotName;
            this.health = health;
            this.powerLevel = powerLevel;
            this.atkPower = atkPower;
            
        }
    }
}
