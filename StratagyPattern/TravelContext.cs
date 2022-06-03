using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;

        public void SetStratagy(ITravelStrategy travelStrategy) 
        { 
            this.travelStrategy = travelStrategy; 
        }

        public void Airport()
        {
            this.travelStrategy.GotoAirport();
        }
    }
}
