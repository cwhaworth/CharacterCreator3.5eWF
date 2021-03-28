using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CharacterCreator3._5e_WithForm
{
    class Character
    {
        struct Race
        {
            private string name;
            private string fClass;
            private string size;
            private int speed;


            public string Name
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
        
        private Ability[] abilityScores = new Ability[6];
        private Race chaRace = new Race();
        private string name;
        
        private List<int> hitDice = new List<int>();
        private int[,] alignment = new int[3, 3];

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

        //Race variable Gets and Sets
        //Gets
        public string GetCharacterRaceName()
        {
            return chaRace.Name;
        }
        public string GetCharacterFavoriteClass()
        {
            return chaRace.FClass;
        }
        public string GetCharacterSize()
        {
            return chaRace.Size;
        }
        public int GetCharacterSpeed()
        {
            return chaRace.Speed;
        }
        //Sets
        public void SetCharacterRaceName(string i)
        {
            chaRace.Name = i; 
        }
        public void SetCharacterFavoriteClass(string i)
        {
            chaRace.FClass = i;
        }
        public void SetCharacterSize(string i)
        {
            chaRace.Size = i;
        }
        public void SetCharacterSpeed(int i)
        {
            chaRace.Speed = i;
        }

        //Constructors
        public Character()
        {
            WriteAbilityScoreNames();
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
