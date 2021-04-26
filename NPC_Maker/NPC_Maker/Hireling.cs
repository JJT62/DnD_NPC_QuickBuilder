using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Maker
{
    enum DnDClasses
    {
        //13 classes
        Artificer, Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard
    }

    enum SkillLevels
    {
        //6 Levels
        S, A, B, C, D, F
    }

    enum Weapons
    {
        //36 Weapons
        Battleaxe, Blowgun, Boomerang, Club, Hand_Crossbow, Heavy_Crossbow, Light_Crossbow, Dagger, Dart, Flail, Glaive, Greataxe, Greatclub, Halberd, Handaxe, Javelin, Lance, Light_Hammer, Longbow, Longsword, Mace, Maul, Morningstar, Pike, Quaterstaff, Rapier, Scimitar, Shortbow, Shortsword, Sickle, Spear, Trident, War_Pick, Warhammer, Whip, Yklwa
    }


    class Hireling : Base
    {
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public DnDClasses DnDClass;
        public SkillLevels SkillLevel;
        public Weapons Weapon;
        public string dndClass;
        public string skillLvl;
        public string weapon;


    }
}
