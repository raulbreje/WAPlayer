namespace WordPlayer.Gui
{
    partial class ShortcutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortcutMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_s_play = new System.Windows.Forms.Button();
            this.btn_s_pause = new System.Windows.Forms.Button();
            this.btn_s_rewind = new System.Windows.Forms.Button();
            this.btn_s_forward = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btn_s_play);
            this.flowLayoutPanel1.Controls.Add(this.btn_s_pause);
            this.flowLayoutPanel1.Controls.Add(this.btn_s_rewind);
            this.flowLayoutPanel1.Controls.Add(this.btn_s_forward);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btn_s_play
            // 
            this.btn_s_play.Location = new System.Drawing.Point(3, 3);
            this.btn_s_play.Name = "btn_s_play";
            this.btn_s_play.Size = new System.Drawing.Size(75, 23);
            this.btn_s_play.TabIndex = 0;
            this.btn_s_play.Text = "Play";
            this.btn_s_play.UseVisualStyleBackColor = true;
            this.btn_s_play.Click += new System.EventHandler(this.btn_s_play_Click);
            // 
            // btn_s_pause
            // 
            this.btn_s_pause.Location = new System.Drawing.Point(84, 3);
            this.btn_s_pause.Name = "btn_s_pause";
            this.btn_s_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_s_pause.TabIndex = 1;
            this.btn_s_pause.Text = "Pause";
            this.btn_s_pause.UseVisualStyleBackColor = true;
            // 
            // btn_s_rewind
            // 
            this.btn_s_rewind.Location = new System.Drawing.Point(165, 3);
            this.btn_s_rewind.Name = "btn_s_rewind";
            this.btn_s_rewind.Size = new System.Drawing.Size(75, 23);
            this.btn_s_rewind.TabIndex = 2;
            this.btn_s_rewind.Text = "Rewind";
            this.btn_s_rewind.UseVisualStyleBackColor = true;
            // 
            // btn_s_forward
            // 
            this.btn_s_forward.Location = new System.Drawing.Point(246, 3);
            this.btn_s_forward.Name = "btn_s_forward";
            this.btn_s_forward.Size = new System.Drawing.Size(75, 23);
            this.btn_s_forward.TabIndex = 3;
            this.btn_s_forward.Text = "Forward";
            this.btn_s_forward.UseVisualStyleBackColor = true;
            // 
            // ShortcutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 29);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShortcutMenu";
            this.Text = "Shortcuts";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_s_play;
        private System.Windows.Forms.Button btn_s_pause;
        private System.Windows.Forms.Button btn_s_rewind;
        private System.Windows.Forms.Button btn_s_forward;
    }
}