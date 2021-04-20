using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator3._5e_WithForm
{
    abstract class CharacterClass
    {
        public abstract int GetBaseAtkBonus();
        public abstract int GetFortSave();
        public abstract int GetRefSave();
        public abstract int GetWillSave();
    }
    abstract class Race
    {
        public abstract string GetFavoriteClass();
        public abstract string GetRaceName();
        public abstract string GetSize();
        public abstract int GetSpeed();
        public abstract int GetStrengthAdjustment();
        public abstract int GetDexterityAdjustment();
        public abstract int GetConstitutionAdjustment();
        public abstract int GetIntelligenceAdjustment();
        public abstract int GetWisdomAdjustment();
        public abstract int GetCharismaAdjustment();
    }
}
