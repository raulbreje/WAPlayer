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
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btn_play = this.Factory.CreateRibbonButton();
            this.btn_pause = this.Factory.CreateRibbonButton();
            this.btn_open = this.Factory.CreateRibbonButton();
            this.group_player = this.Factory.CreateRibbonGroup();
            this.group_preferences = this.Factory.CreateRibbonGroup();
            this.btn_help = this.Factory.CreateRibbonButton();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.btn_about = this.Factory.CreateRibbonButton();
            this.tab_wordPlayer.SuspendLayout();
            this.group1.SuspendLayout();
            this.group_preferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_wordPlayer
            // 
            this.tab_wordPlayer.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab_wordPlayer.Groups.Add(this.group1);
            this.tab_wordPlayer.Groups.Add(this.group_player);
            this.tab_wordPlayer.Groups.Add(this.group_preferences);
            this.tab_wordPlayer.Label = "Word Audio Player";
            this.tab_wordPlayer.Name = "tab_wordPlayer";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btn_play);
            this.group1.Items.Add(this.btn_pause);
            this.group1.Items.Add(this.btn_open);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btn_play
            // 
            this.btn_play.Label = "Play";
            this.btn_play.Name = "btn_play";
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
            // group_player
            // 
            this.group_player.Label = "Player";
            this.group_player.Name = "group_player";
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
            // WordPlayer
            // 
            this.Name = "WordPlayer";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab_wordPlayer);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WordPlayer_Load);
            this.tab_wordPlayer.ResumeLayout(false);
            this.tab_wordPlayer.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group_preferences.ResumeLayout(false);
            this.group_preferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_wordPlayer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_play;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_pause;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_open;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_player;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_preferences;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_help;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_about;
    }

    partial class ThisRibbonCollection
    {
        internal WordPlayer WordPlayer
        {
            get { return this.GetRibbon<WordPlayer>(); }
        }
    }
}
