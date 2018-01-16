using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdDziedziczenie
{
    public class Car : Vehicle
    {
        public override void Beep(string sound)
        {
            base.Beep(sound);
            Console.WriteLine("trabie innaczej");
        }



    }
}
