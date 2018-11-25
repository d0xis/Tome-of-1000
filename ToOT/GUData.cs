using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToOT
{
    class GUData
    {
        public string[,] Vol1_Items = { //{ "Item1_ID", "Name", "Type", "Usage", "Aquired" },
        { "", "", "", "", "" } };

        public string[,] Vol1_Monsters = { //{"ID", "Name", "Type", "Lvl", "HP", "Loc1", "Loc2", "Loc3" },
        };

        public string[,] Vol1_KeyWords = { // {"ID", "Word", "Place", "Aquired" },
        };

        public string[,] Vol1_BikeParts = { { "BikePart_ID", "No Parts", "", "There are no Bike Parts in Vol. 1 - Rebirth" }, { "BikePart_ID", "No Parts", "", "There are no Bike Parts in Vol. 1 - Rebirth" } };  //None in Vol. 1



        public string[,] Vol2_Items = { //{ "Item1_ID", "Name", "Type", "Usage", "Aquired" },
        { "", "", "", "", "" } };

        public string[,] Vol2_Monsters = { //{"ID", "Name", "Type", "Lvl", "HP", "Loc1", "Loc2", "Loc3" },
        };

        public string[,] Vol2_KeyWords = { // {"ID", "Word", "Place", "Aquired" },
        };

        public string[,] Vol2_BikeParts = {  // {"ID", "Name", "Type", "Aquired" },
        };



        public string[,] Vol3_Items = { //{ "Item1_ID", "Name", "Type", "Usage", "Aquired" },
        { "", "", "", "", "" } };

        public string[,] Vol3_Monsters = { //{"ID", "Name", "Type", "Lvl", "HP", "Loc1", "Loc2", "Loc3" },
        };

        public string[,] Vol3_KeyWords = { // {"ID", "Word", "Place", "Aquired" },
        };

        public string[,] Vol3_BikeParts = {  // {"ID", "Name", "Type", "Aquired" },
        };



        public string[,] Vol4_Items = { //{ "Item1_ID", "Name", "Type", "Usage", "Aquired" },
        { "", "", "", "", "" } };

        public string[,] Vol4_Monsters = { //{"ID", "Name", "Type", "Lvl", "HP", "Loc1", "Loc2", "Loc3" },
        };

        public string[,] Vol4_KeyWords = { // {"ID", "Word", "Place", "Aquired" },
        };

        public string[,] Vol4_BikeParts = {  // {"ID", "Name", "Type", "Aquired" },
        };

        public string[,] Animals = { { "Unique_ID", "Name", "Vol. 1 Effect", "Vol. 2 Effect", "Vol. 3 Effect", "Volume 4 effect?"  },
            { "Animal_GoldBird","Gold Bird","Turns all breakable objects into chests.","Turns all breakable objects into chests.","Turns all breakable objects into chests.", "Volume 4 effect?"  },
            { "Animal_MoonRabbit","Moon Rabbit","Grants 200 experience points to each party member.","Grants 400 experience points to each party member.","Grants 600 experience points to each party member.", "Volume 4 effect?"  },
            { "Animal_Leviathan","Leviathan","Gives the kicker 3 Modifications.","Gives the kicker 5 Modifications.","Gives the kicker 7 Modifications.", "Volume 4 effect?"  },
            { "Animal_Sleipnir","Sleipnir","Will appear and attack the party's enemies for 5 battles.","Will appear and attack the party's enemies for 5 battles.","Will appear and attack the party's enemies for 7 battles.", "Volume 4 effect?"  },
            { "Animal_Tsutsuga","Tsutsuga","Saves the kicker from 3 game overs.","Recover half HP/SP of the party.","Saves the kicker from 3 game overs.", "Volume 4 effect?"  },
            { "Animal_Ganesha","Ganesha","Increases max HP/SP for 5 battles.","Increases max HP/SP for 5 battles.","Increases max HP/SP for 5 battles.", "Volume 4 effect?"  },
            { "Animal_HighWolf","High Wolf","Lets the kicker choose a package of either healing, attack, or support items.","Lets the kicker choose a package of either healing, attack, or support items.","Lets the kicker choose a package of either healing, attack, or support items.", "Volume 4 effect?"  },
            { "Animal_FateWorm","Fate Worm","Gives the kicker 2000 GP","Gives the kicker 10000 GP","Gives the kicker 50000 GP", "Volume 4 effect?"  },
            { "Animal_Totetsu","Totetsu","Turns all breakable objects into chests.","Turns all breakable objects into chests.","Turns all breakable objects into chests.", "Volume 4 effect?"  },
            { "Animal_Kudan","Kudan","Grants 150 experience points to each party member.","Grants 300 experience points to each party member.","Grants 450 experience points to each party member.", "Volume 4 effect?"  },
            { "Animal_Tengu","Tengu","Gives the kicker 2 modification materials.","Gives the kicker 4 modification materials.","Gives the kicker 6 modification materials.", "Volume 4 effect?"  },
            { "Animal_Chimera","Chimera","Appears in the beginning of a battle and deals a huge amount of damage to the enemies for 4 battles.","Appears in the beginning of a battle and deals a huge amount of damage to the enemies for 4 battles.","Appears in the beginning of a battle and deals a huge amount of damage to the enemies for 6 battles.", "Volume 4 effect?"  },
            { "Animal_QiLin","Qi Lin","Saves the kicker from 2 game overs.","Recover half HP/SP of party.","Saves the kicker from game over two times.", "Volume 4 effect?"  },
            { "Animal_Tohkoh","Tohkoh","Increases max HP/SP for 4 battles.","Increases max HP/SP for 4 battles.","Increases max HP/SP for 6 battles.", "Volume 4 effect?"  },
            { "Animal_Baku","Baku","Lets the kicker choose a package of either healing, attack, or support items.","Lets the kicker choose a package of either healing, attack, or support items.","Lets the kicker choose a package of either healing, attack, or support items.", "Volume 4 effect?"  },
            { "Animal_Ouryu","Ouryu","Gives the kicker 1500 GP","Gives the kicker 8000 GP","Gives the kicker 16000 GP", "Volume 4 effect?"  },
            { "Animal_Nue","Nue","Summons a King Chim Chim.","Summons a King Chim Chim.","Summons a King Chim Chim.", "Volume 4 effect?"  },
            { "Animal_Two-TailedFox","Two-Tailed Fox","Steals 5% of the kicker's GP","Steals 5% of the kicker's GP","Steals 5% of the kicker's GP", "Volume 4 effect?"  },
            { "Animal_MaliceCat","Malice Cat","Reduces the party's max HP and SP by 50% for one battle.","Reduces the party's max HP and SP by 50% for one battle.","Reduces the party's max HP and SP by 50% for one battle.", "Volume 4 effect?"  },
            { "Animal_DarkGoat","Dark Goat","Reduces the party's max HP and SP by 50% for one battle.","Reduces the party's max HP and SP by 50% for one battle.","Reduces the party's max HP and SP by 50% for one battle.", "Volume 4 effect?"  },
            { "Animal_BlackSleipnir","Black Sleipnir","Kick it to clear the Animal Mania quest.","N/A","N/A", "Volume 4 effect?"  },
            { "Animal_WhiteMaliceCat","White Malice Cat","N/A","Kick it to clear The Cat Smiles Silently quest.","N/A", "Volume 4 effect?"  },
            { "Animal_SilvermaneKudan","Silvermane Kudan","N/A","N/A","Gives the kicker a prophecy.", "Volume 4 effect?"  },
            { "Animal_???","Special","N/A","N/A","N/A", "Volume 4 effect?" }
        };

        public string[,] Animal_Chart = { //Determine what areas an animal can be found in based on current party
         /*Party level ends in 0*/{  "0", "9", "8", "7", "6", "5", "4", "3", "2", "1" }
        ,/*Party level ends in 1*/ { "Any Number", "N/a", "N/a", "N/a", "N/a", "N/a", "N/a", "N/a", "N/a", "N/a" }
        ,/*Party level ends in 2*/ { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
        ,/*Party level ends in 3*/ { "0 or 5", "N/a", "1 or 6", "N/a", "2 or 7", "N/a", "3 or 8", "N/a", "4 or 9", "N/a" }
        ,/*Party level ends in 4*/ { "0", "7", "4", "1", "8", "5", "2", "9", "6", "3" }
        ,/*Party level ends in 5*/ { "0 or 5", "N/a", "3 or 8", "N/a", "1 or 6", "N/a", "4 or 9", "N/a", "2 or 7", "N/a" }
        ,/*Party level ends in 6*/ { "Even Numbers", "N/a", "N/a", "N/a", "N/a", "Odd Numbers", "N/a", "N/a", "N/a", "N/a" }
        ,/*Party level ends in 7*/ { "0 or 5", "N/a", "2 or 7", "N/a", "4 or 9", "N/a", "1 or 6", "N/a", "3 or 9", "N/a" }
        ,/*Party level ends in 8*/ { "0", "3", "6", "9", "2", "5", "8", "1", "4", "7" }
        ,/*Party level ends in 9*/ { "0 or 5", "N/a", "4 or 9", "N/a", "3 or 8", "N/a", "2 or 7", "N/a", "1 or 6", "N/a" } };
    }
}
