using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class NormalLights : IHeadlights
    {
        public string Status { get; private set; } = "Off";

        public IBulb Bulb => throw new NotImplementedException();

        public void Dipped()
        {
            Status = "Dipped";
        }

        public void FullBeam()
        {
            Status = "Full Beam";
        }

        public void Off()
        {
            Status = "Off";
        }
    }
}
