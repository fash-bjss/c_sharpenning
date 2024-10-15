using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public abstract class BaseHeadlights
    {
        public string Status { get; protected set; } = "Off";

        public virtual void Dipped()
        {
            Status = "Dipped";
        }
        public virtual void FullBeam()
        {
            Status = "Full Beam";
        }
        public virtual void Off()
        {
            Status = "Off";
        }

    }
}
