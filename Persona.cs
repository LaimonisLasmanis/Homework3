using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello My name is : {Name} {Surname}. I Am {Age} old, my Hobby is {Hobby}, I am real Man -  {Gender}!! :))");

        }
    }
}
