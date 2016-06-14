using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace WordPlayer.AudioPlayer
{
    class AudioFileController : IAudioFileController
    {

        private IWavePlayer wavePlayer = new WaveOutEvent();
        private FadeInOutSampleProvider fadeInOut;

        public AudioFileController(String path)
        {
            fadeInOut = new FadeInOutSampleProvider(new AudioFileReader(@path));
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

        public void Stop()
        {
            wavePlayer.Stop();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            wavePlayer.Dispose();
        }
    }
}
