using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carapplication
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }
    
        // default constructor
        public Car()
        {

        }
    
        // constructor...
  
        public Car(string model)
        {
            Model = model;
        }


        // method to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }

        // method to slow down
        public void Brake(int value)
        {
            Speed -= value; //speed = speed - value;
        }

        // method to display car data)properties
        public void PrintData()
        {
            Console.WriteLine("Car properties: ");
            Console.WriteLine("- model: " + Model);
            Console.WriteLine("- Color: " + Color);
            Console.WriteLine("- Engine: " + Engine);
            Console.WriteLine("- Speed: " + Speed);
            Console.WriteLine("- Dices: " + FuzzyDices);
            Console.WriteLine("- Doors: " + DoorCount);
            Console.WriteLine("- Some property: " + SomeProperty);
        }

        // destructor
        ~Car()
        {
            Console.WriteLine("Car Object destroyed");
        }

        } //classs
} // namespce
