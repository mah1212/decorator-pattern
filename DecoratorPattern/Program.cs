using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBevarage iBevarage = new HouseBlend();
            iBevarage = new Milk(iBevarage);
            iBevarage = new Whip(iBevarage);

            Console.WriteLine(iBevarage.GetDescription() + " " + iBevarage.GetCost());
            Console.ReadKey();
        }
    }
}
