using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public class NeonHeadlights : BaseHeadlights
    {
        public override void FullBeam()
        {
            base.Status = "Dazzling Full Beam";
        }
    }
}
