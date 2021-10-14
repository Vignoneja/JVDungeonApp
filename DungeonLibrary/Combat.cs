using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {

        #region Methods for Combat

        //Methods
        public static void DoAttack(Character attacker, Character defender)
        {

            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(100);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }//END IF
            else
            {
                //Attacker Missed
                Console.WriteLine("{0} missed!", attacker.Name);
            }//END ELSE
        }//END DOATTACK()

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//END IF
        }//END DOBATTLE()

        #endregion

    }//END CLASS

}//END NAMESPACE
