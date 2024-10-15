using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class Headlights : IHeadlights
    {
        public string Status { get; set; } = "Off";
        public IBulb Bulb { get; private set; }

        public Headlights(IBulb bulb)
        {
            Bulb = bulb;
        }

        public void Dipped()
        {
            Status = "Dipped";
        }

        public void Off()
        {
            Status = "Off";
        }


        public void FullBeam()
        {
            Status = "Full Beam";
        }
    }
}
