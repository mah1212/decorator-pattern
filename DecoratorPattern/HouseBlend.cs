using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : IBevarage
    {
        public string GetDescription()
        {
            return "\n House Blend";
        }

        public double GetCost()
        {
            return 100.00;
        }
    }
}
