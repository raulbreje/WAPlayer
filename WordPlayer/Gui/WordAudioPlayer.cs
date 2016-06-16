using System;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;
using WordPlayer.Gui;
using System.Threading;
using KeyboardInterceptor;
using WordPlayer.Controller;
using WordPlayer.Utils;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private static IAudioFileController _audioFile = null;
        private readonly KeyboardHook _hook = new KeyboardHook();

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {
            // register the event that is fired after the key press.
            _hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D1);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D2);
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Keys keys = e.Key;
            switch (keys)
            {
                case (Keys.D1):
                    OpenFileDiag();
                    _audioFile.Play();
                    break;
                case (Keys.D2):
                    _audioFile?.Pause();
                    break;
            }
        }

        public static void close()
        {
            _audioFile.Stop();
            _audioFile.Dispose();
            _audioFile = null;   
        }

        private void OpenFileDiag()
        {
            if (_audioFile == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _audioFile = AppHelper.GetAudioFileController(ofd.FileName);
                }
            }
        }
        
        public void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDiag();
            _audioFile.Play();
        }

        private void btn_pause_Click(object sender, RibbonControlEventArgs e)
        {
            _audioFile?.Pause();
        }

        private void btn_open_Click(object sender, RibbonControlEventArgs e)
        {
            if (_audioFile != null)
            {
                _audioFile.Stop();
                _audioFile = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _audioFile = AppHelper.GetAudioFileController(ofd.FileName);
                lbl_audio_name.Label = ofd.SafeFileName;
                lbl_time_tracker.Label = _audioFile.GetTotalTimeOfTrack();
            }
        }

        private void btn_about_Click(object sender, RibbonControlEventArgs e)
        {
            using (AboutPanel aboutPanel = new AboutPanel())
            {
                aboutPanel.ShowDialog();
            }
        }

        private void btn_help_Click(object sender, RibbonControlEventArgs e)
        {
            using (HelpMenu helpMenu = new HelpMenu())
            {
                helpMenu.ShowDialog();
            }
        }

        private void btn_settings_Click(object sender, RibbonControlEventArgs e)
        {
            using (SettingsMenu settingsMenu = new SettingsMenu())
            {
                settingsMenu.ShowDialog();
            }
        }

        private void btn_rewind_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btn_forward_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btn_googleDriveAPI_Click(object sender, RibbonControlEventArgs e)
        {
            GoogleDriveController.TestConnection();
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
