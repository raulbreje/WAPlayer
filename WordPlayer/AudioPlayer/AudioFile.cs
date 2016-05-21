using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WordPlayer.AudioPlayer
{
    class AudioFile : IAudioFile
    {

        
        private SoundPlayer player = null;
        private IWavePlayer wavePlayer;
        private AudioFileReader file;
        private FadeInOutSampleProvider fadeInOut;

        public AudioFile(String path)
        {
            wavePlayer = new WaveOutEvent();
            file = new AudioFileReader(@path);
            fadeInOut = new FadeInOutSampleProvider(file);
            wavePlayer.Init(fadeInOut);
        }

        public void Play()
        {
            wavePlayer.Play();
        }

        public void Pause()
        {
            wavePlayer.Pause();
        }

        public void ToStart()
        {
            player.Play();
        }

    }
}
