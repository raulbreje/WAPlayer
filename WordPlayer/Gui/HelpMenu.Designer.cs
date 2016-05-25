namespace WordPlayer.Gui
{
    partial class HelpMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.rickTxtBox_about = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rickTxtBox_about
            // 
            this.rickTxtBox_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rickTxtBox_about.Location = new System.Drawing.Point(0, 0);
            this.rickTxtBox_about.Name = "rickTxtBox_about";
            this.rickTxtBox_about.Size = new System.Drawing.Size(384, 561);
            this.rickTxtBox_about.TabIndex = 0;
            this.rickTxtBox_about.Text = "";
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.rickTxtBox_about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help | WA Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rickTxtBox_about;
    }
}