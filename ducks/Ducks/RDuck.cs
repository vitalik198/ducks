using ducks.DucksProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks.Ducks
{
    class RDuck : Duck
    {
        IFReactDucks fly = new IFReactDucks();
        IQHaveDucks quake = new IQHaveDucks();
        public override void display()
        {
            string[] ds = new string[] { "Я реактивная утка", swim(), fly.fly(), quake.quake() };
            foreach (string s in ds)
                Console.WriteLine(s);
        }
    }
}
