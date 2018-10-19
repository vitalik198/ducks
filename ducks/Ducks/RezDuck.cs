using ducks.DucksProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks.Ducks
{
    class RezDuck : Duck
    {
        IFCantDucks fly = new IFCantDucks();
        IQCantDucks quake = new IQCantDucks();
        public override void display()
        {
            string[] ds = new string[] { "Я резиновая утка", swim(), fly.fly(), quake.quake() };
            foreach (string s in ds)
                Console.WriteLine(s);
        }
    }
}
