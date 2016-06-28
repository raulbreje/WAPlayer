using System;
using System.CodeDom;
using System.Configuration;
using System.Resources;
using System.Text.RegularExpressions;
using Microsoft.Office.Tools.Ribbon;
using WordPlayer.AudioPlayer;
using System.Windows.Forms;
using WordPlayer.Gui;
using System.Threading;
using KeyboardInterceptor;
using Microsoft.Office.Interop.Word;
using NAudio.Wave;
using WordPlayer.Controller;
using WordPlayer.Internal;
using WordPlayer.Utils;
using static System.String;
using System = Microsoft.Office.Interop.Word.System;

namespace WordPlayer
{
    public partial class WordPlayer
    {

        private ThisAddIn tai;
        private readonly IWaManager _applicationManager = new WaManager();
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
            _hook.RegisterHotKey(ModifierKeys.Control, Keys.D8);
            
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
                    if (_applicationManager.GetStatus() != PlaybackStatus.Playing)
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
                    SetVolumeLabel(-10);
                    _applicationManager.VolumeUp();
                    break;
                case (Keys.D6):
                    SetVolumeLabel(10);
                    _applicationManager.VolumeDown();
                    break;
                case (Keys.D7):
                    if (reporter.Equals(Empty))
                    {
                        ContentWriter.WriteQuote(
                            Internal.Resources.SettingsResources.ResourceManager.GetString("reporter_quote"));
                    }
                    else
                    {
                        ContentWriter.WriteQuote(reporter);
                    }
                    
                    break;
                case (Keys.D8):
                    if (interviewed.Equals(Empty))
                    {
                        ContentWriter.WriteQuote(
                            Internal.Resources.SettingsResources.ResourceManager.GetString("interviewed_quote"));
                    }
                    else
                    {
                        ContentWriter.WriteQuote(interviewed);
                    }
                    break;

            }
        }
        
        private void OpenFileDialog()
        {
            var ofd = new OpenFileDialog {Filter = "Audio Files|*.mp3;*.wav;*.aiff"};
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _applicationManager.Init(ofd.FileName);
            lbl_audio_name.Label = ofd.SafeFileName;
            lbl_time_tracker.Label = _applicationManager.GetCurrentTimeOfTrack() + " / " + _applicationManager.GetTotalTimeOfTrack();
        }

        public new void Close()
        {
            _applicationManager.Dispose(); 
        }
        
        public void btn_play_Click(object sender, RibbonControlEventArgs e)
        {
            if (_applicationManager.GetStatus() == PlaybackStatus.Unloaded)
            {
                OpenFileDialog();
            }
            _applicationManager.Play();
            timer_track.Start();
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
                reporter = settingsMenu.getReporterQuoteSimulation();
                interviewed = settingsMenu.getInterviewedQuoteSimulation();
            }
        }

        private string reporter = Empty;
        private string interviewed = Empty;

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

        private void SetVolumeLabel(int arg)
        {
            var oldLabel = lbl_volume.Label;
            var integerValue = int.Parse(Regex.Match(oldLabel, @"\d+").Value);
            integerValue += arg;
            if (integerValue < 0 || integerValue > 100) return;
            var newLabel = "Volume : " + integerValue + "%";
            lbl_volume.Label = newLabel;
        }

        private void btn_volumeDown_Click(object sender, RibbonControlEventArgs e)
        {
            SetVolumeLabel(-10);
            _applicationManager.VolumeDown();
        }

        private void btn_volumeUp_Click(object sender, RibbonControlEventArgs e)
        {
            SetVolumeLabel(10);
            _applicationManager.VolumeUp();
        }

        private void timer_track_Tick(object sender, EventArgs e)
        {
            if (_applicationManager.GetStatus() == PlaybackStatus.Playing)
            {
                string curr = _applicationManager.GetCurrentTimeOfTrack();
                string max = _applicationManager.GetTotalTimeOfTrack();
                    lbl_time_tracker.Label = curr + " / " + max;
            }
        }
    }
}
