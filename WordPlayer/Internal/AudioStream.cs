using System;
using NAudio.Wave;

namespace WordPlayer.Internal
{
    public class AudioStream : WaveStream
    {
        private readonly WaveOffsetStream _offsetStream;
        private readonly WaveChannel32 _channelSteam;
        private bool _muted;
        private float _volume;

        public AudioStream(string fileName)
        {
            var reader = new WaveFileReader(fileName);
            _offsetStream = new WaveOffsetStream(reader);
            _channelSteam = new WaveChannel32(_offsetStream);
            _muted = false;
            _volume = 1.0f;
        }

        public override int BlockAlign => _channelSteam.BlockAlign;

        public override WaveFormat WaveFormat => _channelSteam.WaveFormat;

        public override long Length => _channelSteam.Length;

        public override long Position
        {
            get
            {
                return _channelSteam.Position;
            }
            set
            {
                _channelSteam.Position = value;
            }
        }

        public bool Mute
        {
            get
            {
                return _muted;
            }
            set
            {
                _muted = value;
                if (_muted)
                {
                    _channelSteam.Volume = 0.0f;
                }
                else
                {              
                    Volume = Volume;
                }
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _channelSteam.Read(buffer, offset, count);
        }

        public override bool HasData(int count)
        {
            return _channelSteam.HasData(count);
        }

        public float Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
                if (!Mute)
                {
                    _channelSteam.Volume = _volume;
                }
            }
        }

        public TimeSpan PreDelay
        {
            get { return _offsetStream.StartTime; }
            set { _offsetStream.StartTime = value; }
        }

        public TimeSpan Offset
        {
            get { return _offsetStream.SourceOffset; }
            set { _offsetStream.SourceOffset = value; }
        }

        protected override void Dispose(bool disposing)
        {
            _channelSteam?.Dispose();

            base.Dispose(disposing);
        }
    }
}
