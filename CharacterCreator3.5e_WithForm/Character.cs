using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CharacterCreator3._5e_WithForm
{
    struct Attributes
    {
        private string charName;
        private string raceName;
        private string fClass;
        private string size;
        private int speed;
        private int ecl;

        public string CharName
        {
            get;
            set;
        }
        public string RaceName
        {
            get;
            set;
        }
        public string FClass
        {
            get;
            set;
        }
        public string Size
        {
            get;
            set;
        }
        public int Speed
        {
            get;
            set;
        }
    }
    struct Ability
    {

        private string name;
        private int temp;
        private int adjustRacial;
        private int val;

        public string Name
        {
            get;
            set;
        }
        public int Temp
        {
            get;
            set;
        }

        public int AdjustRacial
        {
            get;
            set;
        }
        public int Val
        {
            get;
            set;
        }
    }
    class Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private List<CharacterClass> classes = new List<CharacterClass>();
        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

        private Race race;

        private int[] alignment = new int[2];

        private int ecl;

        //Ability Score variable Gets and Sets
        //Gets
        public string GetAbilityScoreName(int i)
        {
            return abilityScores[i].Name;
        }
        public int GetAbilityScoreRacialAdjustment(int i)
        {
            return abilityScores[i].AdjustRacial;
        }
        public int GetAbilityScoreVal(int i)
        {
            return abilityScores[i].Val;
        }
        public int GetAbilityScoreMod(int i)
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
        public int GetAbilityScoresLength()
        {
            return abilityScores.Length;
        }
        //Sets
        public void SetAbilityScoreVal(int i, int v)
        {
            abilityScores[i].Val = v;
        }
        public void SetAdjustRacial(int i, int v)
        {
            abilityScores[i].AdjustRacial = v;
        }
        //attributes struct Gets and Sets
        //Gets
        public string GetCharacterRaceName()
        {
            return attributes.RaceName;
        }
        public string GetCharacterFavoriteClass()
        {
            return attributes.FClass;
        }
        public string GetCharacterSize()
        {
            return attributes.Size;
        }
        public int GetCharacterSpeed()
        {
            return attributes.Speed;
        }
        //Sets
        public void SetCharacterRaceName(string i)
        {
            attributes.RaceName = i;
        }
        public void SetCharacterFavoriteClass(string i)
        {
            attributes.FClass = i;
        }
        public void SetCharacterSpeed(int i)
        {
            attributes.Speed = i;
        }
        public void SetCharacterSize(string i)
        {
            attributes.Size = i;
        }
        public Character()
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
}