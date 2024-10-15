using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.radio
{
    public class MP3Media : IMedia
    {
        public MP3Media() { }

        public void Pause()
        {
            Console.WriteLine("MP3Media has been paused");
        }

        public void Play()
        {
            Console.WriteLine("MP3Media is playing...");
        }

        public void Stop()
        {
            Console.WriteLine("MP3Media has stopped");
        }
    }
}
