using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public interface IEngine
    {
        // We cannot have a setter as private set in an interface
        public Double EngineSize { get; }
        public int  MaxSpeed { get; }
    }
}
