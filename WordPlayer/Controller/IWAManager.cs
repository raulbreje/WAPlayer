using WordPlayer.Controller;

namespace WordPlayer.AudioPlayer
{
    public interface IWaManager
    {

        void SetStatus(PlaybackStatus status);

        PlaybackStatus GetStatus();

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

        long GetPositionFromMixer();

        long GetLengthFromMixer();

        string GetCurrentTimeOfTrack();

    }
}
