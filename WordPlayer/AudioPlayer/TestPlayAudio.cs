using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WordPlayer.AudioPlayer
{
    class TestPlayAudio
    {
        
        public static void PlayAudio()
        {
            SoundPlayer pl = new SoundPlayer(@"d:\song.wav");
            try { pl.Play(); } catch(Exception e) { Console.Write("nu merge"); }

        }

    }
}
