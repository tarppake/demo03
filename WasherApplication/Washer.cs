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
        public string Speed { get; set; }
        public int Temperature { get; set; }

        public void On()
        {
            Console.WriteLine("Washer is on");
        }


    }
}
