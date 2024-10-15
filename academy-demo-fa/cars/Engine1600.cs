using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class Engine1600 : IEngine
    {
        public double EngineSize
        {
            get { 
                // Using D at the end signifies Double, F for Float and L for
                return 1600.0D; 
            }
        }

        public int MaxSpeed
        {
            get
            {
                return 92;
            }
        }
    }
}
