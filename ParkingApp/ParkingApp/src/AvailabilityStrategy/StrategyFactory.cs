using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Availability
{
    class StrategyFactory
    {
        static StrategyFactory instance;

        public static StrategyFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StrategyFactory();
                }

                return instance;
            }
        }

        public AvailabilityStrategy GetStrategy(string strategy)
        {
            AvailabilityStrategy strategyInstance = null;
            if (strategy.Equals("Any Fit")){
                strategyInstance = new AnyFitStrategy();
            }
            else if (strategy.Equals("Exact Fit"))
            {
                strategyInstance = new ExactFitStrategy();
            }

            return strategyInstance;
        }
    }
}
