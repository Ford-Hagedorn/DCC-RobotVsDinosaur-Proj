using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    //Robots stored in fleet, dinosaurs stored in herd
    //Dinosaur: type, health, energy, atk power
   
    class Herd
    {
        public List<Dinosaur> dinoChoice;

        public Herd()
        {
            dinoChoice = new List<Dinosaur>();

            Dinosaur dino1 = new Dinosaur("Frostosaurus", "Brachiosaurus", 170, 600, 26, "Icy Stomp");
            Dinosaur dino2 = new Dinosaur("Megazowler", "Triceratops", 200, 400, 18, "Horn Headbutt");
            Dinosaur dino3 = new Dinosaur("Sabersaurus", "Triceratops", 50, 400, 19, "Vicious Slice");

            dinoChoice.Add(dino1);
            dinoChoice.Add(dino2);
            dinoChoice.Add(dino3);


        }
    }
}
