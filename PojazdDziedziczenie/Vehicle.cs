using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdDziedziczenie
{
    public class Vehicle
    {
        public virtual void Beep(string sound)
        {
            Console.WriteLine("Beeep");
            Console.WriteLine(sound);
        }

        public void Wruuum(string sound)
        {
            Console.WriteLine("Wrruummm");
            Console.WriteLine(sound);
        }
    }
}
