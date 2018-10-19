using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks.DucksProperties
{
    public interface IQDucks
    {
        string quake();
    }
    public class IQCantDucks : IQDucks
    {
        public string quake()
        {
            return "Я не умею крякать";
        }
    }
    public class IQHaveDucks : IQDucks
    {
        public string quake()
        {
            return "Я умею крякать";
        }
    }
}
