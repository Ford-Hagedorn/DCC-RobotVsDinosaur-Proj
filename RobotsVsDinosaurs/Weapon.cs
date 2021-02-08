using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    //weapons for robots

    class Weapon
    {
        public string weaponName;
        public string shortDesc;
        public string recFor;

        public Weapon(string weaponName, string shortDesc, string recFor)
        {
            this.weaponName = weaponName;
            this.shortDesc = shortDesc;
            this.recFor = recFor;
        }



    }   
}
