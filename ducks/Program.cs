using ducks.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MDuck mDuck = new MDuck();
            RDuck rDuck = new RDuck();
            RezDuck rezDuck = new RezDuck();
            Console.WriteLine("\n");
            mDuck.display();
            Console.WriteLine("\n");
            rDuck.display();
            Console.WriteLine("\n");
            rezDuck.display();
            Console.ReadLine();
        }
    }
}
