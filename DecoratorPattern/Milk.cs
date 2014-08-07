using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : IBevarage
    {
        private IBevarage iBevarage;

        public Milk(IBevarage iBevarage)
        {
            this.iBevarage = iBevarage;
        }
        public string GetDescription()
        {
            return "\n With Milk";
        }

        public double GetCost()
        {
            return iBevarage.GetCost() + 20.00;
        }
    }
}
