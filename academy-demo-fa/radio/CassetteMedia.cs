using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.radio
{
    public class CassetteMedia : IMedia
    {
        public void Pause()
        {
            Console.WriteLine("CassetteMedia has been paused");
        }

        public void Play()
        {
            Console.WriteLine("CassetteMedia is playing...");
        }

        public void Stop()
        {
            Console.WriteLine("CassetteMedia has stopped.");
        }
    }
}
