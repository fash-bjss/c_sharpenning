using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public interface IShape : IDisplay
    {

        public void Draw(IDisplay display);

        public void Draw();
    }
}
