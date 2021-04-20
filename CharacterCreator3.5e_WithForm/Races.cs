using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator3._5e_WithForm
{
    class Dwarf : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"Appraise +2: Stone & Metal", "Attack Roll +1: Gobliniods",
            "Attack Roll +1: Orcs & Half-orcs", "Craft +2: Stone & Metal", "Darkvision", 
            "Dodge Bonus +4: Giant type monsters", "Magic Resistance +2", "Poison Resistance +2", 
            "Stability", "Stonecunning", "Weapon Familiarity: Waraxes", "Weapon Familiarity: Urgoshes"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Fighter";
        }
        public override string GetRaceName()
        {
            return "Dwarf";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 20;
        }
        public override int GetStrengthAdjustment()
        {
            return 0;
        }
        public override int GetDexterityAdjustment()
        {
            return 0;
        }
        public override int GetConstitutionAdjustment()
        {
            return 2;
        }
        public override int GetIntelligenceAdjustment()
        {
            return 0;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return -2;
        }
        public Dwarf()
        {
            languages.Add("Common");
            languages.Add("Dwarven");
        }
    }
    class Elf : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"Immunity to magical sleep", "Listen +2", "Low-light Vision", "Search +2",
        "Spot +2", "Auto search: Hidden Doors", "Weapon Proficiency: Longbow", "Weapon Proficiency: Longsword", "Weapon Proficiency: Rapier",
        "Weapon Proficiency: Shortbow"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Wizard";
        }
        public override string GetRaceName()
        {
            return "Elf";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 30;
        }
        public override int GetStrengthAdjustment()
        {
            return 0;
        }
        public override int GetDexterityAdjustment()
        {
            return 2;
        }
        public override int GetConstitutionAdjustment()
        {
            return -2;
        }
        public override int GetIntelligenceAdjustment()
        {
            return 0;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return 0;
        }
        public Elf()
        {
            languages.Add("Common");
            languages.Add("Elven");
        }
    }
    class Gnome : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"Attack Roll +1: Gobliniods", "Attack Roll +1: Kobolds", "Craft +2: Alchemy",
            "Dodge Bonus +4: Giant type monsters", "Illusion Potency +1", "Illusion Resistance +2", 
            "Listen +2", "Low-light Vision", "Spell-like Ability: Dancing Lights 1/day",
            "Spell-like Ability: Ghost Sound 1/day", "Spell-like Ability: Prestidigitation 1/day",
            "Spell-like Ability: Speak with Animals 1/day", "Weapon Familiarity: Hooked Hammers"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Bard";
        }
        public override string GetRaceName()
        {
            return "Gnome";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 20;
        }
        public override int GetStrengthAdjustment()
        {
            return -2;
        }
        public override int GetDexterityAdjustment()
        {
            return 0;
        }
        public override int GetConstitutionAdjustment()
        {
            return 2;
        }
        public override int GetIntelligenceAdjustment()
        {
            return 0;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return 0;
        }
        public Gnome()
        {
            languages.Add("Common");
            languages.Add("Gnome");
        }
    }
    class Halfling : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"Attack Roll +1: Thrown Weapons & Slings", "Climb +2", "Jump +2",
            "Listen +2", "Move Silently +2", "Saving throws +1", "Fear Resistance +2"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Rogue";
        }
        public override string GetRaceName()
        {
            return "Halfing";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 20;
        }
        public override int GetStrengthAdjustment()
        {
            return -2;
        }
        public override int GetDexterityAdjustment()
        {
            return 2;
        }
        public override int GetConstitutionAdjustment()
        {
            return 0;
        }
        public override int GetIntelligenceAdjustment()
        {
            return 0;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return 0;
        }
        public Halfling()
        {
            languages.Add("Common");
            languages.Add("Halfling");
        }
    }
    class HalfElf : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"Diplomacy +2", "Elven Blood", "Gather Information +2",
            "Immunity to magical sleep", "Listen +1", "Low-light Vision", "Search +1", "Spot +1" };

        //Gets
        public override string GetFavoriteClass()
        {
            return "Any";
        }
        public override string GetRaceName()
        {
            return "Half-elf";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 30;
        }
        public override int GetStrengthAdjustment()
        {
            return 0;
        }
        public override int GetDexterityAdjustment()
        {
            return 0;
        }
        public override int GetConstitutionAdjustment()
        {
            return 0;
        }
        public override int GetIntelligenceAdjustment()
        {
            return 0;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return 0;
        }
        public HalfElf()
        {
            languages.Add("Common");
            languages.Add("Elven");
        }
    }
    class HalfOrc : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = { "Darkvision", "Orc Blood"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Barbarian";
        }
        public override string GetRaceName()
        {
            return "Half-Orc";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 30;
        }
        public override int GetStrengthAdjustment()
        {
            return 2;
        }
        public override int GetDexterityAdjustment()
        {
            return 0;
        }
        public override int GetConstitutionAdjustment()
        {
            return 0;
        }
        public override int GetIntelligenceAdjustment()
        {
            return -2;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return -2;
        }
        public HalfOrc()
        {
            languages.Add("Common");
            languages.Add("Orc");
        }
    }
    class Human : Race
    {
        private List<string> languages = new List<string>();
        private string[] traits = {"+1 feat at 1st level", "+4 skill points at 1st level", "+1 skill point per level"};

        //Gets
        public override string GetFavoriteClass()
        {
            return "Any";
        }
        public override string GetRaceName()
        {
            return "Human";
        }
        public override string GetSize()
        {
            return "Medium";
        }
        public override int GetSpeed()
        {
            return 30;
        }
        public override int GetStrengthAdjustment()
        {
            return 2;
        }
        public override int GetDexterityAdjustment()
        {
            return 0;
        }
        public override int GetConstitutionAdjustment()
        {
            return 0;
        }
        public override int GetIntelligenceAdjustment()
        {
            return -2;
        }
        public override int GetWisdomAdjustment()
        {
            return 0;
        }
        public override int GetCharismaAdjustment()
        {
            return -2;
        }
        public Human()
        {
            languages.Add("Common");
        }
    }
}
