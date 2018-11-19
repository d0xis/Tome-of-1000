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
            this.Start_group = new System.Windows.Forms.GroupBox();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new System.Windows.Forms.Label();
            this.ListGroup = new System.Windows.Forms.GroupBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.Hide_chk = new System.Windows.Forms.CheckBox();
            this.aTree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.Vol1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3_pic)).BeginInit();
            this.Start_group.SuspendLayout();
            this.ListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vol1_pic
            // 
            this.Vol1_pic.Image = global::ToOT.Properties.Resources.G_U__Rebirth;
            this.Vol1_pic.Location = new System.Drawing.Point(12, 71);
            this.Vol1_pic.Name = "Vol1_pic";
            this.Vol1_pic.Size = new System.Drawing.Size(245, 257);
            this.Vol1_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol1_pic.TabIndex = 0;
            this.Vol1_pic.TabStop = false;
            this.Vol1_pic.Click += new System.EventHandler(this.Vol1_pic_Click);
            // 
            // Vol2_pic
            // 
            this.Vol2_pic.Image = global::ToOT.Properties.Resources.G_U__Reminisce;
            this.Vol2_pic.Location = new System.Drawing.Point(263, 71);
            this.Vol2_pic.Name = "Vol2_pic";
            this.Vol2_pic.Size = new System.Drawing.Size(245, 257);
            this.Vol2_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol2_pic.TabIndex = 1;
            this.Vol2_pic.TabStop = false;
            this.Vol2_pic.Click += new System.EventHandler(this.Vol2_pic_Click);
            // 
            // Vol4_pic
            // 
            this.Vol4_pic.Image = global::ToOT.Properties.Resources.G_U__Reconnection;
            this.Vol4_pic.Location = new System.Drawing.Point(765, 71);
            this.Vol4_pic.Name = "Vol4_pic";
            this.Vol4_pic.Size = new System.Drawing.Size(245, 257);
            this.Vol4_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol4_pic.TabIndex = 3;
            this.Vol4_pic.TabStop = false;
            this.Vol4_pic.Click += new System.EventHandler(this.Vol4_pic_Click);
            // 
            // Vol3_pic
            // 
            this.Vol3_pic.Image = global::ToOT.Properties.Resources.G_U__Redemption;
            this.Vol3_pic.Location = new System.Drawing.Point(514, 71);
            this.Vol3_pic.Name = "Vol3_pic";
            this.Vol3_pic.Size = new System.Drawing.Size(245, 257);
            this.Vol3_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vol3_pic.TabIndex = 2;
            this.Vol3_pic.TabStop = false;
            this.Vol3_pic.Click += new System.EventHandler(this.Vol3_pic_Click);
            // 
            // Select_lbl
            // 
            this.Select_lbl.AutoSize = true;
            this.Select_lbl.Font = new System.Drawing.Font("dotHack//FONT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_lbl.Location = new System.Drawing.Point(221, 14);
            this.Select_lbl.Name = "Select_lbl";
            this.Select_lbl.Size = new System.Drawing.Size(574, 59);
            this.Select_lbl.TabIndex = 4;
            this.Select_lbl.Text = ". SELECT . VOLUME .";
            // 
            // Start_group
            // 
            this.Start_group.Controls.Add(this.Exit_lbl);
            this.Start_group.Controls.Add(this.Vol1_pic);
            this.Start_group.Controls.Add(this.Select_lbl);
            this.Start_group.Controls.Add(this.Vol2_pic);
            this.Start_group.Controls.Add(this.Vol4_pic);
            this.Start_group.Controls.Add(this.Vol3_pic);
            this.Start_group.Enabled = false;
            this.Start_group.Location = new System.Drawing.Point(0, -846);
            this.Start_group.Name = "Start_group";
            this.Start_group.Size = new System.Drawing.Size(1031, 342);
            this.Start_group.TabIndex = 5;
            this.Start_group.TabStop = false;
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("dotHack//FONT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.Location = new System.Drawing.Point(977, 14);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(35, 16);
            this.Exit_lbl.TabIndex = 5;
            this.Exit_lbl.Text = "Exit";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Back_lbl
            // 
            this.Back_lbl.AutoSize = true;
            this.Back_lbl.Font = new System.Drawing.Font("dotHack//FONT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_lbl.Location = new System.Drawing.Point(13, 14);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(104, 28);
            this.Back_lbl.TabIndex = 6;
            this.Back_lbl.Text = "< Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back1_lbl_Click);
            // 
            // ListGroup
            // 
            this.ListGroup.Controls.Add(this.InfoBox);
            this.ListGroup.Controls.Add(this.Hide_chk);
            this.ListGroup.Controls.Add(this.aTree);
            this.ListGroup.Controls.Add(this.Back_lbl);
            this.ListGroup.Location = new System.Drawing.Point(0, -1000);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(1030, 609);
            this.ListGroup.TabIndex = 7;
            this.ListGroup.TabStop = false;
            this.ListGroup.Text = "groupBox1";
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InfoBox.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.White;
            this.InfoBox.Location = new System.Drawing.Point(324, 40);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(686, 496);
            this.InfoBox.TabIndex = 9;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Info";
            // 
            // Hide_chk
            // 
            this.Hide_chk.AutoSize = true;
            this.Hide_chk.Font = new System.Drawing.Font("dotHack//FONT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide_chk.Location = new System.Drawing.Point(139, 14);
            this.Hide_chk.Name = "Hide_chk";
            this.Hide_chk.Size = new System.Drawing.Size(179, 25);
            this.Hide_chk.TabIndex = 8;
            this.Hide_chk.Text = "hide complete";
            this.Hide_chk.UseVisualStyleBackColor = true;
            this.Hide_chk.CheckedChanged += new System.EventHandler(this.Hide1_chk_CheckedChanged);
            // 
            // aTree
            // 
            this.aTree.BackColor = System.Drawing.SystemColors.MenuText;
            this.aTree.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTree.ForeColor = System.Drawing.Color.Red;
            this.aTree.LineColor = System.Drawing.Color.Gray;
            this.aTree.Location = new System.Drawing.Point(13, 40);
            this.aTree.Name = "aTree";
            this.aTree.Size = new System.Drawing.Size(305, 531);
            this.aTree.TabIndex = 7;
            this.aTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Vol1_tree_AfterSelect);
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1024, 418);
            this.ControlBox = false;
            this.Controls.Add(this.ListGroup);
            this.Controls.Add(this.Start_group);
            this.Font = new System.Drawing.Font("dotHack//FONT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Start_group.ResumeLayout(false);
            this.Start_group.PerformLayout();
            this.ListGroup.ResumeLayout(false);
            this.ListGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Vol1_pic;
        private System.Windows.Forms.PictureBox Vol2_pic;
        private System.Windows.Forms.PictureBox Vol4_pic;
        private System.Windows.Forms.PictureBox Vol3_pic;
        private System.Windows.Forms.Label Select_lbl;
        private System.Windows.Forms.GroupBox Start_group;
        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.Label Back_lbl;
        private System.Windows.Forms.GroupBox ListGroup;
        private System.Windows.Forms.CheckBox Hide_chk;
        private System.Windows.Forms.TreeView aTree;
        private System.Windows.Forms.GroupBox InfoBox;
    }
}

