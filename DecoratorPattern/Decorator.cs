using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decorator : IBevarage
    {
        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            throw new NotImplementedException();
        }
    }
}
