using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CharacterCreator3._5e_WithForm
{
    
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
