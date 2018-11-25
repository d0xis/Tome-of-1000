using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ToOT
{
    public partial class Main_frm : Form
    {
        public int VolNum = 0;
        public int LevelCap;
        public string[,] VolItems = { };
        public string[,] VolMonsters = { };
        public string[,] VolBikeParts = { };
        public string[,] VolWords = { };
        GUData Data = new GUData();

        public Main_frm()
        {
            InitializeComponent();
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {
            ToStart();
        }

        private void ToList()
        {
            Start_group.Visible = false;
            Start_group.Enabled = false;
            Start_group.Location = new Point(0, -1000);
            this.Size = new Size(1040, 610);
            ListGroup.Location = new Point(0, -10);
            ListGroup.Enabled = true;
            ListGroup.Visible = true;
        }
        private void ToStart()
        {
            ListGroup.Enabled = false;
            ListGroup.Visible = false;
            ListGroup.Location = new Point(0, -1000);
            this.Size = new Size(1040, 365);
            Start_group.Location = new Point(0, -10);
            Start_group.Enabled = true;
            Start_group.Visible = true;
            FillInfo("", "", "", "", "", "", false);
        }

        public void PopTree(Boolean hideComp)
        {
            TreeView vTree = aTree;
            //Populate tree from DB
            vTree.BeginUpdate();
            vTree.Nodes.Clear();
            vTree.Nodes.Add("Item");
            vTree.Nodes.Add("Monster");
            vTree.Nodes.Add("Animal");
            vTree.Nodes.Add("Bike Part");
            if (VolNum != 1)
            {
                vTree.Nodes[3].Nodes.Add("Engine");
                vTree.Nodes[3].Nodes.Add("Cowl");
                vTree.Nodes[3].Nodes.Add("Muffler");
                vTree.Nodes[3].Nodes.Add("Tires");
            }
            else { vTree.Nodes[3].Nodes.Add("None"); }
            vTree.Nodes.Add("Keyword");
            vTree.Nodes[4].Nodes.Add("1st");
            vTree.Nodes[4].Nodes.Add("2nd");
            vTree.Nodes[4].Nodes.Add("3rd");
            vTree.EndUpdate();
            //Items
            for (int i = 0; i < VolItems.GetLength(0); i++)
            {
                vTree.Nodes[0].Nodes.Add(VolItems[i,0]);
            }
            //Monsters
            for (int i = 0; i < VolMonsters.GetLength(0); i++)
            {
                vTree.Nodes[1].Nodes.Add(VolMonsters[i,0]);
            }
            //Animals
            for (int i = 0; i < Data.Animals.GetLength(0) - 4; i++)
            {
                vTree.Nodes[2].Nodes.Add(Data.Animals[i,0]);
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
            //Keywords
            string place = "";
            for (int i = 0; i < VolWords.GetLength(0); i++)
            {
                place = VolWords[i, 1];
                switch (place)
                {
                    case "1st":
                        vTree.Nodes[4].Nodes[0].Nodes.Add(VolWords[i, 0]);
                        break;
                    case "2nd":
                        vTree.Nodes[4].Nodes[1].Nodes.Add(VolWords[i, 0]);
                        break;
                    case "3rd":
                        vTree.Nodes[4].Nodes[2].Nodes.Add(VolWords[i, 0]);
                        break;
                }
            }
            //Bike Parts
            string part = "";
            if (VolNum != 1)
            {
                for (int i = 0; i < VolBikeParts.GetLength(0); i++)
                {
                    part = VolBikeParts[i, 1];
                }
            }

        }

        private void Vol1_pic_Click(object sender, EventArgs e)
        {
            //Vol. 1 Tome
            VolNum = 1;
            LevelCap = 50;
            VolItems = Data.Vol1_Items;
            VolMonsters = Data.Vol1_Monsters;
            VolBikeParts = null;
            VolWords = Data.Vol1_KeyWords;
            PopTree(Hide_chk.Checked);
            ToList();
        }

        private void Vol2_pic_Click(object sender, EventArgs e)
        {
            //Vol. 2 Tome
            VolNum = 2;
            LevelCap = 100;
            VolItems = Data.Vol2_Items;
            VolMonsters = Data.Vol2_Monsters;
            VolBikeParts = Data.Vol2_BikeParts;
            VolWords = Data.Vol2_KeyWords;
            PopTree(Hide_chk.Checked);
            ToList();
        }

        private void Vol3_pic_Click(object sender, EventArgs e)
        {
            //Vol. 3 Tome
            VolNum = 3;
            LevelCap = 150;
            VolItems = Data.Vol3_Items;
            VolMonsters = Data.Vol3_Monsters;
            VolBikeParts = Data.Vol3_BikeParts;
            VolWords = Data.Vol3_KeyWords;
            PopTree(Hide_chk.Checked);
            ToList();
        }

        private void Vol4_pic_Click(object sender, EventArgs e)
        {
            //Vol. 4 Tome
            VolNum = 4;
            LevelCap = 200;
            VolItems = Data.Vol4_Items;
            VolMonsters = Data.Vol4_Monsters;
            VolBikeParts = Data.Vol4_BikeParts;
            VolWords = Data.Vol4_KeyWords;
            PopTree(Hide_chk.Checked);
            ToList();
        }

        private void Back1_lbl_Click(object sender, EventArgs e)
        {
            //Back to Volume Selection
            ListGroup.Location = new Point(0, -100);
            ListGroup.Enabled = false;
            ListGroup.Visible = false;
            VolNum = 0;
            LevelCap = 0;
            ToStart();
        }

        private void Hide1_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide_chk.Checked) { PopTree(true); }
            else { PopTree(false); }
        }

        private void SetLocations(string[] sLocations)
        {
            LocationList.Items.Clear();
            LocationList.Visible = true;
            LocationLLabel.Visible = false;
            for(int l=0; l < sLocations.GetLength(0); l++)
            {
                LocationList.Items.Add(sLocations[l]);
            }
            LocationList.SelectedIndex=0;
        }

        private void SetLocation(string sLevels)
        {
            LocationLLabel.Visible = true;
            LocationList.Visible = false;
            LocationLLabel.Text = sLevels;
        }

        private void InfoSort(string iName, string iType)
        {
            //lookup Name
            string sName = iName;
            string sLabel2 = "";
            string sLabel3 = "";
            string sDescLabel = "";
            string sDesc = "";
            string sPicLocation = "";
            bool sComp = false;
            int cIndex = -1;
            int aIndex = 0;
            bool isID = false;
            switch (iType)
            {
                case "Item": //{ "Name", "Type", "Usage", "Aquired" },
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Usage";
                    while (!isID)
                    {
                        if (iName == VolItems[aIndex, 0])
                        {
                            isID = true;
                            sDesc = VolItems[aIndex, 1 + VolNum];
                        }
                        else { aIndex++; }
                    }
                    break;
                case "Animal": //{ "Unique_ID", "Name", "Vol. 1 Effect", "Vol. 2 Effect", "Vol. 3 Effect", "Volume 4 effect?"  },
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Effect";
                    while(!isID)
                    {
                        if (iName == Data.Animals[aIndex, 0])
                        {
                            isID = true;
                            sDesc = Data.Animals[aIndex, 0 + VolNum];
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
                case "Monster": //{ "Name", "Type", "Lvl", "HP", "Description", Locations... },
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Description";
                    while (!isID)
                    {
                        if (iName == VolMonsters[aIndex, 0])
                        {
                            isID = true;
                            sName = iName+" - "+ VolMonsters[aIndex,1];
                            sLabel2 = "Levels: "+ VolMonsters[aIndex, 2];
                            sLabel3 = "HP:" + VolMonsters[aIndex, 3];
                            sDesc = VolMonsters[aIndex, 4];
                            List<string> mLoc = new List<string>();
                            for (int m = 5; m <= 10; m++)
                            {
                                if (VolMonsters[aIndex, m] != "")
                                {
                                    mLoc.Add(VolMonsters[aIndex, m]);
                                }
                            }
                            SetLocations(mLoc.ToArray());
                        }
                        else
                        {  aIndex++; }
                    }
                    break;
                case "Bike Part":   // { "Part", "Type", "Aquired" },
                    if (VolNum != 1)
                    {
                        cIndex = -1;
                        aIndex = 0;
                        isID = false;
                        sDescLabel = "Aquired by";
                        while (!isID)
                        {
                            if (iName == VolBikeParts[aIndex, 0])
                            {
                                isID = true;
                                sLabel2 = VolBikeParts[aIndex, 1];
                                sDesc = VolBikeParts[aIndex, 2];
                            }
                            else
                            { aIndex++; }
                        }

                    }
                    else { sLabel2 = "There are NO bike parts in Vol. 1"; }
                    break;
                case "Keyword": // { "Word", "Place", "Aquired" },
                    cIndex = -1;
                    aIndex = 0;
                    isID = false;
                    sDescLabel = "Aquired by";
                    while (!isID)
                    {
                        if (iName == VolWords[aIndex, 0])
                        {
                            isID = true;
                            sLabel2 = VolWords[aIndex, 1] + " word";
                            sDesc = VolWords[aIndex, 2];
                        }
                        else
                        { aIndex++; }
                    }
                    break;
            }
            //TODO: Lookup in userdata, and check box if applicable
            FillInfo(sName, sLabel2, sLabel3, sDescLabel, sDesc, sPicLocation, sComp);
        }

        private void FillInfo(string iName, string iLabel2, string iLabel3, string iDescLabel, string iDesc, string iPicLocation, bool iComp)
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
            if (Complete_Check.Checked) { Complete_Check.ForeColor = Color.Lime; }
            else { Complete_Check.ForeColor = Color.Red; }
            //TODO: Save to userdata
        }

        private double AvgParty()
        {
            //Find average of current party members levels
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
            //Find LAST digit of average party level
            string PartNum = AvgParty().ToString();
            return Int32.Parse(PartNum.Remove(0, PartNum.Length - 1));
        }

        private void aTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode iType = aTree.SelectedNode;
            while (iType.Parent != null) { iType = iType.Parent; }
            if (aTree.SelectedNode.Nodes.Count < 1) { InfoSort(aTree.SelectedNode.Text, iType.Text); }
        }
        
        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
