using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {

        #region Fields for Weapon

        //Fields
        private int _minDamage;

        #endregion

        #region Properties for Weapon

        //Properties
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//END IF
                else
                {
                    _minDamage = 1;
                }//END ELSE
            }//END SET
        }//END INT MINDAMAGE

        #endregion

        #region Constructors for Weapon

        //Constuctors
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = IsTwoHanded;
        }//END FQ CTOR
        #endregion

        #region Methods for Weapon

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name, MinDamage, MaxDamage, BonusHitChance, IsTwoHanded ? "Two-Handed" : "One-Handed");
        }//END TOSTRING()

        #endregion

    }//END CLASS

}//END NAMESPACE
