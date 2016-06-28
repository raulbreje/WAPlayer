using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Utils;

namespace WordPlayer.Internal
{
    class StreamInfo
    {
        int _offsetMilliseconds;
        int _delayMilliseconds;
        int _volumeDecibels;

        public StreamInfo(string fileName)
        {
            this.FileName = fileName;
            this.Stream = new AudioStream(fileName);
        }

        public string FileName { get; }

        public string Letter { get; set; }

        public AudioStream Stream { get; }

        public int OffsetMilliseconds
        {
            get { return _offsetMilliseconds; }
            set
            {
                _offsetMilliseconds = value;
                Stream.Offset = TimeSpan.FromMilliseconds(_offsetMilliseconds);
            }
        }

        public int DelayMilliseconds
        {
            get { return _delayMilliseconds; }
            set
            {
                _delayMilliseconds = value;
                Stream.PreDelay = TimeSpan.FromMilliseconds(_delayMilliseconds);
            }
        }

        public int VolumeDecibels
        {
            get
            {
                return _volumeDecibels;
            }
            set
            {
                _volumeDecibels = value;
                Stream.Volume = (float)Decibels.DecibelsToLinear(_volumeDecibels);
            }
        }
    }
}
