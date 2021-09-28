using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace JVDungeonApp
{
    class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.Title = "-=== ADVENTURE TOWER GAME ===-";

            
            int score = 0;            

            Weapon dagger = new Weapon(1, 4, "Dagger", 0, false, 2);

            Weapon club = new Weapon(1, 4, "Club", 0, false, 1);

            Weapon shortBow = new Weapon(1, 6, "Short Bow", 1, true, 25);

            Weapon handAxe = new Weapon(1, 6, "Hand Axe", 1, false, 5);

            Weapon[] weapons = { dagger, club, shortBow, handAxe };

            Random rand = new Random();

            Weapon weapon = weapons[rand.Next(weapons.Length)];

            Item healing = new Item(0, 0, "Potion of Healing", 0, false, 10, "A vial holding magical red fluid", 4);
           
            Console.WriteLine("Welcome to the Adventure Tower Game");

            bool exit = false; //EXIT THE GAME VARIABLE
            Console.WriteLine($"You find yourself walking down a dark desert highway, cool wind in your hair.\nThe warm smell of colitas, rising up through the air. \nUp ahead in the distance, You see a shimmering light. Your head grows heavy and your eyesight dims. \nYou have to stop for the night. \n\nA woman stands in the doorway, you hear a mission bell ring,\nas you think to yourself \"This could be Heavan or This could be Hell\"...It begins:\n ");

            Console.WriteLine("Press 'ANY KEY' to begin");

            Console.ReadLine();
            Console.Clear();
            do
            {
                #region Starting Menu                
                
                Console.WriteLine("Player equpped with {0}.\n\n", weapon);
                
                Console.WriteLine("1.) Inquire on the Vacancy of the hotel");
                Console.WriteLine("2.) Continue on past the doorway");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                Console.Clear();
                switch (userChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("As you walk up to the woman she fades back into the doorway and disappears from sight.\n\nYou enter the hotel and see {0}\n\n", GetRoom());
                        
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("You continue walking down the dark desert highway. The darkness swallows you\nYou are forever lost and eventually fogotten by the timeline. THE END");
                        exit = true;
                        break;                   
                    default:
                        Console.WriteLine("ERROR 400 - INVALID INPUT PLEASE INPUT A EITHER 1 OR 2. TRY AGAIN");
                        Console.ReadKey();                        
                        break;
                }//END SWITCH                  
                #endregion
                //bool reload = false;
                //do
                //{

                //} while (!exit && !reload);//END ACTION DOWHILE
            } while (!exit);//END MAIN DOWHILE

        }//END MAIN

        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine...Oh No! the DMV!",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?"
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }//END GETROOM()

    }//END CLASS

}//END NAMESPACE
