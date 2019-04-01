using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class App
    {

        public void Run()
        {
            Cow Martha = new Cow("Martha");
            Chicken George = new Chicken("George");
            Sheep Charlie = new Sheep("Charlie");
            Horse Ed = new Horse("Mr.Ed");


            Console.WriteLine("Hey, welcome to the farm. which animal would you like to interact with?" +
                "\nChoose either Cows, Chickens, Sheep, or Horses");
            string choice = (Console.ReadLine());
            bool game = true;
            while (game)
            {


                try
                {
                    if (choice == "Chickens")
                    {
                        Console.WriteLine("Do you want to see him speek, sleep, eat, or run?");
                        string input = (Console.ReadLine());
                        if (input == "speak")
                        {
                            George.Speak();
                        }
                        else if (input == "sleep")
                        {
                            George.sleep();
                        }
                        else if (input == "eat")
                        {
                            George.eat();
                        }
                        else if (input == "run")
                        {
                            George.run();
                        }
                        else
                        {
                            Console.WriteLine("that is not a valid option");
                        }
                    }
                    else if (choice == "Cows")
                    {
                        Console.WriteLine("Do you want to see him speek, sleep, eat, or run?");
                        string input = (Console.ReadLine());
                        if (input == "speak")
                        {
                            Martha.Speak();
                        }
                        else if (input == "sleep")
                        {
                            Martha.sleep();
                        }
                        else if (input == "eat")
                        {
                            Martha.eat();
                        }
                        else if (input == "run")
                        {
                            Martha.run();
                        }
                        else
                        {
                            Console.WriteLine("that is not a valid option");
                        }
                    }
                    else if (choice == "Sheep")
                    {
                        Console.WriteLine("Do you want to see him speek, sleep, eat, or run?");
                        string input = (Console.ReadLine());
                        if (input == "speak")
                        {
                            Charlie.Speak();
                        }
                        else if (input == "sleep")
                        {
                            Charlie.sleep();
                        }
                        else if (input == "eat")
                        {
                            Charlie.eat();
                        }
                        else if (input == "run")
                        {
                            Charlie.run();
                        }
                        else
                        {
                            Console.WriteLine("that is not a valid option");
                        }
                    }
                    else if (choice == "Horses")
                    {
                        Console.WriteLine("Do you want to see him speek, sleep, eat, or run?");
                        string input = (Console.ReadLine());
                        if (input == "speak")
                        {
                            Ed.Speak();
                        }
                        else if (input == "sleep")
                        {
                            Ed.sleep();
                        }
                        else if (input == "eat")
                        {
                            Ed.eat();
                        }
                        else if (input == "run")
                        {
                            Ed.run();
                        }
                        else
                        {
                            Console.WriteLine("that is not a valid option");
                        }

                    }
                    else
                    {
                        Console.WriteLine("that isnt a valid option, this choice is case sensitive");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Oopsie woopsie, we made an ucky wucky UwU");
                }
            }
        }
    }
}
