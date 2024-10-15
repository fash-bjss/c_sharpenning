using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public interface IHeadlights
    {
        public string Status { get; }
        public IBulb Bulb { get; }

        public void Dipped();
        public void Off();
        public void FullBeam();

    }
}
