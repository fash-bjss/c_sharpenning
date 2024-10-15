using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class Shapes : IShape
    {
        private IDisplay idisplayer;
        private List<IShape> shapesList = new List<IShape>();

        public Shapes(IDisplay display) {
            this.idisplayer = display;
        }
        public void Add(IShape shape)
        {
            shapesList.Add(shape);
        }

        public void Draw(IDisplay display)
        {
            foreach (IShape shape in shapesList) { 
                shape.Draw(display);
            }
        }

        public void Draw()
        {
            foreach (IShape shape in shapesList)
            {
                shape.Draw(idisplayer);
            }
        }
    }
}
