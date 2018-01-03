using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var game = new Game();
            game.Setup();
            var playing = true;


            while (playing)
            {
                System.Console.WriteLine("You have just entered a haunted Gold Mine!!! You hear a ghostly voice call out 'What is your name?'");

                string UserName = Console.ReadLine().ToLower();

                Player NewGuy = new Player(UserName, "Magic Wand");

                System.Console.WriteLine($"{UserName}! Welcome! Your only chance of leaving this haunted mine is to traverse the caves ahead. What would you like to do?");

                Console.WriteLine(game.CurrentRoom.Description);

                bool Valid = false;
                while (!Valid)
                {
                    Console.WriteLine("Do you want to try again? Y/N");
                    string PlayAgain = Console.ReadLine().ToLower();
                    if (PlayAgain == "n" || PlayAgain == "no")
                    {
                        playing = false;
                        Valid = true;
                    }
                    else if (PlayAgain == "y" || PlayAgain == "yes")
                    {
                        Valid = true;
                    }



                    // "Game Play: To move in a direction type 'Go <direction of choice'"
                    // "Directions: north, south, east, west"
                    // "'Take' to pickup any item you find along your journey"
                    // "'Use' to use any item in your inventory"
                    // "'Inventory' will the contents of your inventory"
                    // "'Look' will give you a discription of the current room you occupy"
                    // "Room1 Description Here"
                    // "Room2 Description Here"
                    // "Room3 Description Here"
                    // "Bridge Description Here"
                    // "Room3 Description Here"
                    // "You find a bottle of hard liquor. How many seconds would like to drink for? Between 1 or 9 seconds!"

                    int x = 0;

                    if ((args.Length == 1) &&
                        (Int32.TryParse(args[0], out x) == true) &&
                        ((x >= 1) && (x <= 9)))
                    {
                        for (int i = 1; i <= x; i++)
                        {
                            Console.WriteLine("Beep number {0}.", i);
                            Console.Beep();
                        }
                    }
                    else
                        Console.WriteLine("Usage: Enter the number of times (between 1 and 9) to beep.");
                }





                var choice = game.GetUserInput();
                // var command = choice[0];
                // var option = choice[1]; //if or a try catch

                switch (choice)
                {
                    case "n":
                    case "North":
                        game.Move("north");
                        break;

                    case "s":
                    case "south":
                        game.Move("South");
                        break;

                    case "t":
                    case "Take":
                        game.Take();
                        break;

                    case "h":
                    case "Help":
                        game.Help();
                        break;

                    case "i":
                    case "Inventory":
                        game.ShowInventory();
                        break;

                    case "u":
                    case "Use":
                        game.UseItem("wand");
                        break;

                    default:
                        System.Console.WriteLine("Direction not reconized");
                        break;
                }


                // if(command == "q")
                // {
                //     playing = false;
                //     continue;
                // }
                // if(choice == "n")
                // {
                //     game.Move("north");
                //     continue;
                // }
                // if(choice == "s")
                // {
                //     game.Move("south");
                //     continue;
                // }
                // Console.Clear();

                //Game.type = 
                // Create Rooms
                // Create Room Items
                // Create Exits
                // Room = 1 Exits = east
                // Room = 2 Exits = east, west
                // Room = 3 Exits = east, west
                // Room = Bridge Exits = east, west
                // Room = 4 Exits = west
                //  


            }
        }
    }
}
