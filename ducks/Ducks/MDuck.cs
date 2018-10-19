using ducks.DucksProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks.Ducks
{
    class MDuck : Duck
    {
        IFCantDucks flyCant = new IFCantDucks();
        IQCantDucks quake = new IQCantDucks();
        public override void display()
        {
            string[] ds = new string[] { "Я деревянная утка", swim(), flyCant.fly(), quake.quake() };
            foreach (string s in ds)
                Console.WriteLine(s);
        }
    }
}
