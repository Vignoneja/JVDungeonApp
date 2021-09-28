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
        public int Cost { get; set; }
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
        }//END INT MIN DAMAGE

        #endregion

        #region Constructors for Weapon

        //Constuctors
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, int cost)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Cost = cost;
        }//END FQCTOR

        #endregion

        #region Methods for Weapon

        //Methods
        public override string ToString()
        {
            return string.Format($"{Name}\t{MinDamage} to {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}%\t{(IsTwoHanded ? "Two-Handed" : "One-Handed")}");
        }//END TOSTRING()

        #endregion


    }//END CLASS

}//END NAMESPACE
