using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class Line : IShape
    {
        public int LineLength { get; } = 5;
        public void Draw(IDisplay display)
        {   
            display.Write(new string('*', LineLength));
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
