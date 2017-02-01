using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        public bool IsOn { get; set; }
        public int Speed { get; set; }
        public int Temperature { get; set; }

        public void On()
        {
            Console.WriteLine("Washer is on");
        }


        //method to +speed
        public void Accelerate()
        {
            Speed += 200;
        }

        // method to - speed
        public void Slow()
        {
            Speed -= 200; //speed = speed - value;
        }

        // method to + temperature


        // method to - temperature



    }
}
