using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.radio
{
    public class RecordMedia : IMedia
    {
        public void Pause()
        {
            Console.WriteLine("RecordMedia has been paused");
        }

        public void Play()
        {
            Console.WriteLine("RecordMedia is playing...");
        }

        public void Stop()
        {
            Console.WriteLine("RecordMedia has stopped");
        }
    }
}
