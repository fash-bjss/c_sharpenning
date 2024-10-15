using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.radio
{
    public class CDMedia : IMedia
    {
        public void Pause()
        {
            Console.WriteLine("CDMedia has been paused");
        }

        public void Play()
        {
            Console.WriteLine("CDMedia is playing...");
        }

        public void Stop()
        {
            Console.WriteLine("CDMedia has stopped");
        }
    }
}
