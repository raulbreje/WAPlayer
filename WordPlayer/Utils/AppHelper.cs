using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPlayer.AudioPlayer;
using WordPlayer.Controller;

namespace WordPlayer.Utils
{
    public class AppHelper
    {
        public static string PLAY_SPEED_1 = "0.5";
        public static string PLAY_SPEED_2 = "1";
        public static string PLAY_SPEED_3 = "1.5";
        public static string PLAY_SPEED_4 = "2";

        public static IWAManager GetAudioFileController(string path)
        {
            return new WAManager(path);
        }
    }
}
