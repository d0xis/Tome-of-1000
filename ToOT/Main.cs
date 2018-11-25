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

        public string currentVol;
        public int VolNum = 0;
        public int LevelCap;
        public int UIID;
        public string[] ItemList;
        public string[] MonsterList;
        public string[] AnimalList;
        public string[] BikePartList;
        public string[] WordList;
        public string[,] VolItems = { };
        public string[,] VolMonsters = { };
        public string[,] VolBikeParts = { };
        public string[,] VolWords = { };
        GUData Data = new GUData();

        private void Main_frm_Load(object sender, EventArgs e)
        {
            ToStart();
        }

        private void ToList()
        {
            Start_group.Visible = false;
            Start_group.Enabled = false;
            Start_group.Location = new System.Drawing.Point(0, -1000);
            this.Size = new System.Drawing.Size(1040, 610);
            ListGroup.Location = new System.Drawing.Point(0, -10);
            ListGroup.Enabled = true;
            ListGroup.Visible = true;
        }
        private void ToStart()
        {
            ListGroup.Enabled = false;
            ListGroup.Visible = false;
            ListGroup.Location = new System.Drawing.Point(0, -1000);
            this.Size = new System.Drawing.Size(1040, 365);
            Start_group.Location = new System.Drawing.Point(0, -10);
            Start_group.Enabled = true;
            Start_group.Visible = true;
            FillInfo("", "", "", "", "", "", "", false);
        }

        public void PopTree(string vol, Boolean hideComp)
        {
            TreeView vTree = aTree;
            DataSet xmlDB = new DataSet();
            //Populate tree from DB
            vTree.BeginUpdate();
            vTree.Nodes.Clear();
            vTree.Nodes.Add("Item");
            vTree.Nodes.Add("Monster");
            vTree.Nodes.Add("Animal");
            vTree.Nodes.Add("Bike Part");
            vTree.Nodes.Add("Key Word");
            vTree.EndUpdate();
            //Vol 1
            //Items
            for (int i = 1; i < Data.Vol1_Items.GetLength(0); i++)
            {
                vTree.Nodes[0].Nodes.Add("");
            }
            //Monsters
            for (int i = 1; i < Data.Vol1_Monsters.GetLength(0); i++)
            {
                vTree.Nodes[1].Nodes.Add(Data.Vol1_Monsters[i,2]);
            }

            //All Volumes
            //Animals
            for (int i = 1; i < Data.Animals.GetLength(0) - 4; i++)
            {
                vTree.Nodes[2].Nodes.Add(Data.Animals[i,1]);
            }
            switch (VolNum)
            {
                case 1:
                    vTree.Nodes[2].Nodes.Add(Data.Animals[21, 1]);
                    break;
                case 2:
                    vTree.Nodes[2].Nodes.Add(Data.Animals[22, 1]);
                    break;
                case 3:
                    vTree.Nodes[2].Nodes.Add(Data.Animals[23, 1]);
                    break;
                case 4:
                    vTree.Nodes[2].Nodes.Add(Data.Animals[24, 1]);
                    break;
            }
        }

        private void Vol1_pic_Click(object sender, EventArgs e)
        {
            //Vol. 1 Tome
            currentVol = "Vol1";
            VolNum = 1;
            LevelCap = 50;
            ToList();
            PopTree(currentVol, Hide_chk.Checked);
            VolItems = Data.Vol1_Items;
            VolMonsters = Data.Vol1_Monsters;
            VolBikeParts = Data.Vol1_BikeParts;
            VolWords = Data.Vol1_KeyWords;
        }

        private void Vol2_pic_Click(object sender, EventArgs e)
        {
            //Vol. 2 Tome
            currentVol = "Vol2";
            VolNum = 2;
            LevelCap = 100;
            ToList();
            PopTree(currentVol, Hide_chk.Checked);
            VolItems = Data.Vol2_Items;
            VolMonsters = Data.Vol2_Monsters;
            VolBikeParts = Data.Vol2_BikeParts;
            VolWords = Data.Vol2_KeyWords;
        }

        private void Vol3_pic_Click(object sender, EventArgs e)
        {
            //Vol. 3 Tome
            currentVol = "Vol3";
            VolNum = 3;
            LevelCap = 150;
            ToList();
            PopTree(currentVol, Hide_chk.Checked);
            VolItems = Data.Vol3_Items;
            VolMonsters = Data.Vol3_Monsters;
            VolBikeParts = Data.Vol3_BikeParts;
            VolWords = Data.Vol3_KeyWords;
        }

        private void Vol4_pic_Click(object sender, EventArgs e)
        {
            //Vol. 4 Tome
            currentVol = "Vol4";
            VolNum = 4;
            LevelCap = 200;
            ToList();
            PopTree(currentVol, Hide_chk.Checked);
            VolItems = Data.Vol4_Items;
            VolMonsters = Data.Vol4_Monsters;
            VolBikeParts = Data.Vol4_BikeParts;
            VolWords = Data.Vol4_KeyWords;
        }

        private void Back1_lbl_Click(object sender, EventArgs e)
        {
            ListGroup.Location = new System.Drawing.Point(0, -100);
            ListGroup.Enabled = false;
            ListGroup.Visible = false;
            currentVol = "";
            VolNum = 0;
            LevelCap = 0;
            ToStart();
        }

        private void Hide1_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide_chk.Checked) { PopTree(currentVol, true); }
            else { PopTree(currentVol, false); }
        }

        private void SetLocations(string[] sLocations)
        {
            LocationList.Items.Clear();
            LocationList.Visible = true;
            LocationLLabel.Visible = false;
            if (sLocations[0] != " ") { LocationList.Items.Add(sLocations[0]); }
            if (sLocations[1] != " ") { LocationList.Items.Add(sLocations[1]); }
            if (sLocations[2] != " ") { LocationList.Items.Add(sLocations[2]); }
            LocationList.SelectedIndex=0;
        }

        private void SetLocation(string sLevels)
        {
            LocationLLabel.Visible = true;
            LocationList.Visible = false;
            LocationLLabel.Text = sLevels;
        }

        private void InfoSort(string iUID)
        {
            //lookup UID
            string[] ID = iUID.Split('_');
            string sName = "";
            string sLabel2 = "";
            string sLabel3 = "";
            string sDescLabel = "";
            string sDesc = "";
            string sPicLocation = "";
            bool sComp = false;
            int cIndex = -1;
            int aIndex = 0;
            bool isID = false;
            switch (ID[0])
            {
                default:
                    MessageBox.Show("ERROR: Type not found!");
                    break;
                case "Item":
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Usage";
                    while (!isID)
                    {
                        if (iUID == VolItems[aIndex, 0])
                        {
                            isID = true;
                            sName = VolItems[aIndex, 1];
                            sDesc = VolItems[aIndex, 1 + VolNum];
                        }
                        else { aIndex++; }
                    }
                    break;
                case "Animal":
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Effect";
                    while(!isID)
                    {
                        if (iUID == Data.Animals[aIndex, 0])
                        {
                            isID = true;
                            sName = Data.Animals[aIndex, 1];
                            sDesc = Data.Animals[aIndex, 1 + VolNum];
                        }
                        else { aIndex++; }
                    }
                    switch (sName)
                    {
                        default:
                            break;
                        case ("Fate Worm"):
                        case ("Ouryu"):
                            cIndex = 0;
                            break;
                        case ("Gold Bird"):
                        case ("Totetsu"):
                            cIndex = 1;
                            break;
                        case ("Sleipnir"):
                        case ("Chimera"):
                            cIndex = 2;
                            break;
                        case ("Two-tailed Fox"):
                        case ("Nue"):
                            cIndex = 3;
                            break;
                        case ("Ganesha"):
                        case ("Tohkoh"):
                            cIndex = 4;
                            break;
                        case ("Leviathan"):
                        case ("Tengu"):
                            cIndex = 5;
                            break;
                        case ("High Wolf"):
                        case ("Baku"):
                            cIndex = 6;
                            break;
                        case ("Malice Cat"):
                        case ("Dark Goat"):
                            cIndex = 7;
                            break;
                        case ("Tsutsuga"):
                        case ("Qi Lin"):
                            cIndex = 8;
                            break;
                        case ("Moon Rabbit"):
                        case ("Kudan"):
                            cIndex = 9;
                            break;
                    }
                    string Found = Data.Animal_Chart[cIndex, PartyLast()];
                    if(Found == "N/a")
                    { SetLocation("Animal can NOT be found with current party levels."); }
                    else
                    { SetLocation("Can be found in areas with levels ending in " + Found + "."); }
                    break;
                case "Monster":
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Description";
                    while (!isID)
                    {
                        if (iUID == VolMonsters[aIndex, 0])
                        {
                            isID = true;
                            sName = VolMonsters[aIndex, 1];
                            sLabel2 = "Levels: "+ VolMonsters[aIndex, 3];
                            sLabel3 = "HP:" + VolMonsters[aIndex, 4];
                            sDesc = VolMonsters[aIndex, 5];
                            string[] mLoc = { VolMonsters[aIndex, 6], VolMonsters[aIndex, 7], VolMonsters[aIndex, 8] };
                            SetLocations(mLoc);
                        }
                        else
                        {  aIndex++; }
                    }
                    break;
            }
            //TODO:lookup completed in userdata, and check box if applicable
            FillInfo(iUID, sName, sLabel2, sLabel3, sDescLabel, sDesc, sPicLocation, sComp);
        }

        private void FillInfo(string iUID, string iName, string iLabel2, string iLabel3, string iDescLabel, string iDesc, string iPicLocation, bool iComp)
        {
            //fill infobox with provided strings
            Name_lbl.Text = iName;
            InfoLabel2.Text = iLabel2;
            InfoLabel3.Text = iLabel3;
            DescLabel.Text = iDescLabel;
            DescBox.Text = iDesc;
            InfoPicture.ImageLocation = iPicLocation;
            Complete_Check.Checked = iComp;
        }

        private void Complete_Check_CheckedChanged(object sender, EventArgs e)
        {
            //Mark item as complete
            if (Complete_Check.Checked)
            {
                Complete_Check.ForeColor = Color.Lime;
            }
            else
            {
                Complete_Check.ForeColor = Color.Red;
            }
        }

        private double AvgParty()
        {
            double[] PartyLevel = { 0, 0, 0 };
            string PartySize = "";
            int PL1, PL2, PL3;
            if (PartyLevel1.Text != "")
            {
                PL1 = Int32.Parse(PartyLevel1.Text);
                PartySize += "1";
            }
            else { PL1 = -1; }
            if (PartyLevel2.Text != "")
            {
                PL2 = Int32.Parse(PartyLevel2.Text);
                PartySize += "2";
            }
            else { PL2 = -1; }
            if (PartyLevel3.Text != "")
            {
                PL3 = Int32.Parse(PartyLevel3.Text);
                PartySize += "3";
            }
            else { PL3 = -1; }
            switch (PartySize)
            {
                default:
                    PartyLevel = new double[] { 0 };
                    break;
                case "1":
                    PartyLevel = new double[] { PL1 };
                    break;
                case "12":
                    PartyLevel = new double[] { PL1, PL2 };
                    break;
                case "13":
                    PartyLevel = new double[] { PL1, PL3 };
                    break;
                case "23":
                    PartyLevel = new double[] { PL2, PL3 };
                    break;
                case "123":
                    PartyLevel = new double[] { PL1, PL2, PL3 };
                    break;
            }
            double AvgLevel = Math.Round(PartyLevel.Average());
            AvgLevelBox.Text = AvgLevel.ToString();
            return AvgLevel;
        }

        private void PartyLevel1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PartyLevel1.Text, out int LVL) && LVL > 0 && LVL <= LevelCap)
            {
                PartyLevel1.ForeColor = Color.Black;
                AvgParty();
            }
            else { PartyLevel1.ForeColor = Color.Red; }
        }

        private void PartyLevel2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PartyLevel2.Text, out int LVL) && LVL > 0 && LVL <= LevelCap)
            {
                PartyLevel2.ForeColor = Color.Black;
                AvgParty();
            }
            else { PartyLevel2.ForeColor = Color.Red; }
        }

        private void PartyLevel3_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PartyLevel3.Text, out int LVL) && LVL > 0 && LVL <= LevelCap)
            {
                PartyLevel3.ForeColor = Color.Black;
                AvgParty();
            }
            else { PartyLevel3.ForeColor = Color.Red; }
        }

        private int PartyLast()
        {
            string PartNum = AvgParty().ToString();
            return Int32.Parse(PartNum.Remove(0, PartNum.Length - 1));
        }
        
        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (aTree.SelectedNode.Level == 1)
            {
                InfoSort(aTree.SelectedNode.FullPath.Replace('\\', '_').Replace(" ", ""));
            }
        }
    }
}
