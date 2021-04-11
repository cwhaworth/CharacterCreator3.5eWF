using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class Dwarf : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private string[] traits = {"Appraise +2: Stone & Metal", "Attack Roll +1: Gobliniods",
            "Attack Roll +1: Orcs & Half-orcs", "Craft +2: Stone & Metal", "Darkvision", 
            "Dodge Bonus +4: Giant type monsters", "Magic Resistance +2", "Poison Resistance +2", 
            "Stability", "Stonecunning", "Weapon Familiarity: Waraxes", "Weapon Familiarity: Urgoshes"};
        private int[] alignment = new int[2];

        private List<CharacterClass> classes = new List<CharacterClass>();
        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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

            languages.Add("Common");
            languages.Add("Dwarven");
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
    class Elf : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private string[] traits = {"Immunity to magical sleep", "Listen +2", "Low-light Vision", "Search +2",
        "Spot +2", "Auto search: Hidden Doors", "Weapon Proficiency: Longbow", "Weapon Proficiency: Longsword", "Weapon Proficiency: Rapier",
        "Weapon Proficiency: Shortbow"};
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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
        public Elf()
        {
            //101: index of human data row in table races
            CharacterData charData = new CharacterData();
            DataTable races = charData.GetRaces();
            DataRow race = races.Rows.Find(101);

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

            languages.Add("Common");
            languages.Add("Elven");
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

        private string[] traits = {"Attack Roll +1: Gobliniods", "Attack Roll +1: Kobolds", "Craft +2: Alchemy",
            "Dodge Bonus +4: Giant type monsters", "Illusion Potency +1", "Illusion Resistance +2", 
            "Listen +2", "Low-light Vision", "Spell-like Ability: Dancing Lights 1/day",
            "Spell-like Ability: Ghost Sound 1/day", "Spell-like Ability: Prestidigitation 1/day",
            "Spell-like Ability: Speak with Animals 1/day", "Weapon Familiarity: Hooked Hammers"};
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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

            languages.Add("Common");
            languages.Add("Gnome");
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
    class Halfling : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private string[] traits = {"Attack Roll +1: Thrown Weapons & Slings", "Climb +2", "Jump +2",
            "Listen +2", "Move Silently +2", "Saving throws +1", "Fear Resistance +2"};
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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
        public Halfling()
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

            languages.Add("Common");
            languages.Add("Halfling");
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
    class HalfElf : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private string[] traits = {"Diplomacy +2", "Elven Blood", "Gather Information +2",
            "Immunity to magical sleep", "Listen +1", "Low-light Vision", "Search +1", "Spot +1" };
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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
        public HalfElf()
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

            languages.Add("Common");
            languages.Add("Elven");
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
    class HalfOrc : Character
    {
        private Ability[] abilityScores = new Ability[6];
        private Attributes attributes = new Attributes();

        private string[] traits = { "Darkvision", "Orc Blood"};
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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
        public HalfOrc()
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

            languages.Add("Common");
            languages.Add("Orc");
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

        private string[] traits = {"+1 feat at 1st level", "+4 skill points at 1st level", "+1 skill point per level"};
        private int[] alignment = new int[2];

        private List<string> languages = new List<string>();
        private List<int> hitDice = new List<int>();

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

            languages.Add("Common");
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
