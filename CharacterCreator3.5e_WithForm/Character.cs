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
        
        private void AssignAbilityScoresPointBuy()
        {
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
            int points = 25;

            for (int i = 0; i < abilityScores.Length; i++)
            {
                int check = points;

                //Prompt for score and assign, show remaining points
                Console.WriteLine("Score/Cost\n8 = 0, 9 = 1, 10 = 2, 11 = 3, 12 = 4, 13 = 5\n14 = 6, 15 = 8, 16 = 10, 17 = 13, 18 = 16");
                Console.Write("Enter " + abilityScores[i].Name + " score (8-18)\nPoints: " + points + "\nD&D3.5e>> ");
                abilityScores[i].Val = Convert.ToInt32(Console.ReadLine());
                
                //check if score is in range
                if (abilityScores[i].Val < 8 || abilityScores[i].Val > 18)
                {
                    //error message
                    //deincriment so same abilityScore is prompted
                    Console.WriteLine("Cannot enter value lower than 8 or greater than 18 using point buy.");
                    i--;
                }
                else
                {
                    /* If ability score is less than 15, calculate new point value using formula
                     * else use case statement
                     */ 
                    if (abilityScores[i].Val < 15)
                    {
                        check -= abilityScores[i].Val - 8;
                    }
                    else
                    {
                        switch (abilityScores[i].Val)
                        {
                            case 15:
                                check -= 8;
                                break;
                            case 16:
                                check -= 10;
                                break;
                            case 17:
                                check -= 13;
                                break;
                            case 18:
                                check -= 16;
                                break;
                        }
                    }

                    /* if point check is less than 0 deincriment and reprompt abilityScore
                     * else continue to next abilityScore with new remaining point value*/ 
                    if (check < 0)
                    {
                        Console.WriteLine("Point buy cannot go below 0. Enter a lower score.");
                        i--;
                    }
                    else
                    {
                        points = check;
                    }
                }             
            }
        }
        public int RollAbilityScore()
        {
            //rolls 4d6, adds them, then subtracts the lowest roll
            int[] results = new int[4];
            int result = 0;
            for (int i = 0; i < results.Length; i++) results[i] = D6();
            for (int i = 0; i < results.Length; i++) result += results[i];
            result -= results.Min();
            return result;
        }

        public void Print()
        {
            /*
            Console.WriteLine("Character Sheet\n");
            Console.WriteLine("Name:\t" + name);
            for (int i = 0; i < abilityScores.Length; i++)
            {
                if (abilityScores[i].Val > 10)
                {
                    if (abilityScores[i].Name == "Wisdom")
                        Console.WriteLine(abilityScores[i].Name + ":\t\t+" + abilityScores[i].Mod + "\t= " + abilityScores[i].Val);
                    else
                        Console.WriteLine(abilityScores[i].Name + ":\t+" + abilityScores[i].Mod + "\t= " + abilityScores[i].Val);
                }
                else 
                {
                    if (abilityScores[i].Name == "Wisdom")
                        Console.WriteLine(abilityScores[i].Name + ":\t\t" + abilityScores[i].Mod + "\t= " + abilityScores[i].Val);
                    else
                        Console.WriteLine(abilityScores[i].Name + ":\t" + abilityScores[i].Mod + "\t= " + abilityScores[i].Val);
                }
            }
            */
        }
        private int D6()
        {
            Random d = new Random();
            int result = d.Next(0, 6) + 1;
            return result;
        }
    }
}
