using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Cow
    {
        public string name = "charles";
        

        public Cow(string _name)
        {
            name = _name;
        }

        public void Speak()
        {
            Console.WriteLine("Moo");

        }

        public void sleep()
        {
            Console.WriteLine("The cow lays down and sleeps");
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
