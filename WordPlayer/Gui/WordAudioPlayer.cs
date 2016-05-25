using System;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;
using WordPlayer.Gui;
using System.Runtime.InteropServices;
using WordPlayer.Utils;
using System.Reflection;
using System.Linq;
using System.Threading;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private static IAudioFileController audioFile = null;
        private SynchronizationContext sContext = null;
        KeyboardHook hook = new KeyboardHook();

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {
            sContext = SynchronizationContext.Current;
            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(ModifierKeys.Control, Keys.D1);
            hook.RegisterHotKey(ModifierKeys.Control, Keys.D2);
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Keys keys = e.Key;
            switch (keys)
            {
                case (Keys.D1):
                    OpenFileDiag();
                    audioFile.Play();
                    break;
                case (Keys.D2):
                    if (audioFile != null)
                    {
                        audioFile.Pause();
                    }
                    break;
            }
        }

        public static void close()
        {
            audioFile.Dispose();
            audioFile = null;   
        }

        private void OpenFileDiag()
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
        }
        
        public void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDiag();
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
        private void btn_about_KeyPress(object sender, RibbonControlEventArgs e)
        {
            using (AboutPanel about = new AboutPanel())
            {
                about.ShowDialog();
            }
        }

        private void btn_help_Click(object sender, RibbonControlEventArgs e)
        {
            using (HelpMenu test = new HelpMenu())
            {
                test.ShowDialog();
            }
        }

        private void btn_settings_Click(object sender, RibbonControlEventArgs e)
        {
            WAStandalone frm2 = new WAStandalone();
            frm2.Show();
        }

        private void btn_rewind_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btn_forward_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
