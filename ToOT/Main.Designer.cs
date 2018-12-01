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
            this.AvgLevelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartyLevel3 = new System.Windows.Forms.TextBox();
            this.PartyLevel2 = new System.Windows.Forms.TextBox();
            this.PartyLevel1 = new System.Windows.Forms.TextBox();
            this.PartyLabel = new System.Windows.Forms.Label();
            this.Complete_Check = new System.Windows.Forms.CheckBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.LocationList = new System.Windows.Forms.ComboBox();
            this.LocationLLabel = new System.Windows.Forms.Label();
            this.LocLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.RichTextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.InfoPicture = new System.Windows.Forms.PictureBox();
            this.Hide_chk = new System.Windows.Forms.CheckBox();
            this.aTree = new System.Windows.Forms.TreeView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vol1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol4_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vol3_pic)).BeginInit();
            this.Start_group.SuspendLayout();
            this.ListGroup.SuspendLayout();
            this.InfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).BeginInit();
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
            this.ListGroup.Controls.Add(this.SearchBox);
            this.ListGroup.Controls.Add(this.AvgLevelBox);
            this.ListGroup.Controls.Add(this.label1);
            this.ListGroup.Controls.Add(this.PartyLevel3);
            this.ListGroup.Controls.Add(this.PartyLevel2);
            this.ListGroup.Controls.Add(this.PartyLevel1);
            this.ListGroup.Controls.Add(this.PartyLabel);
            this.ListGroup.Controls.Add(this.Complete_Check);
            this.ListGroup.Controls.Add(this.InfoBox);
            this.ListGroup.Controls.Add(this.Hide_chk);
            this.ListGroup.Controls.Add(this.aTree);
            this.ListGroup.Controls.Add(this.Back_lbl);
            this.ListGroup.Location = new System.Drawing.Point(0, -10);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(1030, 609);
            this.ListGroup.TabIndex = 7;
            this.ListGroup.TabStop = false;
            this.ListGroup.Text = "groupBox1";
            // 
            // AvgLevelBox
            // 
            this.AvgLevelBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.AvgLevelBox.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgLevelBox.ForeColor = System.Drawing.Color.Red;
            this.AvgLevelBox.Location = new System.Drawing.Point(914, 15);
            this.AvgLevelBox.Name = "AvgLevelBox";
            this.AvgLevelBox.Size = new System.Drawing.Size(41, 23);
            this.AvgLevelBox.TabIndex = 17;
            this.AvgLevelBox.Text = "000";
            this.AvgLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("dotHack//FONT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Averagle Party Level: ";
            // 
            // PartyLevel3
            // 
            this.PartyLevel3.Font = new System.Drawing.Font("dotHack//FONT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLevel3.Location = new System.Drawing.Point(686, 18);
            this.PartyLevel3.Name = "PartyLevel3";
            this.PartyLevel3.Size = new System.Drawing.Size(29, 20);
            this.PartyLevel3.TabIndex = 15;
            this.PartyLevel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartyLevel3.TextChanged += new System.EventHandler(this.PartyLevel3_TextChanged);
            // 
            // PartyLevel2
            // 
            this.PartyLevel2.Font = new System.Drawing.Font("dotHack//FONT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLevel2.Location = new System.Drawing.Point(651, 18);
            this.PartyLevel2.Name = "PartyLevel2";
            this.PartyLevel2.Size = new System.Drawing.Size(29, 20);
            this.PartyLevel2.TabIndex = 14;
            this.PartyLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartyLevel2.TextChanged += new System.EventHandler(this.PartyLevel2_TextChanged);
            // 
            // PartyLevel1
            // 
            this.PartyLevel1.Font = new System.Drawing.Font("dotHack//FONT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLevel1.Location = new System.Drawing.Point(616, 18);
            this.PartyLevel1.Name = "PartyLevel1";
            this.PartyLevel1.Size = new System.Drawing.Size(29, 20);
            this.PartyLevel1.TabIndex = 13;
            this.PartyLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartyLevel1.TextChanged += new System.EventHandler(this.PartyLevel1_TextChanged);
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.Font = new System.Drawing.Font("dotHack//FONT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLabel.Location = new System.Drawing.Point(327, 19);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(282, 13);
            this.PartyLabel.TabIndex = 12;
            this.PartyLabel.Text = "Enter the levels of your party members:";
            // 
            // Complete_Check
            // 
            this.Complete_Check.AutoSize = true;
            this.Complete_Check.Font = new System.Drawing.Font("dotHack//FONT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complete_Check.ForeColor = System.Drawing.Color.Red;
            this.Complete_Check.Location = new System.Drawing.Point(324, 549);
            this.Complete_Check.Name = "Complete_Check";
            this.Complete_Check.Size = new System.Drawing.Size(132, 27);
            this.Complete_Check.TabIndex = 11;
            this.Complete_Check.Text = "Complete";
            this.Complete_Check.UseVisualStyleBackColor = true;
            this.Complete_Check.CheckedChanged += new System.EventHandler(this.Complete_Check_CheckedChanged);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InfoBox.Controls.Add(this.LocationList);
            this.InfoBox.Controls.Add(this.LocationLLabel);
            this.InfoBox.Controls.Add(this.LocLabel);
            this.InfoBox.Controls.Add(this.DescLabel);
            this.InfoBox.Controls.Add(this.InfoLabel3);
            this.InfoBox.Controls.Add(this.InfoLabel2);
            this.InfoBox.Controls.Add(this.DescBox);
            this.InfoBox.Controls.Add(this.Name_lbl);
            this.InfoBox.Controls.Add(this.InfoPicture);
            this.InfoBox.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.White;
            this.InfoBox.Location = new System.Drawing.Point(324, 40);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(686, 503);
            this.InfoBox.TabIndex = 9;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Info";
            // 
            // LocationList
            // 
            this.LocationList.BackColor = System.Drawing.SystemColors.MenuText;
            this.LocationList.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationList.ForeColor = System.Drawing.SystemColors.Info;
            this.LocationList.FormattingEnabled = true;
            this.LocationList.Location = new System.Drawing.Point(190, 467);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(490, 27);
            this.LocationList.TabIndex = 9;
            this.LocationList.Visible = false;
            // 
            // LocationLLabel
            // 
            this.LocationLLabel.AutoSize = true;
            this.LocationLLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLLabel.Location = new System.Drawing.Point(186, 470);
            this.LocationLLabel.Name = "LocationLLabel";
            this.LocationLLabel.Size = new System.Drawing.Size(77, 19);
            this.LocationLLabel.TabIndex = 8;
            this.LocationLLabel.Text = "sLocation";
            this.LocationLLabel.Visible = false;
            // 
            // LocLabel
            // 
            this.LocLabel.AutoSize = true;
            this.LocLabel.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocLabel.Location = new System.Drawing.Point(6, 468);
            this.LocLabel.Name = "LocLabel";
            this.LocLabel.Size = new System.Drawing.Size(191, 21);
            this.LocLabel.TabIndex = 7;
            this.LocLabel.Text = "Known Locations: ";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Cooper Std Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.Location = new System.Drawing.Point(6, 207);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(197, 37);
            this.DescLabel.TabIndex = 6;
            this.DescLabel.Text = "Description";
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel3.Location = new System.Drawing.Point(6, 151);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(54, 21);
            this.InfoLabel3.TabIndex = 5;
            this.InfoLabel3.Text = "lbl3";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel2.Location = new System.Drawing.Point(6, 89);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(54, 21);
            this.InfoLabel2.TabIndex = 4;
            this.InfoLabel2.Text = "lbl2";
            // 
            // DescBox
            // 
            this.DescBox.AcceptsTab = true;
            this.DescBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DescBox.ForeColor = System.Drawing.SystemColors.Info;
            this.DescBox.Location = new System.Drawing.Point(6, 250);
            this.DescBox.Name = "DescBox";
            this.DescBox.ReadOnly = true;
            this.DescBox.Size = new System.Drawing.Size(674, 211);
            this.DescBox.TabIndex = 3;
            this.DescBox.Text = "This is a test of what the DescriptionBox will look like. That is... DOES look li" +
    "ke... ;)";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Cooper Std Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(6, 29);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(138, 37);
            this.Name_lbl.TabIndex = 1;
            this.Name_lbl.Text = "<name>";
            // 
            // InfoPicture
            // 
            this.InfoPicture.Location = new System.Drawing.Point(441, 20);
            this.InfoPicture.Name = "InfoPicture";
            this.InfoPicture.Size = new System.Drawing.Size(239, 224);
            this.InfoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPicture.TabIndex = 0;
            this.InfoPicture.TabStop = false;
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
            this.aTree.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTree.ForeColor = System.Drawing.Color.Red;
            this.aTree.LineColor = System.Drawing.Color.Gray;
            this.aTree.Location = new System.Drawing.Point(13, 40);
            this.aTree.Name = "aTree";
            this.aTree.Size = new System.Drawing.Size(305, 503);
            this.aTree.TabIndex = 7;
            this.aTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.aTree_AfterSelect);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBox.Location = new System.Drawing.Point(13, 549);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(305, 29);
            this.SearchBox.TabIndex = 18;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1024, 580);
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
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).EndInit();
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
        private System.Windows.Forms.PictureBox InfoPicture;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.RichTextBox DescBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.CheckBox Complete_Check;
        private System.Windows.Forms.Label LocLabel;
        private System.Windows.Forms.Label PartyLabel;
        private System.Windows.Forms.TextBox PartyLevel1;
        private System.Windows.Forms.TextBox AvgLevelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PartyLevel3;
        private System.Windows.Forms.TextBox PartyLevel2;
        private System.Windows.Forms.Label LocationLLabel;
        private System.Windows.Forms.ComboBox LocationList;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

