using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }

        public List<Room> Rooms { get; set; }
        public void UseItem(string itemName)
        {

        }
        public void Setup()
        {
            Rooms = new List<Room>();

            Room Room1 = new Room("Room 1", "This is a new Room");

            Room Room2 = new Room("Room 2", "This is a new Room 2");

            Room Room3 = new Room("Room 3", "This is a new Room 3");
                
                Items = new List<Item>();
                Exits = new Dictionary<string, Room>();
            

            Room1.Exits.Add("north", Room2);
            Room2.Exits.Add("north", Room3);
            Room3.Exits.Add("north", Room3);
            CurrentRoom = Room1;
        }

        public void Move(string direction)
        {
            //given a string direction... check if currentroom.exits contains a key

            if (CurrentRoom.Exits.ContainsKey(direction))
            {
                CurrentRoom = CurrentRoom.Exits[direction];
            }
            else
            {
                System.Console.WriteLine("Cant got this way!");
            }
        }


        public bool Playing = true;

        public string GetUserInput()
        {
            string input = Console.ReadLine().ToLower();
            return input;
        }

        // public void MakeItems();

        // public void Take(Item item);

        // public void MakeExits();

        void ShowInventory()
        {

        }

        void Look()
        {

        }
        void Help()
        {
            System.Console.WriteLine("Cant got this way!");
        }

        public void Reset()
        {
            Setup();
        }



        //No need to Pass a room since Items can only be used in the CurrentRoom


    }
}