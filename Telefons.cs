using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Telefons
    {
        public double Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling 911, this is getting very interesting");
        }

        public void Sms()
        {
            Console.WriteLine("SMS sent, sending lots of nice things");
        }

    }
}

