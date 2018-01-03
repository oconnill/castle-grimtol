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
            //create player
            var playing = true;
            string userChoice = "";


            while (playing)
            {



                System.Console.WriteLine("You have just entered a haunted Gold Mine!!! You hear a ghostly voice call out 'What is your name?'");

                string UserName = Console.ReadLine();

                Player NewGuy = new Player(UserName, "Empty Leather Bag");

                System.Console.WriteLine($"{UserName}! Welcome! Your only chance of leaving this haunted mine alive is to head 'North' into the caves ahead. What would you like to do?");


                System.Console.WriteLine("Type 'n' or 'North' to continue. You can always type 'h' or 'Help' or 'l' for 'Look' for a better view");

                userChoice = game.GetUserResponse();
                PlayerChoice(userChoice);



                //player moves to second room



                System.Console.WriteLine("Type 'l' or 'Look' for a better view of the room your in");

                System.Console.WriteLine("Type 't' or 'Take' to pick up this beautiful sparkling magic wand");

                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");

                // player moves to third room

                Console.WriteLine(game.CurrentRoom.Description);

                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");

                // player moves to fourth final room

                Console.WriteLine(game.CurrentRoom.Description);

                System.Console.WriteLine("Type 's' or 'South' to run from the orb you have found glowing in front of you!!! ");

                System.Console.WriteLine("Or Type 'u' or 'Use' to use item in Inventory");




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





                    Console.WriteLine(game.CurrentRoom.Description);








                    // var command = choice[0];
                    // var option = choice[1]; //if or a try catch        




                    // Use a second if statement instead of switch

                    // if (command == "q")
                    // {
                    //     playing = false;
                    //     continue;
                    // }
                    // if (command == "n")
                    // {
                    //     game.Move("north");
                    //     continue;
                    // }
                    // if (command == "s")
                    // {
                    //     game.Move("south");
                    //     continue;
                    // }
                    // Console.Clear();




                }
            }

            void PlayerChoice(string x)
            {

                switch (x)
                {
                    case "n":
                    case "North":
                        game.Move("north");
                        break;

                    case "s":
                    case "south":
                        game.Move("south");
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

                    case "l":
                    case "Look":
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
        }

    }
}

