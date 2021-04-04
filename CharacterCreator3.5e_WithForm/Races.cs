using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator3._5e_WithForm
{
    class Dwarf : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private List<int> hitDice = new List<int>();
        private int[,] alignment = new int[3, 3];

        private int ecl;

        //Ability Score variable Gets and Sets
        //Gets
        public override string GetAbilityScoreName(int i)
        {
            return abilityScores[i].Name;
        }
        public override int GetAbilityScoreRacialAdjustment(int i)
        {
            return abilityScores[i].AdjustRacial;
        }
        public override int GetAbilityScoreVal(int i)
        {
            return abilityScores[i].Val;
        }
        public override int GetAbilityScoreMod(int i)
        {
            int modVal = abilityScores[i].Val + abilityScores[i].AdjustRacial + abilityScores[i].Temp;
            if (modVal > 10)
            {
                return (modVal - 10) / 2;
            }
            else if (modVal < 10)
            {
                return (modVal / 2) + -5;
            }
            return 0;
        }
        public override int GetAbilityScoresLength()
        {
            return abilityScores.Length;
        }
        //Sets
        public override void SetAbilityScoreVal(int i, int v)
        {
            abilityScores[i].Val = v;
        }
        public override void SetAdjustRacial(int i, int v)
        {
            abilityScores[i].AdjustRacial = v;
        }
        //attributes struct Gets and Sets
        //Gets
        public override string GetCharacterRaceName()
        {
            return attributes.RaceName;
        }
        public override string GetCharacterFavoriteClass()
        {
            return attributes.FClass;
        }
        public override string GetCharacterSize()
        {
            return attributes.Size;
        }
        public override int GetCharacterSpeed()
        {
            return attributes.Speed;
        }
        //Sets
        public override void SetCharacterRaceName(string i)
        {
            attributes.RaceName = i;
        }
        public override void SetCharacterFavoriteClass(string i)
        {
            attributes.FClass = i;
        }
        public override void SetCharacterSpeed(int i)
        {
            attributes.Speed = i;
        }
        public override void SetCharacterSize(string i)
        {
            attributes.Size = i;
        }
        public Dwarf()
        {
            //100: index of gnome data row in table races
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            DataRow race = races.Rows.Find(100);

            attributes.CharName = "Name";
            attributes.RaceName = race.Field<string>("RaceName");
            attributes.FClass = race.Field<string>("FavoriteClass");
            attributes.Size = race.Field<string>("Size");
            attributes.Speed = race.Field<int>("Speed");

            WriteAbilityScoreNames();
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustStr");
                        break;
                    case 1:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustDex");
                        break;
                    case 2:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCon");
                        break;
                    case 3:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustInt");
                        break;
                    case 4:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustWis");
                        break;
                    case 5:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCha");
                        break;
                }
            }
        }
        private void WriteAbilityScoreNames()
        {
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        abilityScores[i].Name = "Strength";
                        break;
                    case 1:
                        abilityScores[i].Name = "Dexterity";
                        break;
                    case 2:
                        abilityScores[i].Name = "Constitution";
                        break;
                    case 3:
                        abilityScores[i].Name = "Intelligence";
                        break;
                    case 4:
                        abilityScores[i].Name = "Wisdom";
                        break;
                    case 5:
                        abilityScores[i].Name = "Charisma";
                        break;
                }
            }
        }
    }
    class Gnome : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private List<int> hitDice = new List<int>();
        private int[,] alignment = new int[3, 3];

        private int ecl;

        //Ability Score variable Gets and Sets
        //Gets
        public override string GetAbilityScoreName(int i)
        {
            return abilityScores[i].Name;
        }
        public override int GetAbilityScoreRacialAdjustment(int i)
        {
            return abilityScores[i].AdjustRacial;
        }
        public override int GetAbilityScoreVal(int i)
        {
            return abilityScores[i].Val;
        }
        public override int GetAbilityScoreMod(int i)
        {
            int modVal = abilityScores[i].Val + abilityScores[i].AdjustRacial + abilityScores[i].Temp;
            if (modVal > 10)
            {
                return (modVal - 10) / 2;
            }
            else if (modVal < 10)
            {
                return (modVal / 2) + -5;
            }
            return 0;
        }
        public override int GetAbilityScoresLength()
        {
            return abilityScores.Length;
        }
        //Sets
        public override void SetAbilityScoreVal(int i, int v)
        {
            abilityScores[i].Val = v;
        }
        public override void SetAdjustRacial(int i, int v)
        {
            abilityScores[i].AdjustRacial = v;
        }
        //attributes struct Gets and Sets
        //Gets
        public override string GetCharacterRaceName()
        {
            return attributes.RaceName;
        }
        public override string GetCharacterFavoriteClass()
        {
            return attributes.FClass;
        }
        public override string GetCharacterSize()
        {
            return attributes.Size;
        }
        public override int GetCharacterSpeed()
        {
            return attributes.Speed;
        }
        //Sets
        public override void SetCharacterRaceName(string i)
        {
            attributes.RaceName = i;
        }
        public override void SetCharacterFavoriteClass(string i)
        {
            attributes.FClass = i;
        }
        public override void SetCharacterSpeed(int i)
        {
            attributes.Speed = i;
        }
        public override void SetCharacterSize(string i)
        {
            attributes.Size = i;
        }
        public Gnome()
        {
            //102: index of gnome data row in table races
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            DataRow race = races.Rows.Find(102);

            attributes.CharName = "Name";
            attributes.RaceName = race.Field<string>("RaceName");
            attributes.FClass = race.Field<string>("FavoriteClass");
            attributes.Size = race.Field<string>("Size");
            attributes.Speed = race.Field<int>("Speed");

            WriteAbilityScoreNames();
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustStr");
                        break;
                    case 1:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustDex");
                        break;
                    case 2:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCon");
                        break;
                    case 3:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustInt");
                        break;
                    case 4:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustWis");
                        break;
                    case 5:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCha");
                        break;
                }
            }
        }
        private void WriteAbilityScoreNames()
        {
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        abilityScores[i].Name = "Strength";
                        break;
                    case 1:
                        abilityScores[i].Name = "Dexterity";
                        break;
                    case 2:
                        abilityScores[i].Name = "Constitution";
                        break;
                    case 3:
                        abilityScores[i].Name = "Intelligence";
                        break;
                    case 4:
                        abilityScores[i].Name = "Wisdom";
                        break;
                    case 5:
                        abilityScores[i].Name = "Charisma";
                        break;
                }
            }
        }
    }
    class Human : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private List<int> hitDice = new List<int>();
        private int[,] alignment = new int[3, 3];

        private int ecl;

        //Ability Score variable Gets and Sets
        //Gets
        public override string GetAbilityScoreName(int i)
        {
            return abilityScores[i].Name;
        }
        public override int GetAbilityScoreRacialAdjustment(int i)
        {
            return abilityScores[i].AdjustRacial;
        }
        public override int GetAbilityScoreVal(int i)
        {
            return abilityScores[i].Val;
        }
        public override int GetAbilityScoreMod(int i)
        {
            int modVal = abilityScores[i].Val + abilityScores[i].AdjustRacial + abilityScores[i].Temp;
            if (modVal > 10)
            {
                return (modVal - 10) / 2;
            }
            else if (modVal < 10)
            {
                return (modVal / 2) + -5;
            }
            return 0;
        }
        public override int GetAbilityScoresLength()
        {
            return abilityScores.Length;
        }
        //Sets
        public override void SetAbilityScoreVal(int i, int v)
        {
            abilityScores[i].Val = v;
        }
        public override void SetAdjustRacial(int i, int v)
        {
            abilityScores[i].AdjustRacial = v;
        }
        //attributes struct Gets and Sets
        //Gets
        public override string GetCharacterRaceName()
        {
            return attributes.RaceName;
        }
        public override string GetCharacterFavoriteClass()
        {
            return attributes.FClass;
        }
        public override string GetCharacterSize()
        {
            return attributes.Size;
        }
        public override int GetCharacterSpeed()
        {
            return attributes.Speed;
        }
        //Sets
        public override void SetCharacterRaceName(string i)
        {
            attributes.RaceName = i;
        }
        public override void SetCharacterFavoriteClass(string i)
        {
            attributes.FClass = i;
        }
        public override void SetCharacterSpeed(int i)
        {
            attributes.Speed = i;
        }
        public override void SetCharacterSize(string i)
        {
            attributes.Size = i;
        }
        public Human()
        {
            //106: index of human data row in table races
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            DataRow race = races.Rows.Find(106);

            attributes.CharName = "Name";
            attributes.RaceName = race.Field<string>("RaceName");
            attributes.FClass = race.Field<string>("FavoriteClass");
            attributes.Size = race.Field<string>("Size");
            attributes.Speed = race.Field<int>("Speed");

            WriteAbilityScoreNames();
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustStr");
                        break;
                    case 1:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustDex");
                        break;
                    case 2:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCon");
                        break;
                    case 3:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustInt");
                        break;
                    case 4:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustWis");
                        break;
                    case 5:
                        abilityScores[i].AdjustRacial = race.Field<int>("AdjustCha");
                        break;
                }
            }
        }
        private void WriteAbilityScoreNames()
        {
            for (int i = 0; i < abilityScores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        abilityScores[i].Name = "Strength";
                        break;
                    case 1:
                        abilityScores[i].Name = "Dexterity";
                        break;
                    case 2:
                        abilityScores[i].Name = "Constitution";
                        break;
                    case 3:
                        abilityScores[i].Name = "Intelligence";
                        break;
                    case 4:
                        abilityScores[i].Name = "Wisdom";
                        break;
                    case 5:
                        abilityScores[i].Name = "Charisma";
                        break;
                }
            }
        }
    }
}
