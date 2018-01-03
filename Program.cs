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

                string decision = game.GetUserResponse();

                void PlayerChoice(string decision)
                {

                    switch (decision)
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
                }

                System.Console.WriteLine("You have just entered a haunted Gold Mine!!! You hear a ghostly voice call out 'What is your name?'");

                string UserName = Console.ReadLine();

                Player NewGuy = new Player(UserName, "Empty Leather Bag");

                System.Console.WriteLine($"{UserName}! Welcome! Your only chance of leaving this haunted mine alive is to head 'North' into the caves ahead. What would you like to do?");

                Console.WriteLine(game.CurrentRoom.Description);

                System.Console.WriteLine("Type 'n' or 'North' to continue");
                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");
                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");
                System.Console.WriteLine("Type 't' or 'Take' to pick up this beautiful sparkling magic wand");
                System.Console.WriteLine("Type 'u' or 'Use' to use item in Inventory");


                Console.WriteLine(game.CurrentRoom.Description);






                // bool Valid = false;
                // while (!Valid)
                // {
                //     Console.WriteLine("Do you want to try again? Y/N");
                //     string PlayAgain = Console.ReadLine().ToLower();
                //     if (PlayAgain == "n" || PlayAgain == "no")
                //     {
                //         playing = false;
                //         Valid = true;
                //     }
                //     else if (PlayAgain == "y" || PlayAgain == "yes")
                //     {
                //         Valid = true;
                //     }

                // var command = choice[0];
                // var option = choice[1]; //if or a try catch        





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

