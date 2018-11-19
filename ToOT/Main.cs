using System;
using System.IO;
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

        public string currentVol = "";

        private void Main_frm_Load(object sender, EventArgs e)
        {
            toStart();
            if (File.Exists("usr.xml")) { return; }
            else { File.Copy("data.xml", "usr.xml"); }
        }

        private void toList()
        {
            this.Size = new System.Drawing.Size(1040, 610);
            Start_group.Visible = false;
            Start_group.Enabled = false;
            Start_group.Location = new System.Drawing.Point(0, -100);
            ListGroup.Location = new System.Drawing.Point(0, -10);
            ListGroup.Enabled = true;
            ListGroup.Visible = true;
        }
        private void toStart()
        {
            this.Size = new System.Drawing.Size(1040, 365);
            Start_group.Location = new System.Drawing.Point(0, -10);
            Start_group.Enabled = true;
            Start_group.Visible = true;
        }

        public void popTree(string vol, Boolean hideComp)
        {
            TreeView vTree = new TreeView();
            switch (vol)
            {
                default:
                    MessageBox.Show("ERROR: Incorect Layout Name!");
                    break;
                case "Vol1":
                    vTree = aTree;
                    break;
                case "Vol2":
                    vTree = aTree;
                    break;
                case "Vol3":
                    vTree = aTree;
                    break;
                case "Vol4":
                    vTree = aTree;
                    break;
            }
            DataSet xmlDB = new DataSet();
            xmlDB.ReadXml("usr.xml");
            //Populate tree from DB
            vTree.BeginUpdate();
            vTree.Nodes.Clear();
            vTree.Nodes.Add(currentVol);
            if (hideComp) { vTree.Nodes[0].Nodes.Add("True"); }
            else { vTree.Nodes[0].Nodes.Add("False"); }
            vTree.EndUpdate();
        }

        private void Vol1_pic_Click(object sender, EventArgs e)
        {
            //Vol. 1 Tome
            currentVol = "Vol1";
            toList();
            popTree(currentVol, Hide_chk.Checked);
        }

        private void Vol2_pic_Click(object sender, EventArgs e)
        {
            //Vol. 2 Tome
            currentVol = "Vol2";
            toList();
            popTree(currentVol, Hide_chk.Checked);
        }

        private void Vol3_pic_Click(object sender, EventArgs e)
        {
            //Vol. 3 Tome
            currentVol = "Vol3";
            toList();
            popTree(currentVol, Hide_chk.Checked);
        }

        private void Vol4_pic_Click(object sender, EventArgs e)
        {
            //Vol. 4 Tome
            currentVol = "Vol4";
            toList();
            popTree(currentVol, Hide_chk.Checked);
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back1_lbl_Click(object sender, EventArgs e)
        {
            ListGroup.Location = new System.Drawing.Point(0, -100);
            ListGroup.Enabled = false;
            ListGroup.Visible = false;
            toStart();
        }

        private void Vol1_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Hide1_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide_chk.Checked) { popTree(currentVol, true); }
            else { popTree(currentVol, false); }
        }
    }
}
