using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {

        #region Fields for Monster

        //Fields
        private int _minDamage;


        #endregion

        #region Properties for Monster

        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }
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
        }//END MINDAMAGE

        #endregion

        #region Constructors for Monster

        //Constuctors
        public Monster()
        {

        }//CTOR
        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            MinDamage = minDamage;
            Block = block;
            Description = description;

        }//END FQ CTOR
        #endregion

        #region Methods for Monster

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("***** Monster ******\n" +
                "{0}\n" +
                "Life: {1} to {2}\n" +
                "Damage: {3} to {4}\n" +
                "Block: {5}\n" +
                "Description:\n{6}",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }//END TOSTRING()

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }//END CALCDAMAGE

        #endregion

    }//END CLASS

}//END NAMESPACE
