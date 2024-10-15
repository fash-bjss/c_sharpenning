using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class TextBox : IShape
    {
        private string enteredText = "";
        public TextBox(string text) {
            
            this.enteredText = text;
        }

        public void Draw(IDisplay display)
        {
            display.Write(enteredText);
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
