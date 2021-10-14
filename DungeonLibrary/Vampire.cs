using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {

        #region Fields for Vampire

        //Fields

        #endregion

        #region Properties for Vampire

        //Properties
        public DateTime HourChangeBack { get; set; }

        #endregion

        #region Constructors for Vampire

        //Constuctors
        public Vampire(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            HourChangeBack = DateTime.Now;


            if (HourChangeBack.Hour < 6 || 18 < HourChangeBack.Hour)
            {
                HitChance += 10;
                Block += 10;
                minDamage += 1;
                MaxDamage += 2;
            }//END IF
        }//END FQ CTOR

        #endregion

        #region Methods for Vampire

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"{base.ToString()}\n" +
                $"{(HourChangeBack.Hour < 6 || 18 < HourChangeBack.Hour ? "It looks strong and thirsty." : "It shrinks back from the daylight and cowers in the shadows...")}";
        }//END TOSTRING()

        #endregion

    }//END CLASS

}//END NAMESPACE
