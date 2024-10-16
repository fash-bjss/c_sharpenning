using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.writers
{
    public class Writer : IOutputDisplay
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
