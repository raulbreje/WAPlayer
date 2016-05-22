using System;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;
using WordPlayer.Gui;
using System.Runtime.InteropServices;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private static IAudioFileController audioFile = null;

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {

        }

        public static void close()
        {
            audioFile.Dispose();
            audioFile = null;   
        }
        
        public void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
            if (audioFile == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    audioFile = new AudioFileController(ofd.FileName);
                }
            }
            audioFile.Play();
        }

        private void btn_pause_Click(object sender, RibbonControlEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Pause();
            }
        }

        private void btn_open_Click(object sender, RibbonControlEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Stop();
                audioFile = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                audioFile = new AudioFileController(ofd.FileName);
            }
        }

        private void btn_about_Click(object sender, RibbonControlEventArgs e)
        {
            using (AboutPanel about = new AboutPanel())
            {
                about.ShowDialog();
            }
        }
    }
}
