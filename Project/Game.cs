using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

public List<Room> Rooms { get; set; }
public void Setup()
{
    Rooms = new List<Room>();

    Room Room1 = new Room()
    {
        Name: "Room 1";
        Description = "This is a new Room";
        Iterms = new List<Item>();
        Exits = new Dictionary<string, Room>();
    }
   
    room1.Exits.Add("north", room2);
    CurrentRoom = room1;
}

 public void Move(string direction)
 {
     //given a string direction... check if currentroom.exits contains a key

     if(CurrentRoom.Exits.ContainsKey(direction))
     {
         CurrentRoom = CurrentRoom.Exits[direction];
     }else
     {
         System.Console.WriteLine("Cant got this way!");
     }
 }


        public bool Playing = true;

        public void MakeItems();

        public void Take(Item string);

        public void MakeExits();

        void ShowInventory();
        void Look();
        void Help();
        void Setup();
        void Reset();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);

    }
}