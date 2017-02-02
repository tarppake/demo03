using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        public int Speed { get; set; }
        public int Temperature { get; set; }

       

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
        public void Temperatureup()
        {
            Temperature += 10;
        }

        // method to - temperature
        public void Temperaturedown()
        {
            Temperature -= 10;
        }
}
