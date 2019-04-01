using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Sheep
    {
        public string name = "bubbah";

        public Sheep(string _name)
        {
            name = _name;
        }

        public void Speak()
        {
            Console.WriteLine("Baa");

        }


        public void sleep()
        {
            Console.WriteLine("The sheep lays down and sleeps");
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
