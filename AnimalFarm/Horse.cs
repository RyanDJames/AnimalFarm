using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Horse
    {
        public string name = "bubbah";

        public Horse(string _name)
        {
            name = _name;
        }

        public void Speak()
        {
            Console.WriteLine("Hello, my name is Mr. Ed, and I am a horse. I say neigh.");

        }


        public void sleep()
        {
            Console.WriteLine("The horse lays down and sleeps");
        }

        public void eat()
        {
            Console.WriteLine("the animal starts feeding");
        }
        public void run()
        {
            Console.WriteLine("yeehaw that boi runnin");
        }
    }
}
