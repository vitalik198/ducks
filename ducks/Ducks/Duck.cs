using ducks.DucksProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    abstract class Duck
    {
        public string swim() { return "Я умею плавать"; }
        public abstract void display();
    }
}