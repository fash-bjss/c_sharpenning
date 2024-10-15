using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.cars
{
    public interface ICar
    {
        public IHeadlights Headlights { get; protected set; }


        // Example of using the Interface IEngine as a composition
        public IEngine Engine { get; }
        

        public void Accelerate();
 
        public void Brake();




    }
}
