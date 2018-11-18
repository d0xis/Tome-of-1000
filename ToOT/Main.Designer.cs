namespace ToOT
{
    partial class Main_frm
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
            this.Vol1_pic = new System.Windows.Forms.PictureBox();
            this.Vol2_pic = new System.Windows.Forms.PictureBox();
            this.Vol4_pic = new System.Windows.Forms.PictureBox();
            this.Vol3_pic = new System.Windows.Forms.PictureBox();
            this.Select_lbl = new System.Windows.Forms.Label();
            this.Select_group = new System.Windows.Forms.GroupBox();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.Back1_lbl = new System.Windows.Forms.Label();
            this.Vol1_group = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vol1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3_pic)).BeginInit();
            this.Select_group.SuspendLayout();
            this.Vol1_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vol1_pic
            // 
            this.Vol1_pic.Image = global::ToOT.Properties.Resources.G_U__Rebirth;
            this.Vol1_pic.Location = new System.Drawing.Point(12, 84);
            this.Vol1_pic.Name = "Vol1_pic";
            this.Vol1_pic.Size = new System.Drawing.Size(245, 304);
            this.Vol1_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol1_pic.TabIndex = 0;
            this.Vol1_pic.TabStop = false;
            this.Vol1_pic.Click += new System.EventHandler(this.Vol1_pic_Click);
            // 
            // Vol2_pic
            // 
            this.Vol2_pic.Image = global::ToOT.Properties.Resources.G_U__Reminisce;
            this.Vol2_pic.Location = new System.Drawing.Point(263, 84);
            this.Vol2_pic.Name = "Vol2_pic";
            this.Vol2_pic.Size = new System.Drawing.Size(245, 304);
            this.Vol2_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol2_pic.TabIndex = 1;
            this.Vol2_pic.TabStop = false;
            this.Vol2_pic.Click += new System.EventHandler(this.Vol2_pic_Click);
            // 
            // Vol4_pic
            // 
            this.Vol4_pic.Image = global::ToOT.Properties.Resources.G_U__Reconnection;
            this.Vol4_pic.Location = new System.Drawing.Point(765, 84);
            this.Vol4_pic.Name = "Vol4_pic";
            this.Vol4_pic.Size = new System.Drawing.Size(245, 304);
            this.Vol4_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol4_pic.TabIndex = 3;
            this.Vol4_pic.TabStop = false;
            this.Vol4_pic.Click += new System.EventHandler(this.Vol4_pic_Click);
            // 
            // Vol3_pic
            // 
            this.Vol3_pic.Image = global::ToOT.Properties.Resources.G_U__Redemption;
            this.Vol3_pic.Location = new System.Drawing.Point(514, 84);
            this.Vol3_pic.Name = "Vol3_pic";
            this.Vol3_pic.Size = new System.Drawing.Size(245, 304);
            this.Vol3_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol3_pic.TabIndex = 2;
            this.Vol3_pic.TabStop = false;
            this.Vol3_pic.Click += new System.EventHandler(this.Vol3_pic_Click);
            // 
            // Select_lbl
            // 
            this.Select_lbl.AutoSize = true;
            this.Select_lbl.Font = new System.Drawing.Font("dotHack//FONT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_lbl.Location = new System.Drawing.Point(221, 16);
            this.Select_lbl.Name = "Select_lbl";
            this.Select_lbl.Size = new System.Drawing.Size(574, 59);
            this.Select_lbl.TabIndex = 4;
            this.Select_lbl.Text = ". SELECT . VOLUME .";
            // 
            // Select_group
            // 
            this.Select_group.Controls.Add(this.Exit_lbl);
            this.Select_group.Controls.Add(this.Vol1_pic);
            this.Select_group.Controls.Add(this.Select_lbl);
            this.Select_group.Controls.Add(this.Vol2_pic);
            this.Select_group.Controls.Add(this.Vol4_pic);
            this.Select_group.Controls.Add(this.Vol3_pic);
            this.Select_group.Enabled = false;
            this.Select_group.Location = new System.Drawing.Point(0, -10);
            this.Select_group.Name = "Select_group";
            this.Select_group.Size = new System.Drawing.Size(1031, 404);
            this.Select_group.TabIndex = 5;
            this.Select_group.TabStop = false;
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("dotHack//FONT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.Location = new System.Drawing.Point(977, 16);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(35, 16);
            this.Exit_lbl.TabIndex = 5;
            this.Exit_lbl.Text = "Exit";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Back1_lbl
            // 
            this.Back1_lbl.AutoSize = true;
            this.Back1_lbl.Font = new System.Drawing.Font("dotHack//FONT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1_lbl.Location = new System.Drawing.Point(13, 16);
            this.Back1_lbl.Name = "Back1_lbl";
            this.Back1_lbl.Size = new System.Drawing.Size(57, 16);
            this.Back1_lbl.TabIndex = 6;
            this.Back1_lbl.Text = "< Back";
            this.Back1_lbl.Click += new System.EventHandler(this.Back1_lbl_Click);
            // 
            // Vol1_group
            // 
            this.Vol1_group.Controls.Add(this.Back1_lbl);
            this.Vol1_group.Location = new System.Drawing.Point(0, -1000);
            this.Vol1_group.Name = "Vol1_group";
            this.Vol1_group.Size = new System.Drawing.Size(1030, 720);
            this.Vol1_group.TabIndex = 7;
            this.Vol1_group.TabStop = false;
            this.Vol1_group.Text = "groupBox1";
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1024, 711);
            this.ControlBox = false;
            this.Controls.Add(this.Vol1_group);
            this.Controls.Add(this.Select_group);
            this.ForeColor = System.Drawing.Color.Lime;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_frm";
            this.ShowIcon = false;
            this.Text = "Tome of 1000";
            this.Load += new System.EventHandler(this.Main_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vol1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3_pic)).EndInit();
            this.Select_group.ResumeLayout(false);
            this.Select_group.PerformLayout();
            this.Vol1_group.ResumeLayout(false);
            this.Vol1_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Vol1_pic;
        private System.Windows.Forms.PictureBox Vol2_pic;
        private System.Windows.Forms.PictureBox Vol4_pic;
        private System.Windows.Forms.PictureBox Vol3_pic;
        private System.Windows.Forms.Label Select_lbl;
        private System.Windows.Forms.GroupBox Select_group;
        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.Label Back1_lbl;
        private System.Windows.Forms.GroupBox Vol1_group;
    }
}

