using System;
using System.Windows.Forms;
using ErrorHandling.Handlers;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using WordPlayer.AudioPlayer;
using WordPlayer.Utils;

namespace WordPlayer.Controller
{

    enum PlaybackStatus
    {
        Stopped,
        Playing,
        Paused
    }

    public enum CompareMode
    {
        CurrentPosition,
        SkipBack,
        Restart,
    }
    class WAManager : IWAManager
    {

        private readonly IWavePlayer _wavePlayer = new WaveOutEvent();
        private AudioFileReader _file;
        private static readonly IExceptionHandler ExceptionHandler = new ExceptionHandler();
        public static bool isLoad = false;

        private static void Handle(Exception exception)
        {
            ExceptionHandler.Handle(exception);
        }
        
        public WAManager()
        {
            
        }

        public void Init(string path)
        {
            _file = new AudioFileReader(@path);
            var fadeInOut = new FadeInOutSampleProvider(_file);
            _wavePlayer.Init(fadeInOut);
            isLoad = true;
        }

        public void Play()
        {
            _wavePlayer.Play();
        }

        public void Pause()
        {
            _wavePlayer.Pause();
        }

        public void Stop()
        {
            _wavePlayer.Stop();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            isLoad = false;
            try
            {
                _wavePlayer.Dispose();
            }
            catch (Exception e)
            {
                Handle(e);
            }
            
        }

        public void VolumeUp()
        {
            throw new NotImplementedException();
        }

        public void VolumeDown()
        {
            throw new NotImplementedException();
        }

        public string GetTotalTimeOfTrack()
        {
            return FormatTimeSpan(_file.CurrentTime) + " / " + FormatTimeSpan(_file.TotalTime);
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return $"{(int) ts.TotalMinutes:D2}:{ts.Seconds:D2}:{ts.Milliseconds:D2}";
        }
        
    }
}
