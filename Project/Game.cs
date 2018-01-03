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

            if (itemName == "wand")
            {
                System.Console.WriteLine($"{CurrentRoom.Name} starts to spin. The power of the wand starts working.");
            }
            else
            {
                System.Console.WriteLine($"This object has no effect");
            }
        }

        public void Take()
        {
            for (var i = 0; i < CurrentRoom.Items.Count; i++)
            {
                if (CurrentRoom.Items[i].Name == "wand")
                {
                    CurrentPlayer.Inventory.Add(CurrentRoom.Items[i]);
                    CurrentRoom.Items.Remove(CurrentRoom.Items[i]);

                }


            }
        }
        public void Setup()
        {
            Rooms = new List<Room>();

            Room Room1 = new Room("Room 1", "This is a new Room");

            Room Room2 = new Room("Room 2", "This is a new Room 2");

            Room Room3 = new Room("Room 3", "This is a new Room 3");

            // Items = new List<Item>();
            // Exits = new Dictionary<string, Room>();


            Room1.Exits.Add("north", Room2);
            Room2.Exits.Add("north", Room3);
            Room2.Exits.Add("south", Room1);
            Room3.Exits.Add("south", Room2);
            Room3.Exits.Add("north", Room3);
            CurrentRoom = Room1;

            Item Wand = new Item("Magic Wand", "Heavy and Magical!");

            Room2.Items.Add(Wand);
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

        public void ShowInventory()
        {
            for (var i = 0; i < CurrentPlayer.Inventory.Count; i++)
            {
                if (CurrentPlayer.Inventory[i] == null)
                {
                    Console.WriteLine("Your bag is empty");
                }
                else
                {
                    System.Console.WriteLine($"{CurrentPlayer.Inventory[i].Name}");
                }
            }
        }

        public void Look()
        {
            System.Console.WriteLine($"{CurrentRoom.Name}");
            System.Console.WriteLine($"{CurrentRoom.Description}");

        }
        public void Help()
        {
            System.Console.WriteLine("Do you need some Help!");
            System.Console.WriteLine("-To move from cavern to carvern type 'n' for 'North or 's' for South");
            System.Console.WriteLine("-Typing 'i' will display your 'Inventory' contents");
            System.Console.WriteLine("-Typing 't' will 'Take' any items found along your journey");
            System.Console.WriteLine("-Typing 'u' to use your Items within your inventory");
            System.Console.WriteLine("-Typing 'l' lets you take a more detailed 'Look' at your surroundings");
        }

        public void Reset()
        {
            Setup();
        }



        //No need to Pass a room since Items can only be used in the CurrentRoom


    }
}