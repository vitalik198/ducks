using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks.DucksProperties
{
    public interface IFDucks
    {
        string fly();
    }

    public class IFReactDucks : IFDucks
    {
        public string fly()
        {
            return "Я умею летать с помощью реактивной струи!";
        }
    }
    public class IFCantDucks : IFDucks
    {
        public string fly()
        {
            return "Я не умею летать";
        }
    }
}
