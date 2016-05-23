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
            this.tab_wordPlayer = this.Factory.CreateRibbonTab();
            this.group_player = this.Factory.CreateRibbonGroup();
            this.btn_play = this.Factory.CreateRibbonButton();
            this.btn_pause = this.Factory.CreateRibbonButton();
            this.btn_open = this.Factory.CreateRibbonButton();
            this.group_customization = this.Factory.CreateRibbonGroup();
            this.group_preferences = this.Factory.CreateRibbonGroup();
            this.btn_help = this.Factory.CreateRibbonButton();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.btn_about = this.Factory.CreateRibbonButton();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.comboBox_speed = this.Factory.CreateRibbonComboBox();
            this.tab_wordPlayer.SuspendLayout();
            this.group_player.SuspendLayout();
            this.group_customization.SuspendLayout();
            this.group_preferences.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
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
            // group_player
            // 
            this.group_player.Items.Add(this.buttonGroup1);
            this.group_player.Label = "Player";
            this.group_player.Name = "group_player";
            // 
            // btn_play
            // 
            this.btn_play.Image = global::WordPlayer.Properties.Resources.play_btn_image;
            this.btn_play.Label = "Play";
            this.btn_play.Name = "btn_play";
            this.btn_play.ShowImage = true;
            this.btn_play.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Label = "Pause";
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_pause_Click);
            // 
            // btn_open
            // 
            this.btn_open.Label = "Open";
            this.btn_open.Name = "btn_open";
            this.btn_open.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_open_Click);
            // 
            // group_customization
            // 
            this.group_customization.Items.Add(this.comboBox_speed);
            this.group_customization.Label = "Customization";
            this.group_customization.Name = "group_customization";
            // 
            // group_preferences
            // 
            this.group_preferences.Items.Add(this.btn_help);
            this.group_preferences.Items.Add(this.btn_settings);
            this.group_preferences.Items.Add(this.btn_about);
            this.group_preferences.Label = "Preferences";
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
            // 
            // btn_about
            // 
            this.btn_about.Label = "About";
            this.btn_about.Name = "btn_about";
            this.btn_about.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_about_Click);
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.btn_open);
            this.buttonGroup1.Items.Add(this.btn_play);
            this.buttonGroup1.Items.Add(this.btn_pause);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.Label = "Speed";
            this.comboBox_speed.Name = "comboBox_speed";
            // 
            // WordPlayer
            // 
            this.Name = "WordPlayer";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab_wordPlayer);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WordPlayer_Load);
            this.tab_wordPlayer.ResumeLayout(false);
            this.tab_wordPlayer.PerformLayout();
            this.group_player.ResumeLayout(false);
            this.group_player.PerformLayout();
            this.group_customization.ResumeLayout(false);
            this.group_customization.PerformLayout();
            this.group_preferences.ResumeLayout(false);
            this.group_preferences.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox_speed;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
    }

    partial class ThisRibbonCollection
    {
        internal WordPlayer WordPlayer
        {
            get { return this.GetRibbon<WordPlayer>(); }
        }
    }
}
