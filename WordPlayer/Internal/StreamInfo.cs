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

        string fileName;
        string letter;
        AudioStream stream;
        int offsetMilliseconds;
        int delayMilliseconds;
        int volumeDecibels;

        public StreamInfo(string fileName)
        {
            this.fileName = fileName;
            this.stream = new AudioStream(fileName);
        }

        public string FileName
        {
            get { return fileName; }
        }

        public string Letter
        {
            get { return letter; }
            set { letter = value; }
        }

        public AudioStream Stream
        {
            get { return stream; }
        }

        public int OffsetMilliseconds
        {
            get { return offsetMilliseconds; }
            set
            {
                offsetMilliseconds = value;
                stream.Offset = TimeSpan.FromMilliseconds(offsetMilliseconds);
            }
        }

        public int DelayMilliseconds
        {
            get { return delayMilliseconds; }
            set
            {
                delayMilliseconds = value;
                stream.PreDelay = TimeSpan.FromMilliseconds(delayMilliseconds);
            }
        }

        public int VolumeDecibels
        {
            get
            {
                return volumeDecibels;
            }
            set
            {
                volumeDecibels = value;
                stream.Volume = (float)Decibels.DecibelsToLinear(volumeDecibels);
            }
        }
    }
}
