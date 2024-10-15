using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class Box : IShape
    {   
        private Line line = new Line();

        public void Draw(IDisplay display)
        {
            line.Draw(display);

            for (int i = 0; i < line.LineLength; i++) {
                display.Write("*" + new string(' ', line.LineLength - 2) + "*");
            }

            line.Draw(display);

        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
