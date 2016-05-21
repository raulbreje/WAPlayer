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
            this.tab_wordPlayer.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_wordPlayer
            // 
            this.tab_wordPlayer.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab_wordPlayer.Groups.Add(this.group1);
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
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_wordPlayer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_play;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_pause;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_open;
    }

    partial class ThisRibbonCollection
    {
        internal WordPlayer WordPlayer
        {
            get { return this.GetRibbon<WordPlayer>(); }
        }
    }
}
