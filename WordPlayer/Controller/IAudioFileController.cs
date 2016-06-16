namespace WordPlayer.AudioPlayer
{
    public interface IAudioFileController
    {

        void Play();

        void Pause();

        void Stop();

        void Forward();

        void Reverse();

        void Dispose();

        string GetTotalTimeOfTrack();

    }
}
