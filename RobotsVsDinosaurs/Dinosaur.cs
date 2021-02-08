using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    
    class Dinosaur
    {
        public string name;
        public string type;
        public double health;
        public double energy;
        public double atkPower;
        public string atkName;

        public Dinosaur(string name, string type, double health, double energy, double atkPower, string atkName)
        {
            this.name = name;
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.atkPower = atkPower;
            this.atkName = atkName;

        }

    }
}
