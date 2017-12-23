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


while(playing){
System.Console.WriteLine("Welcome to the rooms of whatever!!! What is your name?");

System.Console.WriteLine("{user name} ?  {user name} is your name? Hmm we will just call you {generated name}");

"Game Play: To move in a direction type 'Go <direction of choice'"
"Directions: north, south, east, west"
"'Take' to pickup any item you find along your journey"
"'Use' to use any item in your inventory"
"'Inventory' will the contents of your inventory"
"'Look' will give you a discription of the current room you occupy"
"Room1 Description Here"
"Room2 Description Here"
"Room3 Description Here"
"Bridge Description Here"
"Room3 Description Here"
"You find a bottle of hard liquor. How many seconds would like to drink for? Between 1 or 9 seconds!"

 int x = 0;
//
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




Console.WriteLine(game.CurrentRoom.Description);
var choice = game.GetUserInput().Split(' ');
var command = choice[0];
var option = choice[1]; //if or a try catch

switch(command){
case "go"
switch (option) 
{
    case "n":
    case "North":
    game.Move("north");
    break;
    case "s":
    case "South":
    game.Move("South");
    break;
    default:
    System.Console.WriteLine("Direction not reconized");
    break;
}


if(command == "q")
{
    playing = false;
    continue;
}
if(choice == "n")
{
    game.Move("north");
    continue;
}
if(choice == "s")
{
    game.Move("south");
    continue;
}
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
