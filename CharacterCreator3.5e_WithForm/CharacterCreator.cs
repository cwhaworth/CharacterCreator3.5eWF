using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator3._5e_WithForm
{
    public partial class frmMain : Form
    {
        private int menuLvl = 0;
        private bool newCharUI = false;
        private Character newCharacter;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            LoadNewCharacterMenu();
            menuLvl = 10;
        }
        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {
            menuLvl = 11;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (menuLvl)
            {
                case 0:
                    Close();
                    break;
                case 10:
                    UnloadNewCharacterMenu();
                    InitializeComponent();
                    menuLvl = 0;
                    break;
                case 11:
                    InitializeComponent();
                    menuLvl = 0;
                    break;
                case 100:
                    UnloadNewCharacterUI();
                    LoadNewCharacterMenu();
                    btnRandomCharacter.Location = new System.Drawing.Point(308, 231);
                    menuLvl = 10;
                    break;
                case 101:
                    UnloadNewCharacterUI();
                    LoadNewCharacterMenu();
                    btnRoll.Location = new System.Drawing.Point(308, 260);
                    btnRoll.Text = "Roll Ability Scores";
                    menuLvl = 10;
                    break;
                case 102:
                    UnloadNewCharacterUI();
                    LoadNewCharacterMenu();
                    menuLvl = 10;
                    break;
            }
        }

        //UI loading
        private void LoadNewCharacterMenu()
        {
            btnNewCharacter.Hide();
            btnLoadCharacter.Hide();
            btnBack.Location = new System.Drawing.Point(308, 318);
            btnBack.Text = "Back";

            btnRandomCharacter.Show();
            btnRoll.Show();
            btnPointBuy.Show();
        }
        private void LoadNewCharacterUI()
        {
            lblCharacterName.Show();
            lblAbilityRollsHeader.Show();
            lblAbilityRolls.Show();
            lblStrHeader.Show();
            lblDexHeader.Show();
            lblConHeader.Show();
            lblIntHeader.Show();
            lblWisHeader.Show();
            lblChaHeader.Show();
            lblRaceHeader.Show();
            lblStrMod.Show();
            lblDexMod.Show();
            lblConMod.Show();
            lblIntMod.Show();
            lblWisMod.Show();
            lblChaMod.Show();
            lblStrRacialAdjust.Show();
            lblDexRacialAdjust.Show();
            lblConRacialAdjust.Show();
            lblIntRacialAdjust.Show();
            lblWisRacialAdjust.Show();
            lblChaRacialAdjust.Show();
            txtCharacterName.Show();
            cbxStr.Show();
            cbxDex.Show();
            cbxCon.Show();
            cbxInt.Show();
            cbxWis.Show();
            cbxCha.Show();
            cbxRace.Show();
            cbxStr.Enabled = true;
            cbxDex.Enabled = true;
            cbxCon.Enabled = true;
            cbxInt.Enabled = true;
            cbxWis.Enabled = true;
            cbxCha.Enabled = true;
            cbxRace.Enabled = true;
            newCharUI = true;
        }

        //UI unloading
        private void UnloadNewCharacterMenu()
        {
            btnRandomCharacter.Hide();
            btnRoll.Hide();
            btnPointBuy.Hide();
            btnBack.Hide();
        }
        private void UnloadNewCharacterUI()
        {
            lblCharacterName.Hide();
            lblAbilityRollsHeader.Hide();
            lblAbilityRolls.Hide();
            lblStrHeader.Hide();
            lblDexHeader.Hide();
            lblConHeader.Hide();
            lblIntHeader.Hide();
            lblWisHeader.Hide();
            lblChaHeader.Hide();
            lblRaceHeader.Hide();
            lblStrMod.Hide();
            lblDexMod.Hide();
            lblConMod.Hide();
            lblIntMod.Hide();
            lblWisMod.Hide();
            lblChaMod.Hide();
            lblStrRacialAdjust.Hide();
            lblDexRacialAdjust.Hide();
            lblConRacialAdjust.Hide();
            lblIntRacialAdjust.Hide();
            lblWisRacialAdjust.Hide();
            lblChaRacialAdjust.Hide();
            txtCharacterName.Hide();
            cbxStr.Hide();
            cbxDex.Hide();
            cbxCon.Hide();
            cbxInt.Hide();
            cbxWis.Hide();
            cbxCha.Hide();
            cbxRace.Hide();
            newCharUI = false;
        }
        
        //New Character Menu Items
        private void btnRandomCharacter_Click(object sender, EventArgs e)
        {
            menuLvl = 100;
            if (newCharUI == false)
            {
                LoadNewCharacterUI();
                btnRandomCharacter.Location = new System.Drawing.Point(610, 6);
                btnBack.Location = new System.Drawing.Point(610, 34);
                btnRoll.Hide();
                btnPointBuy.Hide();
            }

            newCharacter = new Character();
            List<int> scores = new List<int>(7);
            lblAbilityRolls.Text = "";
            cbxRace.Items.Clear();
            cbxStr.Items.Clear();
            cbxDex.Items.Clear();
            cbxCon.Items.Clear();
            cbxInt.Items.Clear();
            cbxWis.Items.Clear();
            cbxCha.Items.Clear();
            lblStrMod.Text = (0).ToString();
            lblDexMod.Text = (0).ToString();
            lblConMod.Text = (0).ToString();
            lblIntMod.Text = (0).ToString();
            lblWisMod.Text = (0).ToString();
            lblChaMod.Text = (0).ToString();

            /* RollAbilityScore() 7 times, and write to list scores at index i
             * Display all 7 scores in list scores
             * Remove lowest value in list scores
             * Assigns scores to newCharacter randomly*/
            for (int i = 0; i < scores.Capacity; i++)
            {
                System.Threading.Thread.Sleep(5);
                scores.Insert(i, RollAbilityScore());
            }
            for (int i = 0; i < scores.Capacity; i++)
            {
                if (i == scores.Capacity - 1)
                {
                    lblAbilityRolls.Text += (i + 1) + ") " + scores[i];
                }
                else
                {
                    lblAbilityRolls.Text += (i + 1) + ") " + scores[i] + ",     ";
                }
            }
            scores.Remove(scores.Min());

            for (int i = 0; i < newCharacter.GetAbilityScoresLength(); i++)
            {
                /* Assign elements in scores randomly to each index in abilityScores
                * Remove index in list score after it is assigned to prevent the element from being reused*/
                Random s = new Random();
                int index = s.Next(scores.Count);
                newCharacter.SetAbilityScoreVal(i, scores[index]);
                scores.Remove(scores[index]);
            }

            //Add Race to character
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            Random gen = new Random();
            DataRow select = races.Rows.Find(gen.Next(100, 107));
            cbxRace.Items.Add(select.Field<string>("RaceName"));
            cbxRace.SelectedIndex = 0;

            //Display ability scores and mods, disable ability combo boxes
            for (int i = 0; i < newCharacter.GetAbilityScoresLength(); i++)
            {
                switch (i)
                {
                    case 0:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustStr"));
                        cbxStr.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxStr.SelectedIndex = 0;
                        lblStrRacialAdjust.Text = select.Field<int>("AdjustStr").ToString();
                        System.Threading.Thread.Sleep(5);
                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                    case 1:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustDex"));
                        cbxDex.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxDex.SelectedIndex = 0;
                        lblDexRacialAdjust.Text = select.Field<int>("AdjustDex").ToString();
                        System.Threading.Thread.Sleep(5);
                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                    case 2:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustCon"));
                        cbxCon.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxCon.SelectedIndex = 0;
                        lblConRacialAdjust.Text = select.Field<int>("AdjustCon").ToString();
                        System.Threading.Thread.Sleep(5);
                       lblConMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                    case 3:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustInt"));
                        cbxInt.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxInt.SelectedIndex = 0;
                        lblIntRacialAdjust.Text = select.Field<int>("AdjustInt").ToString();
                        System.Threading.Thread.Sleep(5);
                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                    case 4:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustWis"));
                        cbxWis.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxWis.SelectedIndex = 0;
                        lblWisRacialAdjust.Text = select.Field<int>("AdjustWis").ToString();
                        System.Threading.Thread.Sleep(5);
                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                    case 5:
                        newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustCha"));
                        cbxCha.Items.Add(newCharacter.GetAbilityScoreVal(i));
                        cbxCha.SelectedIndex = 0;
                        lblChaRacialAdjust.Text = select.Field<int>("AdjustCha").ToString();
                        System.Threading.Thread.Sleep(5);
                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(i).ToString();
                        break;
                }
            }
            cbxStr.Enabled = false;
            cbxDex.Enabled = false;
            cbxCon.Enabled = false;
            cbxInt.Enabled = false;
            cbxWis.Enabled = false;
            cbxCha.Enabled = false;
            cbxRace.Enabled = false;
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            menuLvl = 101;
            if (newCharUI == false)
            {
                LoadNewCharacterUI();
                btnRoll.Location = new System.Drawing.Point(610, 6);
                btnBack.Location = new System.Drawing.Point(610, 34);
                btnRandomCharacter.Hide();
                btnPointBuy.Hide();
                if (btnRoll.Text != "Reroll Ability Scores")
                    btnRoll.Text = "Reroll Ability Scores";
            }

            newCharacter = new Character();
            List<int> scores = new List<int>(7);
            lblAbilityRolls.Text = "";
            ClearNewCharacterCbxs();

            /* RollAbilityScore() 7 times, and write to list scores at index i
             * Remove lowest value in list scores
             * Display 6 remaining scores in list scores
             * Add all scores to items of all ability combo boxes*/
            for (int i = 0; i < scores.Capacity; i++)
            {
                System.Threading.Thread.Sleep(5);
                scores.Insert(i, RollAbilityScore());
            }
            scores.Remove(scores.Min());
            scores.Capacity = scores.Count;
            for (int i = 0; i < scores.Capacity; i++)
            {
                if (i == scores.Capacity - 1)
                {
                    lblAbilityRolls.Text += (i + 1) + ") " + scores[i];
                }
                else
                {
                    lblAbilityRolls.Text += (i + 1) + ") " + scores[i] + ",     ";
                }
                cbxStr.Items.Add(scores[i]);
                cbxDex.Items.Add(scores[i]);
                cbxCon.Items.Add(scores[i]);
                cbxInt.Items.Add(scores[i]);
                cbxWis.Items.Add(scores[i]);
                cbxCha.Items.Add(scores[i]);
            }

            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            cbxRace.Items.Add("");
            for (int i = 100; i < 107; i++)
            {
                DataRow select = races.Rows.Find(i);
                cbxRace.Items.Add(select.Field<string>("RaceName"));
            }
            cbxRace.SelectedIndex = 0;

            lblStrMod.Text = "+" + (0).ToString();
            lblDexMod.Text = "+" + (0).ToString();
            lblConMod.Text = "+" + (0).ToString();
            lblIntMod.Text = "+" + (0).ToString();
            lblWisMod.Text = "+" + (0).ToString();
            lblChaMod.Text = "+" + (0).ToString();
        }
        private void btnPointBuy_Click(object sender, EventArgs e)
        {
            //Loads the form in point buy format
            menuLvl = 102;
            if (newCharUI == false)
            {
                LoadNewCharacterUI();
                btnRandomCharacter.Hide();
                btnRoll.Hide();
                btnPointBuy.Hide();
                btnBack.Location = new System.Drawing.Point(610, 6);
            }            

            newCharacter = new Character();
            lblAbilityRollsHeader.Text = "Point buy values, remaining: " + 25;
            lblAbilityRolls.Text = "8 = 0, 9 = 1, 10 = 2, 11 = 3, 12 = 4, 13 = 5, 14 = 6, 15 = 8, 16 = 10,  17 = 13, 18 = 16";
            ClearNewCharacterCbxs();

            for (int i = 0; i < 11; i++)
            {
                    cbxStr.Items.Add((i + 8).ToString());
                    cbxDex.Items.Add((i + 8).ToString());
                    cbxCon.Items.Add((i + 8).ToString());
                    cbxInt.Items.Add((i + 8).ToString());
                    cbxWis.Items.Add((i + 8).ToString());
                    cbxCha.Items.Add((i + 8).ToString());
            }

            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            cbxRace.Items.Add("");
            for (int i = 100; i < 107; i++)
            {
                DataRow select = races.Rows.Find(i);
                cbxRace.Items.Add(select.Field<string>("RaceName"));
            }
            cbxRace.SelectedIndex = 0;

            lblStrMod.Text = "+" + (0).ToString();
            lblDexMod.Text = "+" + (0).ToString();
            lblConMod.Text = "+" + (0).ToString();
            lblIntMod.Text = "+" + (0).ToString();
            lblWisMod.Text = "+" + (0).ToString();
            lblChaMod.Text = "+" + (0).ToString();
        }
        private int RollAbilityScore()
        {
            int[] results = new int[4];
            int result = 0;

            for (int i = 0; i < results.Length; i++)
            {
                System.Threading.Thread.Sleep(5);
                results[i] = D6();
            }
            for (int i = 0; i < results.Length; i++)
            {
                result += results[i];
            }
            result -= results.Min();
            return result;
        }
        private void ClearNewCharacterCbxs()
        {
            //Resets the comboboxes of the new character form
            cbxRace.Items.Clear();
            cbxStr.Items.Clear();
            cbxDex.Items.Clear();
            cbxCon.Items.Clear();
            cbxInt.Items.Clear();
            cbxWis.Items.Clear();
            cbxCha.Items.Clear();
            cbxStr.Items.Add("");
            cbxDex.Items.Add("");
            cbxCon.Items.Add("");
            cbxInt.Items.Add("");
            cbxWis.Items.Add("");
            cbxCha.Items.Add("");
        }

        /* Logic for ability score combo boxes check if a value has been used by 
         * any other combo box, then notifiies the user according to which 
         * ability is using the score.
         * 
         * Logic for ability score combo boxes with point buy.
         */
        private bool CheckPointBuyCap()
        {
            //Logic of Point Buy
            /* User has 25 points to distribute their ability scores
            * a score cannot be less than 8 or greater than 18
            * each score has a point cost associated with it
            * 8 = 0
            * 9 = 1
            * 10 = 2
            * 11 = 3
            * 12 = 4
            * 13 = 5
            * 14 = 6
            * [[[[[[8-14 represented by formula: pointValue = abilityScore - 8 ]]]]]]
            * 15 = 8
            * 16 = 10
            * 17 = 13
            * 18 = 16
            * check is in place to ensure points do not become less than 0
            */
            const int pointBuy = 25;
            int pointBuyCheck = 0;
            int[] abilityVals = new int[6];

            for (int i = 0; i < abilityVals.Length; i++)
            {
                int temp = 0;
                switch (i)
                {
                    case 0:
                        if (cbxStr.SelectedIndex != -1 && int.TryParse(cbxStr.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxStr.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }                        
                        break;
                    case 1:
                        if (cbxDex.SelectedIndex != -1 && int.TryParse(cbxDex.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxDex.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }
                        break;
                    case 2:
                        if (cbxCon.SelectedIndex != -1 && int.TryParse(cbxCon.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxCon.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }
                        break;
                    case 3:
                        if (cbxInt.SelectedIndex != -1 && int.TryParse(cbxInt.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxInt.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }
                        break;
                    case 4:
                        if (cbxWis.SelectedIndex != -1 && int.TryParse(cbxWis.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxWis.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }
                        break;
                    case 5:
                        if (cbxCha.SelectedIndex != -1 && int.TryParse(cbxCha.SelectedItem.ToString(), out temp))
                        {
                            abilityVals[i] = int.Parse(cbxCha.SelectedItem.ToString());
                        }
                        else
                        {
                            abilityVals[i] = 0;
                        }
                        break;
                }
            }

            for (int i = 0; i < abilityVals.Length; i++)
            {
                switch(abilityVals[i])
                {
                    case 0:
                        break;
                    case 8:
                        break;
                    case 9:
                        pointBuyCheck += 1;
                        break;
                    case 10:
                        pointBuyCheck += 2;
                        break;
                    case 11:
                        pointBuyCheck += 3;
                        break;
                    case 12:
                        pointBuyCheck += 4;
                        break;
                    case 13:
                        pointBuyCheck += 5;
                        break;
                    case 14:
                        pointBuyCheck += 6;
                        break;
                    case 15:
                        pointBuyCheck += 8;
                        break;
                    case 16:
                        pointBuyCheck += 10;
                        break;
                    case 17:
                        pointBuyCheck += 13;
                        break;
                    case 18:
                        pointBuyCheck += 16;
                        break;
                }
            }

            if (pointBuyCheck <= pointBuy)
                return true;
            else
                return false;
        }
        private void cbxStr_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                //Logic of Roll Ability Scores
             

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxStr.SelectedIndex == cbxDex.SelectedIndex) && (cbxStr.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(1) + ".", "Error");
                                cbxStr.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxStr.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(0, int.Parse(cbxStr.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(0) < 10)
                                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                                    else
                                        lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(0, 0);
                                    lblStrMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxStr.SelectedIndex == cbxCon.SelectedIndex) && (cbxStr.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(2) + ".", "Error");
                                cbxStr.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxStr.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(0, int.Parse(cbxStr.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(0) < 10)
                                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                                    else
                                        lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(0, 0);
                                    lblStrMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxStr.SelectedIndex == cbxInt.SelectedIndex) && (cbxStr.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(3) + ".", "Error");
                                cbxStr.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxStr.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(0, int.Parse(cbxStr.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(0) < 10)
                                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                                    else
                                        lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(0, 0);
                                    lblStrMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxStr.SelectedIndex == cbxWis.SelectedIndex) && (cbxStr.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(4) + ".", "Error");
                                cbxStr.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxStr.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(0, int.Parse(cbxStr.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(0) < 10)
                                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                                    else
                                        lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(0, 0);
                                    lblStrMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxStr.SelectedIndex == cbxCha.SelectedIndex) && (cbxStr.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(5) + ".", "Error");
                                cbxStr.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxStr.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(0, int.Parse(cbxStr.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(0) < 10)
                                        lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                                    else
                                        lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(0, 0);
                                    lblStrMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxStr.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxStr.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(0, value);
                        if (newCharacter.GetAbilityScoreVal(0) < 10)
                            lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
                        else
                            lblStrMod.Text = "+" + newCharacter.GetAbilityScoreMod(0);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxStr.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(0, 0);
                    lblStrMod.Text = "+0";
                }  
            }
        }
        private void cbxDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxDex.SelectedIndex == cbxStr.SelectedIndex) && (cbxDex.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(0) + ".", "Error");
                                cbxDex.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxDex.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(1, int.Parse(cbxDex.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(1) < 10)
                                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                                    else
                                        lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(1, 0);
                                    lblDexMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxDex.SelectedIndex == cbxCon.SelectedIndex) && (cbxDex.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(2) + ".", "Error");
                                cbxDex.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxDex.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(1, int.Parse(cbxDex.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(1) < 10)
                                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                                    else
                                        lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(1, 0);
                                    lblDexMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxDex.SelectedIndex == cbxInt.SelectedIndex) && (cbxDex.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(3) + ".", "Error");
                                cbxDex.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxDex.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(1, int.Parse(cbxDex.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(1) < 10)
                                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                                    else
                                        lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(1, 0);
                                    lblDexMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxDex.SelectedIndex == cbxWis.SelectedIndex) && (cbxDex.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(4) + ".", "Error");
                                cbxDex.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxDex.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(1, int.Parse(cbxDex.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(1) < 10)
                                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                                    else
                                        lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(1, 0);
                                    lblDexMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxDex.SelectedIndex == cbxCha.SelectedIndex) && (cbxDex.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(5) + ".", "Error");
                                cbxDex.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxDex.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(1, int.Parse(cbxDex.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(1) < 10)
                                        lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                                    else
                                        lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(1, 0);
                                    lblDexMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxDex.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxDex.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(1, value);
                        if (newCharacter.GetAbilityScoreVal(1) < 10)
                            lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
                        else
                            lblDexMod.Text = "+" + newCharacter.GetAbilityScoreMod(1);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxDex.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(1, 0);
                    lblDexMod.Text = "+0";
                }
            }
        }
        private void cbxCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxCon.SelectedIndex == cbxStr.SelectedIndex) && (cbxCon.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(0) + ".", "Error");
                                cbxCon.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCon.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(2, int.Parse(cbxCon.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(2) < 10)
                                        lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                                    else
                                        lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(2, 0);
                                    lblConMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxCon.SelectedIndex == cbxDex.SelectedIndex) && (cbxCon.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(1) + ".", "Error");
                                cbxCon.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCon.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(2, int.Parse(cbxCon.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(2) < 10)
                                        lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                                    else
                                        lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(2, 0);
                                    lblConMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxCon.SelectedIndex == cbxInt.SelectedIndex) && (cbxCon.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(3) + ".", "Error");
                                cbxCon.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCon.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(2, int.Parse(cbxCon.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(2) < 10)
                                        lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                                    else
                                        lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(2, 0);
                                    lblConMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxCon.SelectedIndex == cbxWis.SelectedIndex) && (cbxCon.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(4) + ".", "Error");
                                cbxCon.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCon.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(2, int.Parse(cbxCon.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(2) < 10)
                                        lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                                    else
                                        lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(2, 0);
                                    lblConMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxCon.SelectedIndex == cbxCha.SelectedIndex) && (cbxCon.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(5) + ".", "Error");
                                cbxCon.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCon.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(2, int.Parse(cbxCon.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(2) < 10)
                                        lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                                    else
                                        lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(2, 0);
                                    lblConMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxCon.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxCon.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(2, value);
                        if (newCharacter.GetAbilityScoreVal(2) < 10)
                            lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
                        else
                            lblConMod.Text = "+" + newCharacter.GetAbilityScoreMod(2);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxCon.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(2, 0);
                    lblConMod.Text = "+0";
                }
            }
        }
        private void cbxInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxInt.SelectedIndex == cbxStr.SelectedIndex) && (cbxInt.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(0) + ".", "Error");
                                cbxInt.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxInt.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(3, int.Parse(cbxInt.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(3) < 10)
                                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                                    else
                                        lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(3, 0);
                                    lblIntMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxInt.SelectedIndex == cbxDex.SelectedIndex) && (cbxInt.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(1) + ".", "Error");
                                cbxInt.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxInt.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(3, int.Parse(cbxInt.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(3) < 10)
                                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                                    else
                                        lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(3, 0);
                                    lblIntMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxInt.SelectedIndex == cbxCon.SelectedIndex) && (cbxInt.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(2) + ".", "Error");
                                cbxInt.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxInt.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(3, int.Parse(cbxInt.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(3) < 10)
                                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                                    else
                                        lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(3, 0);
                                    lblIntMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxInt.SelectedIndex == cbxWis.SelectedIndex) && (cbxInt.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(4) + ".", "Error");
                                cbxInt.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxInt.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(3, int.Parse(cbxInt.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(3) < 10)
                                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                                    else
                                        lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(3, 0);
                                    lblIntMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxInt.SelectedIndex == cbxCha.SelectedIndex) && (cbxInt.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(5) + ".", "Error");
                                cbxInt.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxInt.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(3, int.Parse(cbxInt.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(3) < 10)
                                        lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                                    else
                                        lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(3, 0);
                                    lblIntMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxInt.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxInt.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(3, value);
                        if (newCharacter.GetAbilityScoreVal(3) < 10)
                            lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
                        else
                            lblIntMod.Text = "+" + newCharacter.GetAbilityScoreMod(3);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxInt.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(3, 0);
                    lblIntMod.Text = "+0";
                }
            }
        }
        private void cbxWis_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxWis.SelectedIndex == cbxStr.SelectedIndex) && (cbxWis.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(0) + ".", "Error");
                                cbxWis.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxWis.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(4, int.Parse(cbxWis.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(4) < 10)
                                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                                    else
                                        lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(4, 0);
                                    lblWisMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxWis.SelectedIndex == cbxDex.SelectedIndex) && (cbxWis.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(1) + ".", "Error");
                                cbxWis.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxWis.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(4, int.Parse(cbxWis.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(4) < 10)
                                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                                    else
                                        lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(4, 0);
                                    lblWisMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxWis.SelectedIndex == cbxCon.SelectedIndex) && (cbxWis.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(2) + ".", "Error");
                                cbxWis.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxWis.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(4, int.Parse(cbxWis.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(4) < 10)
                                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                                    else
                                        lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(4, 0);
                                    lblWisMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxWis.SelectedIndex == cbxInt.SelectedIndex) && (cbxWis.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(3) + ".", "Error");
                                cbxWis.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxWis.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(4, int.Parse(cbxWis.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(4) < 10)
                                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                                    else
                                        lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(4, 0);
                                    lblWisMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxWis.SelectedIndex == cbxCha.SelectedIndex) && (cbxWis.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(5) + ".", "Error");
                                cbxWis.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxWis.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(4, int.Parse(cbxWis.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(4) < 10)
                                        lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                                    else
                                        lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(4, 0);
                                    lblWisMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxWis.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxWis.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(4, value);
                        if (newCharacter.GetAbilityScoreVal(4) < 10)
                            lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
                        else
                            lblWisMod.Text = "+" + newCharacter.GetAbilityScoreMod(4);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxWis.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(4, 0);
                    lblWisMod.Text = "+0";
                }
            }
        }
        private void cbxCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

            if (menuLvl == 101)
            {
                /* Index of Str Ability = 0
             * Index of Dex Ability = 1
             * Index of Con Ability = 2
             * Index of Int Ability = 3
             * Index of Wis Ability = 4
             * Index of Cha Ability = 5
             */

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if ((cbxCha.SelectedIndex == cbxStr.SelectedIndex) && (cbxCha.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(0) + ".", "Error");
                                cbxCha.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCha.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(5, int.Parse(cbxCha.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(5) < 10)
                                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                                    else
                                        lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(5, 0);
                                    lblChaMod.Text = "+0";
                                }
                            }
                            break;
                        case 1:
                            if ((cbxCha.SelectedIndex == cbxDex.SelectedIndex) && (cbxCha.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(1) + ".", "Error");
                                cbxCha.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCha.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(5, int.Parse(cbxCha.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(5) < 10)
                                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                                    else
                                        lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(5, 0);
                                    lblChaMod.Text = "+0";
                                }
                            }
                            break;
                        case 2:
                            if ((cbxCha.SelectedIndex == cbxCon.SelectedIndex) && (cbxCha.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(2) + ".", "Error");
                                cbxCha.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCha.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(5, int.Parse(cbxCha.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(5) < 10)
                                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                                    else
                                        lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(5, 0);
                                    lblChaMod.Text = "+0";
                                }
                            }
                            break;
                        case 3:
                            if ((cbxCha.SelectedIndex == cbxInt.SelectedIndex) && (cbxCha.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(3) + ".", "Error");
                                cbxCha.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCha.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(5, int.Parse(cbxCha.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(5) < 10)
                                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                                    else
                                        lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(5, 0);
                                    lblChaMod.Text = "+0";
                                }
                            }
                            break;
                        case 4:
                            if ((cbxCha.SelectedIndex == cbxWis.SelectedIndex) && (cbxCha.SelectedIndex != 0))
                            {
                                MessageBox.Show("Values cannot be reused. This value is already used by " + newCharacter.GetAbilityScoreName(4) + ".", "Error");
                                cbxCha.SelectedIndex = 0;
                                i = 5;
                            }
                            else
                            {
                                if (cbxCha.SelectedIndex > 0)
                                {
                                    newCharacter.SetAbilityScoreVal(5, int.Parse(cbxCha.SelectedItem.ToString()));
                                    if (newCharacter.GetAbilityScoreVal(5) < 10)
                                        lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                                    else
                                        lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                                }
                                else
                                {
                                    newCharacter.SetAbilityScoreVal(5, 0);
                                    lblChaMod.Text = "+0";
                                }
                            }
                            break;
                    }
                }
            }
            else if (menuLvl == 102)
            {
                if (cbxCha.SelectedIndex > 0)
                {
                    int value = int.Parse(cbxCha.SelectedItem.ToString());
                    if (CheckPointBuyCap())
                    {
                        newCharacter.SetAbilityScoreVal(5, value);
                        if (newCharacter.GetAbilityScoreVal(5) < 10)
                            lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
                        else
                            lblChaMod.Text = "+" + newCharacter.GetAbilityScoreMod(5);
                    }
                    else
                    {
                        MessageBox.Show("You cannot pick values which exceed the point buy maximum. The Maximum is 25 points across all ability scores.");
                        cbxCha.SelectedIndex = 0;
                    }
                }
                else
                {
                    newCharacter.SetAbilityScoreVal(5, 0);
                    lblChaMod.Text = "+0";
                }
            }
            
        }
        private void cbxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            DataRow search = races.Rows.Find(100);
            DataRow select;

            if (cbxRace.SelectedIndex == 0)
            {
                for (int i = 100; i < 107; i++)
                {
                    search = races.Rows.Find(i);
                    if (newCharacter.GetCharacterRaceName() == search.Field<string>("RaceName"))
                        break;
                }
                select = search;
                for (int i = 0; i < newCharacter.GetAbilityScoresLength(); i++)
                {
                    switch (i)
                    {
                        case 0:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustStr"));
                            break;
                        case 1:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustDex"));
                            break;
                        case 2:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustCon"));
                            break;
                        case 3:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustInt"));
                            break;
                        case 4:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustWis"));
                            break;
                        case 5:
                            newCharacter.SetAdjustRacial(i, -select.Field<int>("AdjustCha"));
                            break;
                    }
                }
                newCharacter.SetCharacterRaceName("");
                newCharacter.SetCharacterFavoriteClass("");
                newCharacter.SetCharacterSize("");
                newCharacter.SetCharacterSpeed(0);
            }
            else
            {
                for (int i = 100; i < 107; i++)
                {
                    search = races.Rows.Find(i);
                    if (cbxRace.SelectedItem == search.Field<string>("RaceName"))
                        break;
                }
                select = search;
                for (int i = 0; i < newCharacter.GetAbilityScoresLength(); i++)
                {
                    switch (i)
                    {
                        case 0:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustStr"));
                            break;
                        case 1:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustDex"));
                            break;
                        case 2:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustCon"));
                            break;
                        case 3:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustInt"));
                            break;
                        case 4:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustWis"));
                            break;
                        case 5:
                            newCharacter.SetAdjustRacial(i, select.Field<int>("AdjustCha"));
                            break;
                    }
                }
                newCharacter.SetCharacterRaceName(select.Field<string>("RaceName"));
                newCharacter.SetCharacterFavoriteClass(select.Field<string>("FavoriteClass"));
                newCharacter.SetCharacterSize(select.Field<string>("Size"));
                newCharacter.SetCharacterSpeed(select.Field<int>("Speed"));
            }
            lblStrRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(0).ToString();
            lblDexRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(1).ToString();
            lblConRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(2).ToString();
            lblIntRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(3).ToString();
            lblWisRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(4).ToString();
            lblChaRacialAdjust.Text = newCharacter.GetAbilityScoreRacialAdjustment(5).ToString();
            lblStrMod.Text = newCharacter.GetAbilityScoreMod(0).ToString();
            lblDexMod.Text = newCharacter.GetAbilityScoreMod(1).ToString();
            lblConMod.Text = newCharacter.GetAbilityScoreMod(2).ToString();
            lblIntMod.Text = newCharacter.GetAbilityScoreMod(3).ToString();
            lblWisMod.Text = newCharacter.GetAbilityScoreMod(4).ToString();
            lblChaMod.Text = newCharacter.GetAbilityScoreMod(5).ToString();
        }
        

        //Die roll methods
        private int D2()
        {
            Random d = new Random();
            int result = d.Next(0, 2) + 1;
            return result;
        }
        private int D4()
        {
            Random d = new Random();
            int result = d.Next(0, 4) + 1;
            return result;
        }
        private int D6()
        {
            Random d = new Random();
            int result = d.Next(0, 6) + 1;
            return result;
        }
        private int D8()
        {
            Random d = new Random();
            int result = d.Next(0, 8) + 1;
            return result;
        }
        private int D10()
        {
            Random d = new Random();
            int result = d.Next(0, 10) + 1;
            return result;
        }
        private int D12()
        {
            Random d = new Random();
            int result = d.Next(0, 12) + 1;
            return result;
        }
        private int D20()
        {
            Random d = new Random();
            int result = d.Next(0, 20) + 1;
            return result;
        }
        private int Dpercent()
        {
            Random d = new Random();
            int result = d.Next(0, 100) + 1;
            return result;
        }

        
    }
}
