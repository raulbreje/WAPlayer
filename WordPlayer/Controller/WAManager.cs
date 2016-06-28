using System;
using System.ComponentModel;
using System.Windows.Forms;
using ErrorHandling.Handlers;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using WordPlayer.AudioPlayer;
using WordPlayer.Internal;
using WordPlayer.Utils;

namespace WordPlayer.Controller
{

    public enum PlaybackStatus
    {
        Stopped,
        Playing,
        Paused,
        Unloaded
    }

    public enum CompareMode
    {
        CurrentPosition,
        SkipBack,
        Restart,
    }
    class WaManager : IWaManager
    {
        private int _skipSeconds;
        private AudioStream _stream;
        private StreamInfo sinfo;

        private IWavePlayer _wavePlayer;
        private static readonly IExceptionHandler ExceptionHandler = new ExceptionHandler();

        private WaveMixerStream32 _mixer;
        public PlaybackStatus Status { get; set; }

        public void VolumeUp()
        {
            var oldVolume = sinfo.Volume;
            if (!(oldVolume >= 0f)) return;
            var newValue = oldVolume + 0.1f;
            sinfo.Volume = newValue;
        }

        public void VolumeDown()
        {
            var oldVolume = sinfo.Volume;
            if (!(oldVolume <= 1f)) return;
            var newValue = oldVolume - 0.1f;
            sinfo.Volume = newValue;
        }

        private static void Handle(Exception exception)
        {
            ExceptionHandler.Handle(exception);
        }
        
        public WaManager()
        {
            Status = PlaybackStatus.Unloaded;
        }

        public PlaybackStatus GetStatus()
        {
            return Status;
        }

        public void SetStatus(PlaybackStatus status)
        {
            Status = status;
        }

        public void Init(string path)
        {
            sinfo = new StreamInfo(path);
            _mixer = new WaveMixerStream32();
            _mixer.AddInputStream(sinfo.Stream);
            _wavePlayer = new WaveOut();
            _wavePlayer.Init(_mixer);
            _mixer.AutoStop = false;
            _skipSeconds = 3;
            Status = PlaybackStatus.Stopped;
        }

        public void Play()
        {
            _wavePlayer.Play();
            Status = PlaybackStatus.Playing;
        }

        public void Pause()
        {
            _wavePlayer.Pause();
            Status = PlaybackStatus.Paused;
        }

        public void Stop()
        {
            if (Status != PlaybackStatus.Stopped)
            {
                if (_wavePlayer != null)
                {
                    _wavePlayer.Stop();
                    _mixer.CurrentTime = TimeSpan.Zero;
                    Status = PlaybackStatus.Stopped;
                }
            }
        }

        public void Forward()
        {
            if (_mixer == null) return;
            if (Status == PlaybackStatus.Playing)
            {
                _mixer.CurrentTime += TimeSpan.FromSeconds(_skipSeconds);
            }
            
            if (_mixer.CurrentTime < _mixer.TotalTime) return;
            _wavePlayer.Stop();
            _mixer.CurrentTime = TimeSpan.Zero;
            Status = PlaybackStatus.Stopped;
        }

        public void Rewind()
        {
            SkipBack();
        }

        private void SkipBack()
        {
            if (_mixer == null) return;
            _mixer.CurrentTime += TimeSpan.FromSeconds(0 - _skipSeconds);
            if (_mixer.CurrentTime <= TimeSpan.Zero)
            {
                _mixer.CurrentTime = TimeSpan.Zero;
            }
        }

        public void Dispose()
        {
            try
            {
                _wavePlayer.Dispose();
            }
            catch (Exception e)
            {
                Handle(e);
            }
            
        }

        public string GetTotalTimeOfTrack()
        {
            return FormatTimeSpan(_mixer.TotalTime);
        }

        public long GetPositionFromMixer()
        {
            return _mixer.Position;
        }

        public long GetLengthFromMixer()
        {
            return _mixer.Length;
        }

        public string GetCurrentTimeOfTrack()
        {
            return FormatTimeSpan(_mixer.CurrentTime);
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return $"{(int) ts.TotalMinutes:D2}:{ts.Seconds:D2}";
        }
        
    }
}
