using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public class UberTravelStratagy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Going Airport in Uber");
        }
    }
}
