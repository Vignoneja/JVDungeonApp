using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace JVDungeonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "-=== ADVENTURE TOWER GAME ===-";

            int score = 0;

            Random rand = new Random();

            #region Weapons

            Weapon sword = new Weapon(1, 8, "Long Sword", 10, true);

            Weapon dagger = new Weapon(1, 4, "Dagger", 0, false);

            Weapon club = new Weapon(1, 4, "Club", 0, false);

            Weapon shortBow = new Weapon(1, 6, "Short Bow", 1, true);

            Weapon handAxe = new Weapon(1, 6, "Hand Axe", 1, false);

            Weapon claws = new Weapon(1, 5, "Sharp Claws", 5, true);

            Weapon[] weapons = { sword, dagger, club, shortBow, handAxe };

            Weapon weapon = weapons[rand.Next(weapons.Length)];

            #endregion

            #region Players

            Player gary = new Player("Gary", 70, 5, 50, 40, Race.Human, weapon);

            Player rosita = new Player("Rosita", 70, 5, 50, 40, Race.Human, weapon);

            Player zorro = new Player("Zorro", 85, 10, 50, 45, Race.Human, sword);

            Player earl = new Player("Earl Sneed Sinclair", 75, 15, 55, 50, Race.DragonBorn, claws);

            Player velma = new Player("Velma", 70, 10, 50, 40, Race.Human, weapon);

            Player egon = new Player("Dr. Egon Spengler", 75, 10, 50, 40, Race.Halfling, weapon);

            Player[] players = { gary, rosita, zorro, earl, velma, egon };

            Player player = players[rand.Next(players.Length)];

            #endregion

            bool exit = false;

            Console.WriteLine($"You find yourself walking down a dark desert highway, cool wind in your hair.\nThe warm smell of colitas, rising up through the air. \nUp ahead in the distance, You see a shimmering light. Your head grows heavy and your eyesight dims. \nYou have to stop for the night. \n\nA woman stands in the doorway, you hear a mission bell ring...It begins:\n ");

            Console.WriteLine("Press 'ANY KEY' to begin");

            Console.ReadLine();
            Console.Clear();
            do
            {
                Console.WriteLine("1.) Inquire on the Vacancy of the hotel.");
                Console.WriteLine("2.) Continue on past the hotel down the dark road.");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                Console.Clear();
                switch (userChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("As you walk up to question the woman, she fades back into the doorway and disappears from your sight.\n\nYou follow her into the dark doorway...\n\n");

                        do
                        {
                            Console.WriteLine(GetRoom());

                            #region Monsters

                            Animal a1 = new Animal();

                            Animal a2 = new Animal("White Rabbit", 25, 25, 50, 20, 2, 8, "Thats no ordinary rabbit! Look at all these bones!", true);

                            Animal a3 = new Animal("Badger", 5, 5, 10, 5, 2, 3, "What a cute badger...Oh its attacking!", false);

                            Animal a4 = new Animal("Honey Badger", 15, 15, 20, 10, 3, 10, "it’s true that the honey badger has the Guinness Book of World Records title of World's Most Fearless Creature and now you're about to fight one!", true);

                            Vampire v1 = new Vampire("The Count", 40, 40, 40, 15, 2, 12, "Jinkies! it's a Vampire!");

                            Ghost g1 = new Ghost();

                            Ghost g2 = new Ghost("Slimer", 30, 30, 65, 40, 3, 15, "This ghost pops out of a little box on the floor and licks you on the face, laughs and disappears through the wall, where is he going to attack from next?!", 10, 25);
                            Ghost g3 = new Ghost("Wraith", 67, 67, 40, 40, 6, 21, "A wraith is Malice incarnate, concentrated into an incorporeal form that seeks to quench all life.", 3, 10);

                            Monster[] monsters = { a1, a2, a3, a4, v1, g1, g2, g3 };

                            Monster monster = monsters[rand.Next(monsters.Length)];

                            #endregion

                            Console.WriteLine("\nIn this room: " + monster.Name);

                            bool reload = false;

                            do
                            {
                                #region MENU
                                Console.Write("\nPlease choose an action:\n" +
                                    "A) Attack\n" +
                                    "R) Run Away\n" +
                                    "P) Player Info\n" +
                                    "M) Monster Info\n" +
                                    "X) Exit\n");

                                ConsoleKey userMenuChoice = Console.ReadKey(true).Key;

                                Console.Clear();

                                switch (userMenuChoice)
                                {
                                    case ConsoleKey.A:
                                        Console.WriteLine("Attack");

                                        Combat.DoBattle(player, monster);

                                        if (monster.Life <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                            Console.ResetColor();
                                            reload = true;
                                            score++;
                                        }//END IF
                                        break;//END ATTACK

                                    case ConsoleKey.R:
                                        Console.WriteLine("Run Away");
                                        Console.WriteLine($"{monster.Name} Attacks you as you turn to flee!");
                                        Console.WriteLine();
                                        Combat.DoAttack(monster, player);
                                        Console.WriteLine();
                                        reload = true;
                                        break;//END RUNAWAY
                                    case ConsoleKey.P:
                                        Console.WriteLine("Player Info");
                                        Console.WriteLine(player);
                                        Console.WriteLine("Monsters Defeated: " + score);
                                        break;//END PLAYER INFO
                                    case ConsoleKey.M:
                                        Console.WriteLine("The Monster's Info");
                                        Console.WriteLine(monster);
                                        break;//END MONSTERINFO
                                    case ConsoleKey.X:
                                    case ConsoleKey.E:
                                        Console.WriteLine("Goodbye");
                                        exit = true;
                                        break;//END EXIT
                                    default:
                                        Console.WriteLine("You walk into a wall. Try another input.");
                                        break;//END INVALID INPUT
                                }//END SWITCH
                                #endregion

                                if (player.Life <= 0)
                                {
                                    Console.WriteLine("You have no life left to live. The End");
                                    exit = true;
                                }
                            } while (!exit && !reload);

                        } while (!exit);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("You continue walking down the dark desert highway. The darkness swallows you\nYou are forever lost and eventually fogotten by the timeline. THE END");
                        exit = true;
                        break;

                    #region Epic Super Dangeous Important Code That Possibly Most Definately Could Break the Simulation
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        Console.WriteLine("A beam of light shines down onto you.\n\n You gaze up and see a white cylindrical alien spaceship hovering about 1,000ft above you. It appears to be in the process of opening its cargo hull door.\n\n");
                        Console.WriteLine("Did you have a towel on you? Y/N");
                        ConsoleKey easterEgg = Console.ReadKey(true).Key;
                        switch (easterEgg)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("\n\nYou wave your towel up at the UFO while sticking out your right thumb. They land gracefully in the desert across the road from you and flash their lights for your to enter. Saving you from this horrible simulation.\n After a few minutes the ship is zooming up and out of the atmosphere. You look out of the port window, and see that the flat planet you were just on disappears into the darkness of space. \n\n-=========You've escaped the game, CONGRATULATIONS! THE END=========-");
                                exit = true;
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("A cow wearing a cowboy hat is pushed out of the ships doorway and lands squarely onto your head. \n\nTHE END");
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("ERROR 400 - INVALID INPUT PLEASE INPUT : Y OR N. TRY AGAIN");
                                Console.ReadKey();
                                break;
                        }//END EASTEREGG
                        #endregion                        

                        break;
                    default:
                        Console.WriteLine("ERROR 400 - INVALID INPUT PLEASE INPUT : 1 OR 2. TRY AGAIN");
                        Console.ReadKey();
                        break;
                }//END SWITCH

            } while (!exit);//END MAIN DOWHILE

        }//END MAIN

        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.",
                "You enter a grand crypt for a noble, high priest, or other important individual.",
                "You arrive in a kitchen that bears a disturbing resemblance to a torture chamber in an evil temple.",
                "You enter a quiet library... silence... nothing but silence...",
                "As you enter the room, you realize its an antechamber for those that have come to pay respect to the dead or prepare themselves for burial rituals.",
                "Oh my.... what is that smell? You have entered a workshop for embalming the dead",
                "It's a candle lit divination room used to contact the dead for guidance.",
                "A torture chamber, used in inquisitions.",
                "The room looks just like the room you are sitting in right now..."
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }//END GETROOM()

    }//END CLASS

}//END NAMESPACE
