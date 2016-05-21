using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private IAudioFileController audioFile = null;

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_play_Click(object sender, RibbonControlEventArgs e)
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

        private void btn_play_KeyPress(Object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Q)
            {
                audioFile.Play();
            }
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
    }
}
