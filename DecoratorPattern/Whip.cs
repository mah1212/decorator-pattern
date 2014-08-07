using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Whip : IBevarage
    {
        private IBevarage iBevarage;

        public Whip(IBevarage iBevarage)
        {
            this.iBevarage = iBevarage;
        }
        public string GetDescription()
        {
            return "\n Whip";
        }

        public double GetCost()
        {
            return iBevarage.GetCost() + 30.00;
        }
    }
}
