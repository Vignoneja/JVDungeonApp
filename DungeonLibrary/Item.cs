using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Item: Character
    {

        #region Fields

        //Fields
        private int _minPotion;

        #endregion

        #region Properties

        //Properties
        public int MaxPotion { get; set; }        
        public string Description { get; set; }
        public int MinPotion
        {
            get { return _minPotion; }
            set
            {
                if (value > 0 && value <= MaxLife)
                {
                    _minPotion = value;
                }//END IF
                else
                {
                    _minPotion = 1;
                }//END ELSE
            }//END SET
        }//END MINPOTION
        #endregion

        #region Constructors

        //Constuctors
        public Item(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded,int maxPotion, string description, int minPotion)
        {
            MaxPotion = maxPotion;
            Description = description;
            MinPotion = minPotion;
            
            }
        #endregion

        #region Methods

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Healing\n{3}",
                Name, MinPotion, MaxPotion, Description);
        }
        #endregion

    }//END CLASS

}//END NAMESPACE
