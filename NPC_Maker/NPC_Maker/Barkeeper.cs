using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Maker
{
    enum QualityGrades
    {
        //6 Levels
        S, A, B, C, D, F
    }

    enum MenuTypes
    {
        //8 Menu Types
        Seafood, Basic_Barfood, Meat_Focused, Vegan, Farm_Grown, Hunted_Game, Fine_Dining, Drinks_Only
    }

    class Barkeeper : Merchant
    {
        public MenuTypes MenuType;
        public string Menu;
        public QualityGrades QualityGrade;
        public string Quality;

    }
}
