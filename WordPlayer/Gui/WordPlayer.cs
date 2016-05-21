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

        private IAudioFile audioFile = null;
        private string fileName;

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {
            //btn_play.Click += new EventHandler(btn_play_KeyPress);
        }

        private void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
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
            audioFile.Pause();
        }

        private void btn_open_Click(object sender, RibbonControlEventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.fileName = ofd.FileName;
                }
            audioFile = new AudioFile(fileName);
        }
    }
}
