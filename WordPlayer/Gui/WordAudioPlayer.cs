using System;
using System.CodeDom;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;
using WordPlayer.Gui;
using System.Threading;
using KeyboardInterceptor;
using NAudio.Wave;
using WordPlayer.Controller;
using WordPlayer.Utils;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private readonly IWAManager _applicationManager = new WAManager();
        private readonly KeyboardHook _hook = new KeyboardHook();

        

        private void WordPlayer_Load(object sender, RibbonUIEventArgs e)
        {
            _hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D1);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D2);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D3);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D4);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D5);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D6);
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D7);
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            var keys = e.Key;
            switch (keys)
            {
                case (Keys.D1):
                    OpenFileDialog();
                    break;
                case (Keys.D2):
                    if ()
                    if (playbackStatus != PlaybackStatus.Playing)
                    {
                        _applicationManager.Play();
                    }
                    else
                    {
                        _applicationManager.Pause();
                    }
                    break;
                case (Keys.D3):
                    _applicationManager.Rewind();
                    break;
                case (Keys.D4):
                    _applicationManager.Forward();
                    break;
                case (Keys.D5):
                    _applicationManager.VolumeUp();
                    break;
                case (Keys.D6):
                    _applicationManager.VolumeDown();
                    break;
                case (Keys.D7):

                    break;
                case (Keys.D8):

                    break;

            }
        }

        private void OpenFileDialog()
        {
            var ofd = new OpenFileDialog {Filter = "Audio Files|*.mp3;*.wav;*.aiff"};
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _applicationManager.Init(ofd.FileName);
            lbl_audio_name.Label = ofd.SafeFileName;
            lbl_time_tracker.Label = _applicationManager.GetTotalTimeOfTrack();
        }

        protected void Close()
        {
            _applicationManager.Dispose(); 
        }
        
        public void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog();
            _applicationManager.Play();
        }

        private void btn_pause_Click(object sender, RibbonControlEventArgs e)
        {
            _applicationManager.Pause();
        }

        private void btn_open_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog();
        }

        private void btn_about_Click(object sender, RibbonControlEventArgs e)
        {
            using (var aboutPanel = new AboutPanel())
            {
                aboutPanel.ShowDialog();
            }
        }

        private void btn_help_Click(object sender, RibbonControlEventArgs e)
        {
            using (var helpMenu = new HelpMenu())
            {
                helpMenu.ShowDialog();
            }
        }

        private void btn_settings_Click(object sender, RibbonControlEventArgs e)
        {
            using (var settingsMenu = new SettingsMenu())
            {
                settingsMenu.ShowDialog();
            }
        }

        private void btn_rewind_Click(object sender, RibbonControlEventArgs e)
        {
            _applicationManager.Rewind();
        }

        private void btn_forward_Click(object sender, RibbonControlEventArgs e)
        {
            _applicationManager.Forward();
        }

        private void btn_googleDriveAPI_Click(object sender, RibbonControlEventArgs e)
        {
            throw new NotImplementedException();
        }
        

        private void btn_volumeDown_Click(object sender, RibbonControlEventArgs e)
        {
            _applicationManager.VolumeDown();
        }

        private void btn_volumeUp_Click(object sender, RibbonControlEventArgs e)
        {
            _applicationManager.VolumeUp();
        }
    }
}
