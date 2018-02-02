using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();
            auto1.Beep("muucze gdy trabie");
            auto1.Wruuum("iiiihhaaaa");
            Console.ReadKey();
        }
    }
}
//Napisz klasę Vehicle w której Będzie metoda Beep() i metoda Wrum() w klasie Car która będzie rozszerzać vehicle 
//jedną z tych metod  przesłoń a drugą nadpisz 