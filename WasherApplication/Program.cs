using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.Temperature = 40;
            washer.Speed = "1200 rpm";
            washer.On();

            Console.WriteLine("Water temperature is: " + washer.Temperature);
            Console.WriteLine("Sling speed is: " + washer.Speed);



        }
    }
}
