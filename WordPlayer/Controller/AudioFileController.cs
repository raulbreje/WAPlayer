using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace WordPlayer.AudioPlayer
{
    class AudioFileController : IAudioFileController
    {

        private IWavePlayer wavePlayer = new WaveOutEvent();
        private AudioFileReader file;
        private FadeInOutSampleProvider fadeInOut;

        public AudioFileController(String path)
        {
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

        public string GetTotalTimeOfTrack()
        {
            return FormatTimeSpan(file.CurrentTime) + " / " + FormatTimeSpan(file.TotalTime);
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalMinutes, ts.Seconds, ts.Milliseconds);
        }
        
    }
}
