namespace WordPlayer.Gui
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.group_audioFormats = new System.Windows.Forms.GroupBox();
            this.checkBox_wav = new System.Windows.Forms.CheckBox();
            this.checkBox_mp3 = new System.Windows.Forms.CheckBox();
            this.checkBox_aiff = new System.Windows.Forms.CheckBox();
            this.checkBox_aac = new System.Windows.Forms.CheckBox();
            this.group_audioFormats.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_audioFormats
            // 
            this.group_audioFormats.Controls.Add(this.checkBox_aac);
            this.group_audioFormats.Controls.Add(this.checkBox_aiff);
            this.group_audioFormats.Controls.Add(this.checkBox_wav);
            this.group_audioFormats.Controls.Add(this.checkBox_mp3);
            this.group_audioFormats.Location = new System.Drawing.Point(16, 126);
            this.group_audioFormats.Name = "group_audioFormats";
            this.group_audioFormats.Size = new System.Drawing.Size(556, 124);
            this.group_audioFormats.TabIndex = 1;
            this.group_audioFormats.TabStop = false;
            this.group_audioFormats.Text = "Audio Formats";
            // 
            // checkBox_wav
            // 
            this.checkBox_wav.AutoSize = true;
            this.checkBox_wav.Location = new System.Drawing.Point(7, 44);
            this.checkBox_wav.Name = "checkBox_wav";
            this.checkBox_wav.Size = new System.Drawing.Size(51, 17);
            this.checkBox_wav.TabIndex = 1;
            this.checkBox_wav.Text = "WAV";
            this.checkBox_wav.UseVisualStyleBackColor = true;
            // 
            // checkBox_mp3
            // 
            this.checkBox_mp3.AutoSize = true;
            this.checkBox_mp3.Location = new System.Drawing.Point(7, 20);
            this.checkBox_mp3.Name = "checkBox_mp3";
            this.checkBox_mp3.Size = new System.Drawing.Size(48, 17);
            this.checkBox_mp3.TabIndex = 0;
            this.checkBox_mp3.Text = "MP3";
            this.checkBox_mp3.UseVisualStyleBackColor = true;
            // 
            // checkBox_aiff
            // 
            this.checkBox_aiff.AutoSize = true;
            this.checkBox_aiff.Location = new System.Drawing.Point(7, 68);
            this.checkBox_aiff.Name = "checkBox_aiff";
            this.checkBox_aiff.Size = new System.Drawing.Size(48, 17);
            this.checkBox_aiff.TabIndex = 2;
            this.checkBox_aiff.Text = "AIFF";
            this.checkBox_aiff.UseVisualStyleBackColor = true;
            // 
            // checkBox_aac
            // 
            this.checkBox_aac.AutoSize = true;
            this.checkBox_aac.Location = new System.Drawing.Point(7, 92);
            this.checkBox_aac.Name = "checkBox_aac";
            this.checkBox_aac.Size = new System.Drawing.Size(47, 17);
            this.checkBox_aac.TabIndex = 3;
            this.checkBox_aac.Text = "AAC";
            this.checkBox_aac.UseVisualStyleBackColor = true;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.group_audioFormats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings | Word Audio Player";
            this.group_audioFormats.ResumeLayout(false);
            this.group_audioFormats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox group_audioFormats;
        private System.Windows.Forms.CheckBox checkBox_wav;
        private System.Windows.Forms.CheckBox checkBox_mp3;
        private System.Windows.Forms.CheckBox checkBox_aac;
        private System.Windows.Forms.CheckBox checkBox_aiff;
    }
}