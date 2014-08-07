using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : IBevarage
    {
        public string GetDescription()
        {
            return "Espresso Coffe";
        }

        public double GetCost()
        {
            return 80.00;
        }
    }
}
