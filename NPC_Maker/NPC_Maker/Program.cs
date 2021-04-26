using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Maker
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome and select npc type
            Console.WriteLine("Welcome to the NPC Quick Creation Tool:");
            Console.WriteLine("What type of NPC to make?");
            Console.WriteLine("1: Hireling");
            Console.WriteLine("2: Barkeeper (Merchant)");
            Console.WriteLine("3: Blacksmith (Merchant)");

            //Get user input
            string input = Console.ReadLine();
            Console.WriteLine();
            int npcType = 0;
            if (!Int32.TryParse(input, out npcType))
            {
                Console.WriteLine("Error with input");
            }

            //select type based on input
            if (npcType == 1)
            {
                Hireling hire = new Hireling();

                Console.WriteLine("Select Gender or Randomize?");
                Console.WriteLine("Enter 'M' or 'F' to manually add, leave blank to randomize");
                string genderInput = Console.ReadLine();
                Console.WriteLine();
                char npcGender;
                if (char.TryParse(genderInput, out npcGender))
                {
                    if (npcGender == 'M' || npcGender == 'm')
                    {
                        hire.Gender = GenderList.M;
                    }
                    else if (npcGender == 'F' || npcGender == 'f')
                    {
                        hire.Gender = GenderList.F;
                    }
                    else
                    {
                        hire.Gender = GenderList.Other;
                    }
                }
                else
                {
                    Random random = new Random();
                    var n = random.Next(0, 3);
                    hire.Gender = (GenderList)(n);
                }

                Console.WriteLine("Select Name or Randomize?");
                Console.WriteLine("Enter Name to manually add, leave blank to randomize");
                string nameInput = Console.ReadLine();
                if (nameInput == "")
                {
                    if (hire.Gender == GenderList.M)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 272);
                        hire.MName = (MaleNames)(n);
                        hire.Name = hire.MName.ToString();
                    }
                    else if (hire.Gender == GenderList.F)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 154);
                        hire.FName = (FemaleNames)(n);
                        hire.Name = hire.FName.ToString();
                    }
                    else
                    {
                        Random random = new Random();
                        var n = random.Next(0, 362);
                        hire.OName = (OtherNames)(n);
                        hire.Name = hire.OName.ToString();
                    }
                }
                else
                {
                    hire.Name = nameInput;
                }

                Console.WriteLine("Select Stats or Randomize?");
                Console.WriteLine("Type 'Y' for Manual, anything else for Random");
                string i = Console.ReadLine();
                if (i == "Y" || i == "y")
                {
                    Console.Write("Set Strength: ");
                    hire.Strength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Set Dexterity: ");
                    hire.Dexterity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Set Constitution: ");
                    hire.Constitution = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Set Intelligence: ");
                    hire.Intelligence = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Set Wisdom: ");
                    hire.Wisdom = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Set Charisma: ");
                    hire.Charisma = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                else
                {
                    Random random = new Random();
                    var n = random.Next(8, 21);
                    hire.Strength = n;
                    n = random.Next(8, 21);
                    hire.Dexterity = n;
                    n = random.Next(8, 21);
                    hire.Constitution = n;
                    n = random.Next(8, 21);
                    hire.Intelligence = n;
                    n = random.Next(8, 21);
                    hire.Wisdom = n;
                    n = random.Next(8, 21);
                    hire.Charisma = n;
                }

                Console.WriteLine("Select Class or Randomize?");
                Console.WriteLine("Enter Class to manually add, leave blank to randomize");
                string classInput = Console.ReadLine();
                if (classInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 14);
                    hire.DnDClass = (DnDClasses)(n);
                    hire.dndClass = hire.DnDClass.ToString();
                }
                else
                {
                    hire.dndClass = classInput;
                }

                Console.WriteLine("Select Skill Level Grade or Randomize?");
                Console.WriteLine("Enter Grade to manually add, leave blank to randomize");
                string gradeInput = Console.ReadLine();
                if (gradeInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 7);
                    hire.SkillLevel = (SkillLevels)(n);
                    hire.skillLvl = hire.SkillLevel.ToString();
                }
                else
                {
                    hire.skillLvl = gradeInput;
                }

                Console.WriteLine("Select Weapon or Randomize?");
                Console.WriteLine("Enter Weapon to manually add, leave blank to randomize");
                string weaponInput = Console.ReadLine();
                if (weaponInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 37);
                    hire.Weapon = (Weapons)(n);
                    hire.weapon = hire.Weapon.ToString();
                }
                else
                {
                    hire.weapon = weaponInput;
                }

                Console.WriteLine("Successfully Created Hireling");
                Console.WriteLine("Name: {0}", hire.Name);
                Console.WriteLine("Gender: {0}", hire.Gender);
                Console.WriteLine("Str: {0}, Dex: {1}, Con: {2}, Int: {3}, Wis: {4}, Cha: {5}", hire.Strength, hire.Dexterity, hire.Constitution, hire.Intelligence, hire.Wisdom, hire.Charisma);
                Console.WriteLine("Class: {0}", hire.dndClass);
                Console.WriteLine("Skill Grade: {0}", hire.skillLvl);
                Console.WriteLine("Weapon: {0}", hire.weapon);

            }



            else if (npcType == 2)
            {
                Barkeeper bar = new Barkeeper();

                Console.WriteLine("Select Gender or Randomize?");
                Console.WriteLine("Enter 'M' or 'F' to manually add, leave blank to randomize");
                string genderInput = Console.ReadLine();
                Console.WriteLine();
                char npcGender;
                if (char.TryParse(genderInput, out npcGender))
                {
                    if (npcGender == 'M' || npcGender == 'm')
                    {
                        bar.Gender = GenderList.M;
                    }
                    else if (npcGender == 'F' || npcGender == 'f')
                    {
                        bar.Gender = GenderList.F;
                    }
                    else
                    {
                        bar.Gender = GenderList.Other;
                    }
                }
                else
                {
                    Random random = new Random();
                    var n = random.Next(0, 3);
                    bar.Gender = (GenderList)(n);
                }

                Console.WriteLine("Select Name or Randomize?");
                Console.WriteLine("Enter Name to manually add, leave blank to randomize");
                string nameInput = Console.ReadLine();
                if (nameInput == "")
                {
                    if (bar.Gender == GenderList.M)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 272);
                        bar.MName = (MaleNames)(n);
                        bar.Name = bar.MName.ToString();
                    }
                    else if (bar.Gender == GenderList.F)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 154);
                        bar.FName = (FemaleNames)(n);
                        bar.Name = bar.FName.ToString();
                    }
                    else
                    {
                        Random random = new Random();
                        var n = random.Next(0, 362);
                        bar.OName = (OtherNames)(n);
                        bar.Name = bar.OName.ToString();
                    }
                }
                else
                {
                    bar.Name = nameInput;
                }

                Console.WriteLine("Select How Much Coin {0} has or Randomize?", bar.Name);
                Console.WriteLine("Enter Coin Value to manually add, leave blank to randomize");
                string coinInput = Console.ReadLine();
                if (coinInput == "")
                {
                    int decimalPlace1;
                    int decimalPlace2;
                    int goldCoins;
                    float coinVal;
                    Random random = new Random();
                    var n = random.Next(10, 1000);
                    goldCoins = n;
                    n = random.Next(0, 10);
                    decimalPlace1 = n;
                    n = random.Next(0, 10);
                    decimalPlace2 = n;

                    coinVal = goldCoins + ((float)decimalPlace1 / 10) + ((float)decimalPlace2 / 100);

                    bar.Coin = coinVal;

                }
                else
                {
                    bar.Coin = (float) Convert.ToDouble(coinInput);
                }

                Console.WriteLine("Select Quality Grade or Randomize?");
                Console.WriteLine("Enter Grade to manually add, leave blank to randomize");
                string gradeInput = Console.ReadLine();
                if (gradeInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 7);
                    bar.QualityGrade = (QualityGrades)(n);
                    bar.Quality = bar.QualityGrade.ToString();
                }
                else
                {
                    bar.Quality = gradeInput;
                }

                Console.WriteLine("Select Menu Type or Randomize?");
                Console.WriteLine("Enter Menu Type to manually add, leave blank to randomize");
                string menuInput = Console.ReadLine();
                if (menuInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 9);
                    bar.MenuType = (MenuTypes)(n);
                    bar.Menu = bar.MenuType.ToString();
                }
                else
                {
                    bar.Menu = menuInput;
                }

                Console.WriteLine("Successfully Created Barkeeper");
                Console.WriteLine("Name: {0}", bar.Name);
                Console.WriteLine("Gender: {0}", bar.Gender);
                Console.WriteLine("Coin: {0}", bar.Coin);
                Console.WriteLine("Menu Type: {0}", bar.Menu);
                Console.WriteLine("Quality Grade: {0}", bar.Quality);

            }
            else if (npcType == 3)
            {
                Blacksmith black = new Blacksmith();

                Console.WriteLine("Select Gender or Randomize?");
                Console.WriteLine("Enter 'M' or 'F' to manually add, leave blank to randomize");
                string genderInput = Console.ReadLine();
                Console.WriteLine();
                char npcGender;
                if (char.TryParse(genderInput, out npcGender))
                {
                    if (npcGender == 'M' || npcGender == 'm')
                    {
                        black.Gender = GenderList.M;
                    }
                    else if (npcGender == 'F' || npcGender == 'f')
                    {
                        black.Gender = GenderList.F;
                    }
                    else
                    {
                        black.Gender = GenderList.Other;
                    }
                }
                else
                {
                    Random random = new Random();
                    var n = random.Next(0, 3);
                    black.Gender = (GenderList)(n);
                }

                Console.WriteLine("Select Name or Randomize?");
                Console.WriteLine("Enter Name to manually add, leave blank to randomize");
                string nameInput = Console.ReadLine();
                if (nameInput == "")
                {
                    if (black.Gender == GenderList.M)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 272);
                        black.MName = (MaleNames)(n);
                        black.Name = black.MName.ToString();
                    }
                    else if (black.Gender == GenderList.F)
                    {
                        Random random = new Random();
                        var n = random.Next(0, 154);
                        black.FName = (FemaleNames)(n);
                        black.Name = black.FName.ToString();
                    }
                    else
                    {
                        Random random = new Random();
                        var n = random.Next(0, 362);
                        black.OName = (OtherNames)(n);
                        black.Name = black.OName.ToString();
                    }
                }
                else
                {
                    black.Name = nameInput;
                }

                Console.WriteLine("Select How Much Coin {0} has or Randomize?", black.Name);
                Console.WriteLine("Enter Coin Value to manually add, leave blank to randomize");
                string coinInput = Console.ReadLine();
                if (coinInput == "")
                {
                    int decimalPlace1;
                    int decimalPlace2;
                    int goldCoins;
                    float coinVal;
                    Random random = new Random();
                    var n = random.Next(10, 1000);
                    goldCoins = n;
                    n = random.Next(0, 10);
                    decimalPlace1 = n;
                    n = random.Next(0, 10);
                    decimalPlace2 = n;

                    coinVal = goldCoins + ((float)decimalPlace1 / 10) + ((float)decimalPlace2 / 100);

                    black.Coin = coinVal;

                }
                else
                {
                    black.Coin = (float)Convert.ToDouble(coinInput);
                }

                Console.WriteLine("Select Quality Grade or Randomize?");
                Console.WriteLine("Enter Grade to manually add, leave blank to randomize");
                string gradeInput = Console.ReadLine();
                if (gradeInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 7);
                    black.CraftsmanshipGrade = (CraftsmanshipGrades)(n);
                    black.lvlOfCraftsmanship = black.CraftsmanshipGrade.ToString();
                }
                else
                {
                    black.lvlOfCraftsmanship = gradeInput;
                }



                Console.WriteLine("Select Smithing Specialization or Randomize?");
                Console.WriteLine("Enter Specialization to manually add, leave blank to randomize");
                string specInput = Console.ReadLine();
                if (specInput == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 5);
                    black.Specialization = (Specializations)(n);
                    black.specializationType = black.Specialization.ToString();
                }
                else
                {
                    black.specializationType = specInput;
                }


                Console.WriteLine("Do they upgrade already made equiptment or only make new?");
                Console.WriteLine("enter 'Y' for yes, anything else for no, or blank for randomly selected");
                string i = Console.ReadLine();
                if (i == "Y" || i == "y")
                {
                    black.upgradeExisting = true;
                }
                else if (i == "")
                {
                    Random random = new Random();
                    var n = random.Next(0, 2);

                    black.upgradeExisting = (n == 1);
                }
                else
                {
                    black.upgradeExisting = false;
                }

                Console.WriteLine("Successfully Created Blacksmith");
                Console.WriteLine("Name: {0}", black.Name);
                Console.WriteLine("Gender: {0}", black.Gender);
                Console.WriteLine("Coin: {0}", black.Coin);
                Console.WriteLine("Specialization: {0}", black.specializationType);
                Console.WriteLine("Upgrades Existing Gear: {0}", black.upgradeExisting);
                Console.WriteLine("Craftsmanship Grade: {0}", black.lvlOfCraftsmanship);


            }
            else
            {
                Console.WriteLine("Cannot Find NPC type match. Exiting program.");
            }

            //Exit the Program
            Console.WriteLine();
            Console.WriteLine("Thank you for using the program. Press 'ENTER' to exit");
            Console.ReadLine();
        }

    }
}
