namespace WordPlayer.AudioPlayer
{
    public interface IWAManager
    {

        void Init(string path);

        void Play();

        void Pause();

        void Stop();

        void Forward();

        void Rewind();

        void Dispose();

        void VolumeUp();

        void VolumeDown();

        string GetTotalTimeOfTrack();

    }
}
