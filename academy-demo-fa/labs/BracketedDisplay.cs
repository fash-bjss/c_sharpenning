using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class BracketedDisplay : IDisplay
    {
        public void Write(string text)
        {
            Console.WriteLine("[" + text + "]");
        }
    }
}
