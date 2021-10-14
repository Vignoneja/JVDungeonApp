using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {

        #region Fields for Character

        //Fields
        private int _life;

        #endregion

        #region Properties for Character

        //Properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {

                if (value <= MaxLife)
                {

                    _life = value;
                }//END IF
                else
                {
                    _life = MaxLife;
                }//END ELSE
            }//END SET
        }//END INT LIFE

        #endregion

        #region Constructors for Character

        //Constuctors        

        #endregion

        #region Methods for Character

        //Methods        

        public virtual int CalcBlock()
        {

            return Block;
        }//END CALCBLOCK()

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//END CALCHITCHANCE()

        public virtual int CalcDamage()
        {
            return 0;
        }//END CALCDAMAGE()

        #endregion

    }//END CLASS

}//END NAMESPACE
