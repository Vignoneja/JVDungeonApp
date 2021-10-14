using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Animal : Monster
    {

        #region Fields for Animal

        //Fields

        #endregion

        #region Properties for Animal

        public bool IsFluffy { get; set; }

        //Properties

        #endregion

        #region Constructors for Animal

        //Constuctors
        public Animal(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFluffy) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsFluffy = isFluffy;
        }//END FQ CTOR

        public Animal()
        {

            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cute little bunny. Why would you want to hurt it?!";
            IsFluffy = false;
        }//END DEFAULT ANIMAL CTOR

        #endregion

        #region Methods for Animal

        //Methods
        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy...");
        }//END TOSTRING()

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }//END IF
            return calculatedBlock;
        }//END CALCBLOCK()

        #endregion

    }//END CLASS

}//END NAMESPACE
