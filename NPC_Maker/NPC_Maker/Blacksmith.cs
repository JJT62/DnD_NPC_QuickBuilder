using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Maker
{
    enum CraftsmanshipGrades
    {
        //6 Levels
        S, A, B, C, D, F
    }

    enum Specializations
    {
        //4 Specializations
        Armor, Tools, Weapons, All
    }

    class Blacksmith : Merchant
    {
        public Specializations Specialization;
        public string specializationType;
        public CraftsmanshipGrades CraftsmanshipGrade;
        public string lvlOfCraftsmanship;
        public bool upgradeExisting;

    }
}
