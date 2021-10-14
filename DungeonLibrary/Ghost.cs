using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Ghost : Monster
    {

        #region Fields for Ghost

        //Fields

        #endregion

        #region Properties for Ghost

        //Properties
        public int BonusBlock { get; set; }
        public int HidePercent { get; set; }

        #endregion

        #region Constructors for Ghost

        //Constuctors
        public Ghost()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Life = 6;
            MinDamage = 0;
            HitChance = 5;
            Block = 10;
            Name = "Slimer";
            Description = "It's a green slimey ghost, don't get slimed!";
            BonusBlock = 5;
            HidePercent = 10;

        }//END DEFAULT

        public Ghost(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, int bonusBlock, int hidePercent) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }//END FQ CTOR


        #endregion

        #region Methods for Ghost

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"{base.ToString()}\nChance it will hide in a wall: {HidePercent}\nBonus Block: {BonusBlock}";
        }//END TOSTRING()

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;

            Random rand = new Random();
            int percent = rand.Next(1, 101);

            if (percent <= HidePercent)
            {
                calculatedBlock += BonusBlock;
            }//END IF

            return calculatedBlock;
        }//END CalcBlock()

        #endregion

    }//END CLASS

}//END NAMESPACE
