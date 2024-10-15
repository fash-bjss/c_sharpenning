using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class Engine2000 : IEngine
    {
        public double EngineSize {
            get
            {
                return 2000.0D;
            }
        }

        public int MaxSpeed{
            get
            {
                return 112;
            }
        }
    }
}
