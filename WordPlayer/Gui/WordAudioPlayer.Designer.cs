using Microsoft.Office.Tools.Ribbon;
using WordPlayer.Utils;

namespace WordPlayer
{
    partial class WordPlayer : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WordPlayer()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();

        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPlayer));
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl3 = this.Factory.CreateRibbonDialogLauncher();
            this.tab_wordPlayer = this.Factory.CreateRibbonTab();
            this.group_customization = this.Factory.CreateRibbonGroup();
            this.btn_open = this.Factory.CreateRibbonButton();
            this.btn_googleDriveAPI = this.Factory.CreateRibbonButton();
            this.dropDown_speed = this.Factory.CreateRibbonDropDown();
            this.group_player = this.Factory.CreateRibbonGroup();
            this.lbl_audio_name = this.Factory.CreateRibbonLabel();
            this.box_audioData = this.Factory.CreateRibbonBox();
            this.lbl_time_tracker = this.Factory.CreateRibbonLabel();
            this.btnGroupVolumeControl = this.Factory.CreateRibbonButtonGroup();
            this.btn_volumeUp = this.Factory.CreateRibbonButton();
            this.btn_volumeDown = this.Factory.CreateRibbonButton();
            this.lbl_volume = this.Factory.CreateRibbonLabel();
            this.btnGroupAudioControl = this.Factory.CreateRibbonButtonGroup();
            this.com = this.Factory.CreateRibbonButton();
            this.btn_play = this.Factory.CreateRibbonButton();
            this.btn_pause = this.Factory.CreateRibbonButton();
            this.btn_stop = this.Factory.CreateRibbonButton();
            this.btn_forward = this.Factory.CreateRibbonButton();
            this.group_preferences = this.Factory.CreateRibbonGroup();
            this.btn_help = this.Factory.CreateRibbonButton();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.btn_about = this.Factory.CreateRibbonButton();
            this.timer_track = new System.Windows.Forms.Timer(this.components);
            this.tab_wordPlayer.SuspendLayout();
            this.group_customization.SuspendLayout();
            this.group_player.SuspendLayout();
            this.box_audioData.SuspendLayout();
            this.btnGroupVolumeControl.SuspendLayout();
            this.btnGroupAudioControl.SuspendLayout();
            this.group_preferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_wordPlayer
            // 
            this.tab_wordPlayer.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab_wordPlayer.Groups.Add(this.group_customization);
            this.tab_wordPlayer.Groups.Add(this.group_player);
            this.tab_wordPlayer.Groups.Add(this.group_preferences);
            this.tab_wordPlayer.Label = "Word Audio Player";
            this.tab_wordPlayer.Name = "tab_wordPlayer";
            // 
            // group_customization
            // 
            ribbonDialogLauncherImpl1.Enabled = false;
            this.group_customization.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group_customization.Items.Add(this.btn_open);
            this.group_customization.Items.Add(this.btn_googleDriveAPI);
            this.group_customization.Items.Add(this.dropDown_speed);
            this.group_customization.Label = "Customization";
            this.group_customization.Name = "group_customization";
            // 
            // btn_open
            // 
            this.btn_open.Image = global::WordPlayer.Properties.Resources.open_btn_image_x18;
            this.btn_open.Label = "Open";
            this.btn_open.Name = "btn_open";
            this.btn_open.ShowImage = true;
            this.btn_open.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_open_Click);
            // 
            // btn_googleDriveAPI
            // 
            this.btn_googleDriveAPI.Image = global::WordPlayer.Properties.Resources.google_drive_image_x18;
            this.btn_googleDriveAPI.Label = "Connect to Google Drive";
            this.btn_googleDriveAPI.Name = "btn_googleDriveAPI";
            this.btn_googleDriveAPI.ScreenTip = "Connect to your Google Drive";
            this.btn_googleDriveAPI.ShowImage = true;
            this.btn_googleDriveAPI.Visible = false;
            this.btn_googleDriveAPI.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_googleDriveAPI_Click);
            // 
            // dropDown_speed
            // 
            ribbonDropDownItemImpl1.Label = "1";
            ribbonDropDownItemImpl2.Label = "0.5";
            ribbonDropDownItemImpl3.Label = "1.5";
            ribbonDropDownItemImpl4.Label = "2";
            this.dropDown_speed.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown_speed.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown_speed.Items.Add(ribbonDropDownItemImpl3);
            this.dropDown_speed.Items.Add(ribbonDropDownItemImpl4);
            this.dropDown_speed.Label = "Speed";
            this.dropDown_speed.Name = "dropDown_speed";
            // 
            // group_player
            // 
            this.group_player.DialogLauncher = ribbonDialogLauncherImpl2;
            this.group_player.Items.Add(this.lbl_audio_name);
            this.group_player.Items.Add(this.box_audioData);
            this.group_player.Items.Add(this.btnGroupAudioControl);
            this.group_player.Label = "Audio Player";
            this.group_player.Name = "group_player";
            this.group_player.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_settings_Click);
            // 
            // lbl_audio_name
            // 
            this.lbl_audio_name.Label = "No audio file loaded";
            this.lbl_audio_name.Name = "lbl_audio_name";
            // 
            // box_audioData
            // 
            this.box_audioData.Items.Add(this.lbl_time_tracker);
            this.box_audioData.Items.Add(this.btnGroupVolumeControl);
            this.box_audioData.Items.Add(this.lbl_volume);
            this.box_audioData.Name = "box_audioData";
            // 
            // lbl_time_tracker
            // 
            this.lbl_time_tracker.Label = "00:00 / 00:00";
            this.lbl_time_tracker.Name = "lbl_time_tracker";
            // 
            // btnGroupVolumeControl
            // 
            this.btnGroupVolumeControl.Items.Add(this.btn_volumeUp);
            this.btnGroupVolumeControl.Items.Add(this.btn_volumeDown);
            this.btnGroupVolumeControl.Name = "btnGroupVolumeControl";
            // 
            // btn_volumeUp
            // 
            this.btn_volumeUp.Image = global::WordPlayer.Properties.Resources.volume_up_btn_image_x18;
            this.btn_volumeUp.Label = "Up";
            this.btn_volumeUp.Name = "btn_volumeUp";
            this.btn_volumeUp.ShowImage = true;
            this.btn_volumeUp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_volumeUp_Click);
            // 
            // btn_volumeDown
            // 
            this.btn_volumeDown.Image = global::WordPlayer.Properties.Resources.volume_down_btn_image_x18;
            this.btn_volumeDown.Label = "Down";
            this.btn_volumeDown.Name = "btn_volumeDown";
            this.btn_volumeDown.ShowImage = true;
            this.btn_volumeDown.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_volumeDown_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.Label = "Volume : 100%";
            this.lbl_volume.Name = "lbl_volume";
            // 
            // btnGroupAudioControl
            // 
            this.btnGroupAudioControl.Items.Add(this.com);
            this.btnGroupAudioControl.Items.Add(this.btn_play);
            this.btnGroupAudioControl.Items.Add(this.btn_pause);
            this.btnGroupAudioControl.Items.Add(this.btn_stop);
            this.btnGroupAudioControl.Items.Add(this.btn_forward);
            this.btnGroupAudioControl.Name = "btnGroupAudioControl";
            // 
            // com
            // 
            this.com.Image = global::WordPlayer.Properties.Resources.rewind_btn_image_x18;
            this.com.Label = "Rewind";
            this.com.Name = "com";
            this.com.ShowImage = true;
            this.com.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_rewind_Click);
            // 
            // btn_play
            // 
            this.btn_play.Image = global::WordPlayer.Properties.Resources.play_btn_image_x18;
            this.btn_play.Label = "Play";
            this.btn_play.Name = "btn_play";
            this.btn_play.ShowImage = true;
            this.btn_play.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Image = global::WordPlayer.Properties.Resources.pause_btn_image_x18;
            this.btn_pause.Label = "Pause";
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.ShowImage = true;
            this.btn_pause.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = global::WordPlayer.Properties.Resources.stop_btn_image_x18;
            this.btn_stop.Label = "Stop";
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.ShowImage = true;
            this.btn_stop.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_stop_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.Label = "Forward";
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.ShowImage = true;
            this.btn_forward.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_forward_Click);
            // 
            // group_preferences
            // 
            ribbonDialogLauncherImpl3.Enabled = false;
            this.group_preferences.DialogLauncher = ribbonDialogLauncherImpl3;
            this.group_preferences.Items.Add(this.btn_help);
            this.group_preferences.Items.Add(this.btn_settings);
            this.group_preferences.Items.Add(this.btn_about);
            this.group_preferences.Label = "   Preferences   ";
            this.group_preferences.Name = "group_preferences";
            // 
            // btn_help
            // 
            this.btn_help.Label = "Help";
            this.btn_help.Name = "btn_help";
            this.btn_help.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_help_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Label = "Settings";
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_settings_Click);
            // 
            // btn_about
            // 
            this.btn_about.Label = "About";
            this.btn_about.Name = "btn_about";
            this.btn_about.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_about_Click);
            // 
            // timer_track
            // 
            this.timer_track.Interval = 200;
            this.timer_track.Tick += new System.EventHandler(this.timer_track_Tick);
            // 
            // WordPlayer
            // 
            this.Name = "WordPlayer";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab_wordPlayer);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WordPlayer_Load);
            this.tab_wordPlayer.ResumeLayout(false);
            this.tab_wordPlayer.PerformLayout();
            this.group_customization.ResumeLayout(false);
            this.group_customization.PerformLayout();
            this.group_player.ResumeLayout(false);
            this.group_player.PerformLayout();
            this.box_audioData.ResumeLayout(false);
            this.box_audioData.PerformLayout();
            this.btnGroupVolumeControl.ResumeLayout(false);
            this.btnGroupVolumeControl.PerformLayout();
            this.btnGroupAudioControl.ResumeLayout(false);
            this.btnGroupAudioControl.PerformLayout();
            this.group_preferences.ResumeLayout(false);
            this.group_preferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_wordPlayer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_player;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_play;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_pause;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_open;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_customization;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_preferences;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_help;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_about;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup btnGroupAudioControl;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_speed;
        internal RibbonButton btn_googleDriveAPI;
        internal RibbonButton com;
        internal RibbonButton btn_forward;
        internal RibbonLabel lbl_audio_name;
        internal RibbonBox box_audioData;
        internal RibbonLabel lbl_time_tracker;
        internal RibbonButtonGroup btnGroupVolumeControl;
        internal RibbonButton btn_volumeUp;
        internal RibbonButton btn_volumeDown;
        internal RibbonLabel lbl_volume;
        private System.Windows.Forms.Timer timer_track;
        internal RibbonButton btn_stop;
    }

    partial class ThisRibbonCollection
    {
        internal WordPlayer WordPlayer
        {
            get { return this.GetRibbon<WordPlayer>(); }
        }
    }
}
