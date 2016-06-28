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
            this.checkBox_aac = new System.Windows.Forms.CheckBox();
            this.checkBox_aiff = new System.Windows.Forms.CheckBox();
            this.checkBox_wav = new System.Windows.Forms.CheckBox();
            this.checkBox_mp3 = new System.Windows.Forms.CheckBox();
            this.group_reporter = new System.Windows.Forms.GroupBox();
            this.rtb_reporter = new System.Windows.Forms.RichTextBox();
            this.group_interviewed = new System.Windows.Forms.GroupBox();
            this.rtb_interviewed = new System.Windows.Forms.RichTextBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.group_languages = new System.Windows.Forms.GroupBox();
            this.radioBtn_ge = new System.Windows.Forms.RadioButton();
            this.radioBtn_fr = new System.Windows.Forms.RadioButton();
            this.radioBtn_ro = new System.Windows.Forms.RadioButton();
            this.radioBtn_en = new System.Windows.Forms.RadioButton();
            this.group_audioFormats.SuspendLayout();
            this.group_reporter.SuspendLayout();
            this.group_interviewed.SuspendLayout();
            this.group_languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_audioFormats
            // 
            this.group_audioFormats.Controls.Add(this.checkBox_aac);
            this.group_audioFormats.Controls.Add(this.checkBox_aiff);
            this.group_audioFormats.Controls.Add(this.checkBox_wav);
            this.group_audioFormats.Controls.Add(this.checkBox_mp3);
            this.group_audioFormats.Location = new System.Drawing.Point(12, 67);
            this.group_audioFormats.Name = "group_audioFormats";
            this.group_audioFormats.Size = new System.Drawing.Size(560, 124);
            this.group_audioFormats.TabIndex = 1;
            this.group_audioFormats.TabStop = false;
            this.group_audioFormats.Text = "Audio Formats";
            // 
            // checkBox_aac
            // 
            this.checkBox_aac.AutoSize = true;
            this.checkBox_aac.Enabled = false;
            this.checkBox_aac.Location = new System.Drawing.Point(7, 92);
            this.checkBox_aac.Name = "checkBox_aac";
            this.checkBox_aac.Size = new System.Drawing.Size(47, 17);
            this.checkBox_aac.TabIndex = 3;
            this.checkBox_aac.Text = "AAC";
            this.checkBox_aac.UseVisualStyleBackColor = true;
            // 
            // checkBox_aiff
            // 
            this.checkBox_aiff.AutoSize = true;
            this.checkBox_aiff.Enabled = false;
            this.checkBox_aiff.Location = new System.Drawing.Point(7, 68);
            this.checkBox_aiff.Name = "checkBox_aiff";
            this.checkBox_aiff.Size = new System.Drawing.Size(48, 17);
            this.checkBox_aiff.TabIndex = 2;
            this.checkBox_aiff.Text = "AIFF";
            this.checkBox_aiff.UseVisualStyleBackColor = true;
            // 
            // checkBox_wav
            // 
            this.checkBox_wav.AutoSize = true;
            this.checkBox_wav.Checked = true;
            this.checkBox_wav.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_wav.Location = new System.Drawing.Point(6, 22);
            this.checkBox_wav.Name = "checkBox_wav";
            this.checkBox_wav.Size = new System.Drawing.Size(51, 17);
            this.checkBox_wav.TabIndex = 1;
            this.checkBox_wav.Text = "WAV";
            this.checkBox_wav.UseVisualStyleBackColor = true;
            // 
            // checkBox_mp3
            // 
            this.checkBox_mp3.AutoSize = true;
            this.checkBox_mp3.Enabled = false;
            this.checkBox_mp3.Location = new System.Drawing.Point(7, 45);
            this.checkBox_mp3.Name = "checkBox_mp3";
            this.checkBox_mp3.Size = new System.Drawing.Size(48, 17);
            this.checkBox_mp3.TabIndex = 0;
            this.checkBox_mp3.Text = "MP3";
            this.checkBox_mp3.UseVisualStyleBackColor = true;
            // 
            // group_reporter
            // 
            this.group_reporter.Controls.Add(this.rtb_reporter);
            this.group_reporter.Location = new System.Drawing.Point(12, 197);
            this.group_reporter.Name = "group_reporter";
            this.group_reporter.Size = new System.Drawing.Size(560, 110);
            this.group_reporter.TabIndex = 3;
            this.group_reporter.TabStop = false;
            this.group_reporter.Text = "Reporter";
            // 
            // rtb_reporter
            // 
            this.rtb_reporter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_reporter.Location = new System.Drawing.Point(3, 16);
            this.rtb_reporter.Name = "rtb_reporter";
            this.rtb_reporter.Size = new System.Drawing.Size(554, 91);
            this.rtb_reporter.TabIndex = 0;
            this.rtb_reporter.Text = "Default Reporter says:";
            // 
            // group_interviewed
            // 
            this.group_interviewed.Controls.Add(this.rtb_interviewed);
            this.group_interviewed.Location = new System.Drawing.Point(12, 313);
            this.group_interviewed.Name = "group_interviewed";
            this.group_interviewed.Size = new System.Drawing.Size(560, 110);
            this.group_interviewed.TabIndex = 4;
            this.group_interviewed.TabStop = false;
            this.group_interviewed.Text = "Interviewed";
            // 
            // rtb_interviewed
            // 
            this.rtb_interviewed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_interviewed.Location = new System.Drawing.Point(3, 16);
            this.rtb_interviewed.Name = "rtb_interviewed";
            this.rtb_interviewed.Size = new System.Drawing.Size(554, 91);
            this.rtb_interviewed.TabIndex = 0;
            this.rtb_interviewed.Text = "Default Interviewed answers:";
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(497, 476);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(75, 23);
            this.btn_okay.TabIndex = 5;
            this.btn_okay.Text = "OK";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // group_languages
            // 
            this.group_languages.Controls.Add(this.radioBtn_ge);
            this.group_languages.Controls.Add(this.radioBtn_fr);
            this.group_languages.Controls.Add(this.radioBtn_ro);
            this.group_languages.Controls.Add(this.radioBtn_en);
            this.group_languages.Location = new System.Drawing.Point(19, 13);
            this.group_languages.Name = "group_languages";
            this.group_languages.Size = new System.Drawing.Size(553, 48);
            this.group_languages.TabIndex = 6;
            this.group_languages.TabStop = false;
            this.group_languages.Text = "Languages";
            // 
            // radioBtn_ge
            // 
            this.radioBtn_ge.AutoSize = true;
            this.radioBtn_ge.Enabled = false;
            this.radioBtn_ge.Image = global::WordPlayer.Properties.Resources.german_flag_x12;
            this.radioBtn_ge.Location = new System.Drawing.Point(262, 19);
            this.radioBtn_ge.Name = "radioBtn_ge";
            this.radioBtn_ge.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_ge.TabIndex = 3;
            this.radioBtn_ge.Text = "German";
            this.radioBtn_ge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioBtn_ge.UseVisualStyleBackColor = true;
            // 
            // radioBtn_fr
            // 
            this.radioBtn_fr.AutoSize = true;
            this.radioBtn_fr.Enabled = false;
            this.radioBtn_fr.Image = global::WordPlayer.Properties.Resources.french_flag_x12;
            this.radioBtn_fr.Location = new System.Drawing.Point(182, 19);
            this.radioBtn_fr.Name = "radioBtn_fr";
            this.radioBtn_fr.Size = new System.Drawing.Size(74, 17);
            this.radioBtn_fr.TabIndex = 2;
            this.radioBtn_fr.Text = "French";
            this.radioBtn_fr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioBtn_fr.UseVisualStyleBackColor = true;
            // 
            // radioBtn_ro
            // 
            this.radioBtn_ro.AutoSize = true;
            this.radioBtn_ro.Enabled = false;
            this.radioBtn_ro.Image = global::WordPlayer.Properties.Resources.romanian_flag_x12;
            this.radioBtn_ro.Location = new System.Drawing.Point(87, 19);
            this.radioBtn_ro.Name = "radioBtn_ro";
            this.radioBtn_ro.Size = new System.Drawing.Size(89, 17);
            this.radioBtn_ro.TabIndex = 1;
            this.radioBtn_ro.Text = "Romanian";
            this.radioBtn_ro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioBtn_ro.UseVisualStyleBackColor = true;
            // 
            // radioBtn_en
            // 
            this.radioBtn_en.AutoSize = true;
            this.radioBtn_en.Checked = true;
            this.radioBtn_en.Image = global::WordPlayer.Properties.Resources.english_flag_x12;
            this.radioBtn_en.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioBtn_en.Location = new System.Drawing.Point(6, 19);
            this.radioBtn_en.Name = "radioBtn_en";
            this.radioBtn_en.Size = new System.Drawing.Size(75, 17);
            this.radioBtn_en.TabIndex = 0;
            this.radioBtn_en.TabStop = true;
            this.radioBtn_en.Text = "English";
            this.radioBtn_en.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioBtn_en.UseVisualStyleBackColor = true;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.group_languages);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.group_interviewed);
            this.Controls.Add(this.group_reporter);
            this.Controls.Add(this.group_audioFormats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings | Word Audio Player";
            this.group_audioFormats.ResumeLayout(false);
            this.group_audioFormats.PerformLayout();
            this.group_reporter.ResumeLayout(false);
            this.group_interviewed.ResumeLayout(false);
            this.group_languages.ResumeLayout(false);
            this.group_languages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox group_audioFormats;
        private System.Windows.Forms.CheckBox checkBox_wav;
        private System.Windows.Forms.CheckBox checkBox_mp3;
        private System.Windows.Forms.CheckBox checkBox_aac;
        private System.Windows.Forms.CheckBox checkBox_aiff;
        private System.Windows.Forms.GroupBox group_reporter;
        private System.Windows.Forms.RichTextBox rtb_reporter;
        private System.Windows.Forms.GroupBox group_interviewed;
        private System.Windows.Forms.RichTextBox rtb_interviewed;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.GroupBox group_languages;
        private System.Windows.Forms.RadioButton radioBtn_ge;
        private System.Windows.Forms.RadioButton radioBtn_fr;
        private System.Windows.Forms.RadioButton radioBtn_ro;
        private System.Windows.Forms.RadioButton radioBtn_en;
    }
}