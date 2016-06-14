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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl3 = this.Factory.CreateRibbonDialogLauncher();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPlayer));
            this.tab_wordPlayer = this.Factory.CreateRibbonTab();
            this.group_customization = this.Factory.CreateRibbonGroup();
            this.group_player = this.Factory.CreateRibbonGroup();
            this.lbl_audio_name = this.Factory.CreateRibbonLabel();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.dropDown_speed = this.Factory.CreateRibbonDropDown();
            this.group_preferences = this.Factory.CreateRibbonGroup();
            this.btn_help = this.Factory.CreateRibbonButton();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.btn_about = this.Factory.CreateRibbonButton();
            this.lbl_time_tracker = this.Factory.CreateRibbonLabel();
            this.box1 = this.Factory.CreateRibbonBox();
            this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.btn_open = this.Factory.CreateRibbonButton();
            this.btn_googleDriveAPI = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.com = this.Factory.CreateRibbonButton();
            this.btn_play = this.Factory.CreateRibbonButton();
            this.btn_pause = this.Factory.CreateRibbonButton();
            this.btn_forward = this.Factory.CreateRibbonButton();
            this.tab_wordPlayer.SuspendLayout();
            this.group_customization.SuspendLayout();
            this.group_player.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.group_preferences.SuspendLayout();
            this.box1.SuspendLayout();
            this.buttonGroup2.SuspendLayout();
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
            // group_player
            // 
            this.group_player.DialogLauncher = ribbonDialogLauncherImpl2;
            this.group_player.Items.Add(this.lbl_audio_name);
            this.group_player.Items.Add(this.box1);
            this.group_player.Items.Add(this.buttonGroup1);
            this.group_player.Label = "Player";
            this.group_player.Name = "group_player";
            this.group_player.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_settings_Click);
            // 
            // lbl_audio_name
            // 
            this.lbl_audio_name.Label = "No audio file loaded";
            this.lbl_audio_name.Name = "lbl_audio_name";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.com);
            this.buttonGroup1.Items.Add(this.btn_play);
            this.buttonGroup1.Items.Add(this.btn_pause);
            this.buttonGroup1.Items.Add(this.btn_forward);
            this.buttonGroup1.Name = "buttonGroup1";
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
            // group_preferences
            // 
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
            // lbl_time_tracker
            // 
            this.lbl_time_tracker.Label = "0:00:00 / 4:31:12";
            this.lbl_time_tracker.Name = "lbl_time_tracker";
            // 
            // box1
            // 
            this.box1.Items.Add(this.lbl_time_tracker);
            this.box1.Items.Add(this.buttonGroup2);
            this.box1.Items.Add(this.label1);
            this.box1.Name = "box1";
            // 
            // buttonGroup2
            // 
            this.buttonGroup2.Items.Add(this.button1);
            this.buttonGroup2.Items.Add(this.button2);
            this.buttonGroup2.Name = "buttonGroup2";
            // 
            // label1
            // 
            this.label1.Label = "Volume : 80%";
            this.label1.Name = "label1";
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
            // button1
            // 
            this.button1.Image = global::WordPlayer.Properties.Resources.volume_up_btn_image_x18;
            this.button1.Label = "Up";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::WordPlayer.Properties.Resources.volume_down_btn_image_x18;
            this.button2.Label = "Down";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
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
            // btn_forward
            // 
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.Label = "Forward";
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.ShowImage = true;
            this.btn_forward.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_forward_Click);
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
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.group_preferences.ResumeLayout(false);
            this.group_preferences.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.buttonGroup2.ResumeLayout(false);
            this.buttonGroup2.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_speed;
        internal RibbonButton btn_googleDriveAPI;
        internal RibbonButton com;
        internal RibbonButton btn_forward;
        internal RibbonLabel lbl_audio_name;
        internal RibbonBox box1;
        internal RibbonLabel lbl_time_tracker;
        internal RibbonButtonGroup buttonGroup2;
        internal RibbonButton button1;
        internal RibbonButton button2;
        internal RibbonLabel label1;
    }

    partial class ThisRibbonCollection
    {
        internal WordPlayer WordPlayer
        {
            get { return this.GetRibbon<WordPlayer>(); }
        }
    }
}
