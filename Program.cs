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
            game.CreatePlayer();
            var playing = true;
            string userChoice = "";


            while (playing)
            {

                System.Console.WriteLine("Type 'n' or 'North' to continue. You can always type 'h' or 'Help' or 'l' for 'Look' for a better view");

                userChoice = game.GetUserResponse();
                PlayerChoice(userChoice);



                //player moves to second room



                System.Console.WriteLine("Type 'l' or 'Look' for a better view of the room your in");

                System.Console.WriteLine("Type 't' or 'Take' to pick up this beautiful sparkling magic wand");

                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");

                // player moves to third room

                // Console.WriteLine(game.CurrentRoom.Description);

                System.Console.WriteLine("Type 'n' or 'North' to continue journey or Type 's' or 'South' to retrace your steps ");

                // player moves to fourth final room

                // Console.WriteLine(game.CurrentRoom.Description);

                System.Console.WriteLine("Type 's' or 'South' to run from the orb you have found glowing in front of you!!! ");

                System.Console.WriteLine("Or Type 'u' or 'Use' to use item in Inventory");




                bool Valid = false;
                while (!Valid)
                {
                    Console.WriteLine("Do you want to try again? YES/NO");
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


                }
            }

            void PlayerChoice(string x)
            {

                switch (x)
                {
                    case "n":
                    case "North":
                        game.Move("north");
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "s":
                    case "south":
                        game.Move("south");
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "t":
                    case "Take":
                        game.Take("wand");
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "h":
                    case "Help":
                        game.Help();
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "i":
                    case "Inventory":
                        game.ShowInventory();
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "l":
                    case "Look":
                        game.Look();
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    case "u":
                    case "Use":
                        game.UseItem("wand");
                        userChoice = game.GetUserResponse();
                        PlayerChoice(userChoice);
                        break;

                    default:
                        System.Console.WriteLine("Direction not reconized");
                        break;
                }
            }
        }

    }
}

