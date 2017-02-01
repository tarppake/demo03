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
            washer.Speed = 1200;
            washer.On();

            Console.WriteLine("Water temperature is: " + washer.Temperature + " °C");
            Console.WriteLine("Sling speed is: " + washer.Speed + "rpm");



        }
    }
}
