using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToOT
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void JumpTo(string Layout)
        {
            //Switch between windows layouts
            switch (Layout)
            {
                default:
                    MessageBox.Show("ERROR: Incorect Layout Name!");
                    break;
                case "Select":
                    this.Size = new System.Drawing.Size(1040, 430);
                    Select_group.Location = new System.Drawing.Point(0, 10);
                    Select_group.Enabled = true;
                    Select_group.Visible = true;
                    break;
                case "Vol1":
                    this.Size = new System.Drawing.Size(1040, 700);
                    Select_group.Visible = false;
                    Select_group.Enabled = false;
                    Select_group.Location = new System.Drawing.Point(0, -100);
                    Vol1_group.Location = new System.Drawing.Point(0, 10);
                    Vol1_group.Enabled = true;
                    Vol1_group.Visible = true;
                    break;
                case "Vol2":
                    break;
                case "Vol3":
                    break;
                case "Vol4":
                    break;

            }
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {
            JumpTo("Select");
        }

        private void Vol1_pic_Click(object sender, EventArgs e)
        {
            //Vol. 1 Tome
            JumpTo("Vol1");
        }

        private void Vol2_pic_Click(object sender, EventArgs e)
        {
            //Vol. 2 Tome
            JumpTo("Vol2");
        }

        private void Vol3_pic_Click(object sender, EventArgs e)
        {
            //Vol. 3 Tome
            JumpTo("Vol3");
        }

        private void Vol4_pic_Click(object sender, EventArgs e)
        {
            //Vol. 4 Tome
            JumpTo("Vol4");
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back1_lbl_Click(object sender, EventArgs e)
        {
            Vol1_group.Location = new System.Drawing.Point(0, -100);
            Vol1_group.Enabled = false;
            Vol1_group.Visible = false;
            JumpTo("Select");
        }
    }
}
