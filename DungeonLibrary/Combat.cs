using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    class Combat
    {
        //This class will not have any fields/props/ctors, as it is just a "warehouse" for our combat functionality.

        #region Methods for Combat

        //Methods
        public static void DoAttack(Character attacker, Character defender)
        {

            //Get a random number from 1 - 100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(100);

            //Then we will compare the dice roll against the Attacker's hitChance - defender's calcBlock(). If the dice roll is lower than that algorithm, the attacker will hit for damage.
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calc the damage
                int damageDealt = attacker.CalcDamage();
                //Assign the damage
                defender.Life -= damageDealt;
                //Write the result to the screen
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
            //The Player attacks first
            DoAttack(player, monster);

            //If the monster is still alive, they get an attack on the player
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//END IF
        }//END DOBATTLE()

        #endregion

    }//END CLASS

}//END NAMESPACE

