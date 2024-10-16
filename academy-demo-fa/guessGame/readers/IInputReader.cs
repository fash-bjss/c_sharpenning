using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.readers
{
    public interface IInputReader
    {
        public string Read();

        public bool IsValid();
    }
}
