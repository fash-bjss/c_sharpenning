using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.screenClearers
{
    public class Clearer : IScreenClearer
    {
        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
