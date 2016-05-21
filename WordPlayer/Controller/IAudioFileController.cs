using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPlayer.AudioPlayer
{
    interface IAudioFileController
    {

        void Play();

        void Pause();

        void Stop();

        void Forward();

        void Reverse();

    }
}
