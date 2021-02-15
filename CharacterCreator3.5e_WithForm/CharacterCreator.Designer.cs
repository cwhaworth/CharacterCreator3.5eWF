
namespace CharacterCreator3._5e_WithForm
{
    partial class frmMain
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
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.btnLoadCharacter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnPointBuy = new System.Windows.Forms.Button();
            this.btnRandomCharacter = new System.Windows.Forms.Button();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblRaceHeader = new System.Windows.Forms.Label();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.lblAbilityRollsHeader = new System.Windows.Forms.Label();
            this.lblAbilityRolls = new System.Windows.Forms.Label();
            this.lblStrHeader = new System.Windows.Forms.Label();
            this.cbxStr = new System.Windows.Forms.ComboBox();
            this.cbxDex = new System.Windows.Forms.ComboBox();
            this.cbxCon = new System.Windows.Forms.ComboBox();
            this.cbxInt = new System.Windows.Forms.ComboBox();
            this.cbxWis = new System.Windows.Forms.ComboBox();
            this.cbxCha = new System.Windows.Forms.ComboBox();
            this.lblDexHeader = new System.Windows.Forms.Label();
            this.lblConHeader = new System.Windows.Forms.Label();
            this.lblIntHeader = new System.Windows.Forms.Label();
            this.lblWisHeader = new System.Windows.Forms.Label();
            this.lblChaHeader = new System.Windows.Forms.Label();
            this.lblStrMod = new System.Windows.Forms.Label();
            this.lblDexMod = new System.Windows.Forms.Label();
            this.lblConMod = new System.Windows.Forms.Label();
            this.lblIntMod = new System.Windows.Forms.Label();
            this.lblWisMod = new System.Windows.Forms.Label();
            this.lblChaMod = new System.Windows.Forms.Label();
            this.lblChaRacialAdjust = new System.Windows.Forms.Label();
            this.lblWisRacialAdjust = new System.Windows.Forms.Label();
            this.lblIntRacialAdjust = new System.Windows.Forms.Label();
            this.lblConRacialAdjust = new System.Windows.Forms.Label();
            this.lblDexRacialAdjust = new System.Windows.Forms.Label();
            this.lblStrRacialAdjust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Location = new System.Drawing.Point(308, 246);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(111, 23);
            this.btnNewCharacter.TabIndex = 0;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // btnLoadCharacter
            // 
            this.btnLoadCharacter.Location = new System.Drawing.Point(308, 275);
            this.btnLoadCharacter.Name = "btnLoadCharacter";
            this.btnLoadCharacter.Size = new System.Drawing.Size(111, 23);
            this.btnLoadCharacter.TabIndex = 1;
            this.btnLoadCharacter.Text = "Load Character";
            this.btnLoadCharacter.UseVisualStyleBackColor = true;
            this.btnLoadCharacter.Click += new System.EventHandler(this.btnLoadCharacter_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(308, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(308, 260);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(111, 23);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll Ability Scores";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Visible = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnPointBuy
            // 
            this.btnPointBuy.Location = new System.Drawing.Point(308, 289);
            this.btnPointBuy.Name = "btnPointBuy";
            this.btnPointBuy.Size = new System.Drawing.Size(111, 23);
            this.btnPointBuy.TabIndex = 4;
            this.btnPointBuy.Text = "Point Buy";
            this.btnPointBuy.UseVisualStyleBackColor = true;
            this.btnPointBuy.Visible = false;
            this.btnPointBuy.Click += new System.EventHandler(this.btnPointBuy_Click);
            // 
            // btnRandomCharacter
            // 
            this.btnRandomCharacter.Location = new System.Drawing.Point(308, 231);
            this.btnRandomCharacter.Name = "btnRandomCharacter";
            this.btnRandomCharacter.Size = new System.Drawing.Size(111, 23);
            this.btnRandomCharacter.TabIndex = 5;
            this.btnRandomCharacter.Text = "Random Character";
            this.btnRandomCharacter.UseVisualStyleBackColor = true;
            this.btnRandomCharacter.Visible = false;
            this.btnRandomCharacter.Click += new System.EventHandler(this.btnRandomCharacter_Click);
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(12, 9);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(38, 13);
            this.lblCharacterName.TabIndex = 6;
            this.lblCharacterName.Text = "Name:";
            this.lblCharacterName.Visible = false;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(53, 6);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(134, 20);
            this.txtCharacterName.TabIndex = 7;
            this.txtCharacterName.Visible = false;
            // 
            // lblRaceHeader
            // 
            this.lblRaceHeader.AutoSize = true;
            this.lblRaceHeader.Location = new System.Drawing.Point(12, 231);
            this.lblRaceHeader.Name = "lblRaceHeader";
            this.lblRaceHeader.Size = new System.Drawing.Size(36, 13);
            this.lblRaceHeader.TabIndex = 8;
            this.lblRaceHeader.Text = "Race:";
            this.lblRaceHeader.Visible = false;
            // 
            // cbxRace
            // 
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Location = new System.Drawing.Point(53, 228);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(121, 21);
            this.cbxRace.TabIndex = 9;
            this.cbxRace.Visible = false;
            this.cbxRace.SelectedIndexChanged += new System.EventHandler(this.cbxRace_SelectedIndexChanged);
            // 
            // lblAbilityRollsHeader
            // 
            this.lblAbilityRollsHeader.AutoSize = true;
            this.lblAbilityRollsHeader.Location = new System.Drawing.Point(12, 31);
            this.lblAbilityRollsHeader.Name = "lblAbilityRollsHeader";
            this.lblAbilityRollsHeader.Size = new System.Drawing.Size(60, 13);
            this.lblAbilityRollsHeader.TabIndex = 10;
            this.lblAbilityRollsHeader.Text = "Ability Rolls";
            this.lblAbilityRollsHeader.Visible = false;
            // 
            // lblAbilityRolls
            // 
            this.lblAbilityRolls.AutoSize = true;
            this.lblAbilityRolls.Location = new System.Drawing.Point(12, 44);
            this.lblAbilityRolls.Name = "lblAbilityRolls";
            this.lblAbilityRolls.Size = new System.Drawing.Size(78, 13);
            this.lblAbilityRolls.TabIndex = 11;
            this.lblAbilityRolls.Text = "Gets Replaced";
            this.lblAbilityRolls.Visible = false;
            // 
            // lblStrHeader
            // 
            this.lblStrHeader.AutoSize = true;
            this.lblStrHeader.Location = new System.Drawing.Point(12, 66);
            this.lblStrHeader.Name = "lblStrHeader";
            this.lblStrHeader.Size = new System.Drawing.Size(23, 13);
            this.lblStrHeader.TabIndex = 12;
            this.lblStrHeader.Text = "Str:";
            this.lblStrHeader.Visible = false;
            // 
            // cbxStr
            // 
            this.cbxStr.FormattingEnabled = true;
            this.cbxStr.Location = new System.Drawing.Point(80, 63);
            this.cbxStr.Name = "cbxStr";
            this.cbxStr.Size = new System.Drawing.Size(37, 21);
            this.cbxStr.TabIndex = 13;
            this.cbxStr.Visible = false;
            this.cbxStr.SelectedIndexChanged += new System.EventHandler(this.cbxStr_SelectedIndexChanged);
            // 
            // cbxDex
            // 
            this.cbxDex.FormattingEnabled = true;
            this.cbxDex.Location = new System.Drawing.Point(80, 90);
            this.cbxDex.Name = "cbxDex";
            this.cbxDex.Size = new System.Drawing.Size(37, 21);
            this.cbxDex.TabIndex = 14;
            this.cbxDex.Visible = false;
            this.cbxDex.SelectedIndexChanged += new System.EventHandler(this.cbxDex_SelectedIndexChanged);
            // 
            // cbxCon
            // 
            this.cbxCon.FormattingEnabled = true;
            this.cbxCon.Location = new System.Drawing.Point(80, 117);
            this.cbxCon.Name = "cbxCon";
            this.cbxCon.Size = new System.Drawing.Size(37, 21);
            this.cbxCon.TabIndex = 15;
            this.cbxCon.Visible = false;
            this.cbxCon.SelectedIndexChanged += new System.EventHandler(this.cbxCon_SelectedIndexChanged);
            // 
            // cbxInt
            // 
            this.cbxInt.FormattingEnabled = true;
            this.cbxInt.Location = new System.Drawing.Point(80, 144);
            this.cbxInt.Name = "cbxInt";
            this.cbxInt.Size = new System.Drawing.Size(37, 21);
            this.cbxInt.TabIndex = 16;
            this.cbxInt.Visible = false;
            this.cbxInt.SelectedIndexChanged += new System.EventHandler(this.cbxInt_SelectedIndexChanged);
            // 
            // cbxWis
            // 
            this.cbxWis.FormattingEnabled = true;
            this.cbxWis.Location = new System.Drawing.Point(80, 171);
            this.cbxWis.Name = "cbxWis";
            this.cbxWis.Size = new System.Drawing.Size(37, 21);
            this.cbxWis.TabIndex = 17;
            this.cbxWis.Visible = false;
            this.cbxWis.SelectedIndexChanged += new System.EventHandler(this.cbxWis_SelectedIndexChanged);
            // 
            // cbxCha
            // 
            this.cbxCha.FormattingEnabled = true;
            this.cbxCha.Location = new System.Drawing.Point(80, 198);
            this.cbxCha.Name = "cbxCha";
            this.cbxCha.Size = new System.Drawing.Size(37, 21);
            this.cbxCha.TabIndex = 18;
            this.cbxCha.Visible = false;
            this.cbxCha.SelectedIndexChanged += new System.EventHandler(this.cbxCha_SelectedIndexChanged);
            // 
            // lblDexHeader
            // 
            this.lblDexHeader.AutoSize = true;
            this.lblDexHeader.Location = new System.Drawing.Point(12, 93);
            this.lblDexHeader.Name = "lblDexHeader";
            this.lblDexHeader.Size = new System.Drawing.Size(29, 13);
            this.lblDexHeader.TabIndex = 19;
            this.lblDexHeader.Text = "Dex:";
            this.lblDexHeader.Visible = false;
            // 
            // lblConHeader
            // 
            this.lblConHeader.AutoSize = true;
            this.lblConHeader.Location = new System.Drawing.Point(12, 120);
            this.lblConHeader.Name = "lblConHeader";
            this.lblConHeader.Size = new System.Drawing.Size(29, 13);
            this.lblConHeader.TabIndex = 20;
            this.lblConHeader.Text = "Con:";
            this.lblConHeader.Visible = false;
            // 
            // lblIntHeader
            // 
            this.lblIntHeader.AutoSize = true;
            this.lblIntHeader.Location = new System.Drawing.Point(12, 147);
            this.lblIntHeader.Name = "lblIntHeader";
            this.lblIntHeader.Size = new System.Drawing.Size(22, 13);
            this.lblIntHeader.TabIndex = 21;
            this.lblIntHeader.Text = "Int:";
            this.lblIntHeader.Visible = false;
            // 
            // lblWisHeader
            // 
            this.lblWisHeader.AutoSize = true;
            this.lblWisHeader.Location = new System.Drawing.Point(12, 174);
            this.lblWisHeader.Name = "lblWisHeader";
            this.lblWisHeader.Size = new System.Drawing.Size(28, 13);
            this.lblWisHeader.TabIndex = 22;
            this.lblWisHeader.Text = "Wis:";
            this.lblWisHeader.Visible = false;
            // 
            // lblChaHeader
            // 
            this.lblChaHeader.AutoSize = true;
            this.lblChaHeader.Location = new System.Drawing.Point(12, 201);
            this.lblChaHeader.Name = "lblChaHeader";
            this.lblChaHeader.Size = new System.Drawing.Size(29, 13);
            this.lblChaHeader.TabIndex = 23;
            this.lblChaHeader.Text = "Cha:";
            this.lblChaHeader.Visible = false;
            // 
            // lblStrMod
            // 
            this.lblStrMod.AutoSize = true;
            this.lblStrMod.Location = new System.Drawing.Point(46, 66);
            this.lblStrMod.Name = "lblStrMod";
            this.lblStrMod.Size = new System.Drawing.Size(28, 13);
            this.lblStrMod.TabIndex = 24;
            this.lblStrMod.Text = "+0 =";
            this.lblStrMod.Visible = false;
            // 
            // lblDexMod
            // 
            this.lblDexMod.AutoSize = true;
            this.lblDexMod.Location = new System.Drawing.Point(46, 93);
            this.lblDexMod.Name = "lblDexMod";
            this.lblDexMod.Size = new System.Drawing.Size(28, 13);
            this.lblDexMod.TabIndex = 25;
            this.lblDexMod.Text = "+0 =";
            this.lblDexMod.Visible = false;
            // 
            // lblConMod
            // 
            this.lblConMod.AutoSize = true;
            this.lblConMod.Location = new System.Drawing.Point(46, 120);
            this.lblConMod.Name = "lblConMod";
            this.lblConMod.Size = new System.Drawing.Size(28, 13);
            this.lblConMod.TabIndex = 26;
            this.lblConMod.Text = "+0 =";
            this.lblConMod.Visible = false;
            // 
            // lblIntMod
            // 
            this.lblIntMod.AutoSize = true;
            this.lblIntMod.Location = new System.Drawing.Point(46, 147);
            this.lblIntMod.Name = "lblIntMod";
            this.lblIntMod.Size = new System.Drawing.Size(28, 13);
            this.lblIntMod.TabIndex = 27;
            this.lblIntMod.Text = "+0 =";
            this.lblIntMod.Visible = false;
            // 
            // lblWisMod
            // 
            this.lblWisMod.AutoSize = true;
            this.lblWisMod.Location = new System.Drawing.Point(46, 174);
            this.lblWisMod.Name = "lblWisMod";
            this.lblWisMod.Size = new System.Drawing.Size(28, 13);
            this.lblWisMod.TabIndex = 28;
            this.lblWisMod.Text = "+0 =";
            this.lblWisMod.Visible = false;
            // 
            // lblChaMod
            // 
            this.lblChaMod.AutoSize = true;
            this.lblChaMod.Location = new System.Drawing.Point(46, 201);
            this.lblChaMod.Name = "lblChaMod";
            this.lblChaMod.Size = new System.Drawing.Size(28, 13);
            this.lblChaMod.TabIndex = 29;
            this.lblChaMod.Text = "+0 =";
            this.lblChaMod.Visible = false;
            // 
            // lblChaRacialAdjust
            // 
            this.lblChaRacialAdjust.AutoSize = true;
            this.lblChaRacialAdjust.Location = new System.Drawing.Point(123, 201);
            this.lblChaRacialAdjust.Name = "lblChaRacialAdjust";
            this.lblChaRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblChaRacialAdjust.TabIndex = 35;
            this.lblChaRacialAdjust.Text = "+0";
            this.lblChaRacialAdjust.Visible = false;
            // 
            // lblWisRacialAdjust
            // 
            this.lblWisRacialAdjust.AutoSize = true;
            this.lblWisRacialAdjust.Location = new System.Drawing.Point(123, 174);
            this.lblWisRacialAdjust.Name = "lblWisRacialAdjust";
            this.lblWisRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblWisRacialAdjust.TabIndex = 34;
            this.lblWisRacialAdjust.Text = "+0";
            this.lblWisRacialAdjust.Visible = false;
            // 
            // lblIntRacialAdjust
            // 
            this.lblIntRacialAdjust.AutoSize = true;
            this.lblIntRacialAdjust.Location = new System.Drawing.Point(123, 147);
            this.lblIntRacialAdjust.Name = "lblIntRacialAdjust";
            this.lblIntRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblIntRacialAdjust.TabIndex = 33;
            this.lblIntRacialAdjust.Text = "+0";
            this.lblIntRacialAdjust.Visible = false;
            // 
            // lblConRacialAdjust
            // 
            this.lblConRacialAdjust.AutoSize = true;
            this.lblConRacialAdjust.Location = new System.Drawing.Point(123, 120);
            this.lblConRacialAdjust.Name = "lblConRacialAdjust";
            this.lblConRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblConRacialAdjust.TabIndex = 32;
            this.lblConRacialAdjust.Text = "+0";
            this.lblConRacialAdjust.Visible = false;
            // 
            // lblDexRacialAdjust
            // 
            this.lblDexRacialAdjust.AutoSize = true;
            this.lblDexRacialAdjust.Location = new System.Drawing.Point(123, 93);
            this.lblDexRacialAdjust.Name = "lblDexRacialAdjust";
            this.lblDexRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblDexRacialAdjust.TabIndex = 31;
            this.lblDexRacialAdjust.Text = "+0";
            this.lblDexRacialAdjust.Visible = false;
            // 
            // lblStrRacialAdjust
            // 
            this.lblStrRacialAdjust.AutoSize = true;
            this.lblStrRacialAdjust.Location = new System.Drawing.Point(123, 66);
            this.lblStrRacialAdjust.Name = "lblStrRacialAdjust";
            this.lblStrRacialAdjust.Size = new System.Drawing.Size(19, 13);
            this.lblStrRacialAdjust.TabIndex = 30;
            this.lblStrRacialAdjust.Text = "+0";
            this.lblStrRacialAdjust.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 602);
            this.Controls.Add(this.lblChaRacialAdjust);
            this.Controls.Add(this.lblWisRacialAdjust);
            this.Controls.Add(this.lblIntRacialAdjust);
            this.Controls.Add(this.lblConRacialAdjust);
            this.Controls.Add(this.lblDexRacialAdjust);
            this.Controls.Add(this.lblStrRacialAdjust);
            this.Controls.Add(this.lblChaMod);
            this.Controls.Add(this.lblWisMod);
            this.Controls.Add(this.lblIntMod);
            this.Controls.Add(this.lblConMod);
            this.Controls.Add(this.lblDexMod);
            this.Controls.Add(this.lblStrMod);
            this.Controls.Add(this.lblChaHeader);
            this.Controls.Add(this.lblWisHeader);
            this.Controls.Add(this.lblIntHeader);
            this.Controls.Add(this.lblConHeader);
            this.Controls.Add(this.lblDexHeader);
            this.Controls.Add(this.cbxCha);
            this.Controls.Add(this.cbxWis);
            this.Controls.Add(this.cbxInt);
            this.Controls.Add(this.cbxCon);
            this.Controls.Add(this.cbxDex);
            this.Controls.Add(this.cbxStr);
            this.Controls.Add(this.lblStrHeader);
            this.Controls.Add(this.lblAbilityRolls);
            this.Controls.Add(this.lblAbilityRollsHeader);
            this.Controls.Add(this.cbxRace);
            this.Controls.Add(this.lblRaceHeader);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.btnRandomCharacter);
            this.Controls.Add(this.btnPointBuy);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoadCharacter);
            this.Controls.Add(this.btnNewCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Character Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.Button btnLoadCharacter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnPointBuy;
        private System.Windows.Forms.Button btnRandomCharacter;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblRaceHeader;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.Label lblAbilityRollsHeader;
        private System.Windows.Forms.Label lblAbilityRolls;
        private System.Windows.Forms.Label lblStrHeader;
        private System.Windows.Forms.ComboBox cbxStr;
        private System.Windows.Forms.ComboBox cbxDex;
        private System.Windows.Forms.ComboBox cbxCon;
        private System.Windows.Forms.ComboBox cbxInt;
        private System.Windows.Forms.ComboBox cbxWis;
        private System.Windows.Forms.ComboBox cbxCha;
        private System.Windows.Forms.Label lblDexHeader;
        private System.Windows.Forms.Label lblConHeader;
        private System.Windows.Forms.Label lblIntHeader;
        private System.Windows.Forms.Label lblWisHeader;
        private System.Windows.Forms.Label lblChaHeader;
        private System.Windows.Forms.Label lblStrMod;
        private System.Windows.Forms.Label lblDexMod;
        private System.Windows.Forms.Label lblConMod;
        private System.Windows.Forms.Label lblIntMod;
        private System.Windows.Forms.Label lblWisMod;
        private System.Windows.Forms.Label lblChaMod;
        private System.Windows.Forms.Label lblChaRacialAdjust;
        private System.Windows.Forms.Label lblWisRacialAdjust;
        private System.Windows.Forms.Label lblIntRacialAdjust;
        private System.Windows.Forms.Label lblConRacialAdjust;
        private System.Windows.Forms.Label lblDexRacialAdjust;
        private System.Windows.Forms.Label lblStrRacialAdjust;
    }
}

