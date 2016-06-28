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
        private const float volume = 1.0f;
        private const float MinDb = -48;
        public event EventHandler VolumeChanged;

        private int _skipSeconds;
        private AudioStream _stream;

        private IWavePlayer _wavePlayer;
        private AudioFileReader _file;
        private static readonly IExceptionHandler ExceptionHandler = new ExceptionHandler();

        private WaveMixerStream32 _mixer;
        public PlaybackStatus Status { get; set; }

        public void SetVolumeUp()
        {
            Volume = (1 - (float)volume + 10) * MinDb;
        }

        public void SetVolumeDown()
        {
            Volume = (1 - (float)volume - 10) * MinDb;
        }

        [DefaultValue(1.0f)]
        public float Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0.0f)
                    value = 0.0f;
                if (value > 1.0f)
                    value = 1.0f;
            }
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
            StreamInfo sinfo = new StreamInfo(path);
            sinfo.Letter = "A";
            _file = new AudioFileReader(@path);
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
            _wavePlayer.Stop();
            Status = PlaybackStatus.Stopped;
        }

        public void Forward()
        {
            if (_mixer != null)
            {
                _mixer.CurrentTime += TimeSpan.FromSeconds(_skipSeconds);
            }
        }

        public void Rewind()
        {
            SkipBack();
        }

        private void SkipBack()
        {
            if (_mixer != null)
            {
                _mixer.CurrentTime += TimeSpan.FromSeconds(0 - _skipSeconds);
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

        public void VolumeUp()
        {
            var dbVolume = (1 + (float)10 / 20) * MinDb;
            Volume = (float)Math.Pow(10, dbVolume / 20);
        }

        public void VolumeDown()
        {
            var dbVolume = (1 - (float)10 / 20) * MinDb;
            Volume = (float)Math.Pow(10, dbVolume / 20);
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
