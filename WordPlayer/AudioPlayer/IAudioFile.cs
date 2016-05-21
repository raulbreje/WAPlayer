using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPlayer.AudioPlayer
{
    interface IAudioFile
    {
        void Play();

        void Pause();

        void ToStart();
    }
}
