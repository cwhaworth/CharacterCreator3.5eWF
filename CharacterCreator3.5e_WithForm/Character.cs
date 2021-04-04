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
    abstract class Character
    {
        //Ability Score variable Gets and Sets
        //Gets
        public abstract string GetAbilityScoreName(int i);
        public abstract int GetAbilityScoreRacialAdjustment(int i);
        public abstract int GetAbilityScoreVal(int i);
        public abstract int GetAbilityScoreMod(int i);
        public abstract int GetAbilityScoresLength();
        //Sets
        public abstract void SetAbilityScoreVal(int i, int v);
        public abstract void SetAdjustRacial(int i, int v);

        //attributes struct variable Gets and Sets
        //Gets
        public abstract string GetCharacterRaceName();
        public abstract string GetCharacterFavoriteClass();
        public abstract string GetCharacterSize();
        public abstract int GetCharacterSpeed();
        //Sets
        public abstract void SetCharacterRaceName(string i);
        public abstract void SetCharacterFavoriteClass(string i);
        public abstract void SetCharacterSize(string i);
        public abstract void SetCharacterSpeed(int i);
        //Methods
    }
}
