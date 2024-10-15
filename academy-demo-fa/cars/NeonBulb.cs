using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class NeonBulb : IBulb
    {
        public string Name => "Neon";

        public int Lumens => 10000;
    }
}
