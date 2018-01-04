using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }

        public List<Room> Rooms { get; set; }

        public void CreatePlayer()
        {
            System.Console.WriteLine("You have just entered a haunted Gold Mine!!! You hear a ghostly voice call out 'What is your name?'");
            string Username = Console.ReadLine();
            CurrentPlayer = new Player(Username, "Empty Leather Bag");
            System.Console.WriteLine($"{Username}! Welcome! Your only chance of leaving this haunted mine alive is to head 'North' into the caves ahead. What would you like to do?");
        }


        public void Setup()
        {



            Rooms = new List<Room>();

            Room Room1 = new Room()
            {
                Description = "Giant Cave filled with old mining artifacts to old to use. Towards the north you can see a small light flickering.",
                Name = "Cave of Lost Wealth",
                Exits = new Dictionary<string, Room>()
            };

            Room Room2 = new Room()
            {
                Description = "You duck you head as you enter this cave the staglagmites seem as though they could collapse at any moment. There seem to be strange object on floor. Would you like to 'Take' it? Type 't' or 'Take' to pick up this beautiful sparkling magic wand;",
                Name = "Cave of Sharp Stone",
                Exits = new Dictionary<string, Room>(),
                Items = new List<Item>()
            };

            Room Room3 = new Room()
            {
                Description = "Finally entering a room with a higher vaulted ceilling with a glowing orb on the wall.",
                Name = "Cave of Dreams",
                Exits = new Dictionary<string, Room>()
            };

            Room Room4 = new Room()
            {
                Description = "You wake up in your bed at home realizing it was all just the haunted gold mine, magic wand, glowing orb, dream you have been having the last couple nights. Would you like to go back to bed? Y/N ?",
                Name = "Man Cave",
                Exits = new Dictionary<string, Room>()
            };

            Room1.Exits.Add("north", Room2);
            Room2.Exits.Add("north", Room3);
            Room2.Exits.Add("south", Room1);
            Room3.Exits.Add("south", Room2);
            Room3.Exits.Add("north", Room4);
            Room4.Exits.Add("south", Room3);

            CurrentRoom = Room1;

            Item Wand = new Item("wand", "Heavy and Magical!");

            Room2.Items.Add(Wand);
        }

        public void UseItem(string itemName)
        {

            if (itemName == "wand" && CurrentRoom.Name == "Cave of Dreams")
            {
                System.Console.WriteLine($"{CurrentRoom.Name} starts to spin. The power of the wand starts working. The wand seems to be interacting with an other worldly power.");
            }
            else
            {
                System.Console.WriteLine("This object has no effect. In using the wand without the orb the darkness of the cave encloses you. Try Again!");
                Setup();
                
            }
        }

        public void Take(string itemName)
        {
            System.Console.WriteLine($"{CurrentRoom.Items}");
            for (var i = 0; i < CurrentRoom.Items.Count; i++)
            {
                if (CurrentRoom.Items[i].Name == itemName)
                {
                    CurrentPlayer.Inventory.Add(CurrentRoom.Items[i]);
                    CurrentRoom.Items.Remove(CurrentRoom.Items[i]);
                    System.Console.WriteLine("You add the wand to your leather bag!");

                }
                else
                {
                    System.Console.WriteLine("Nothing here to take!");
                }


            }
        }

        public void Move(string direction)
        {
            //given a string direction... check if currentroom.exits contains a key

            if (CurrentRoom.Exits.ContainsKey(direction))
            {
                CurrentRoom = CurrentRoom.Exits[direction];
                System.Console.WriteLine($"{CurrentRoom.Name}");
                System.Console.WriteLine($"{CurrentRoom.Description}");
                // System.Console.WriteLine($"{CurrentRoom.Exits}");
            }
            else
            {
                System.Console.WriteLine("Cant go this way!");
            }
        }


        public bool Playing = true;

        public string GetUserResponse()
        {
            string response = Console.ReadLine().ToLower();
            return response;
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
            System.Console.WriteLine($"{CurrentRoom.Exits}");

        }
        public void Help()
        {
            System.Console.WriteLine("Do you need some Help!");
            System.Console.WriteLine("-To move from cavern to carvern type 'n' for 'North or 's' for South");
            System.Console.WriteLine("-Typing 'i' will display your 'Inventory' contents");
            System.Console.WriteLine("-Typing 't' will 'Take' any items found along your journey");
            System.Console.WriteLine("-Typing 'u' to use your Items within your inventory");
            System.Console.WriteLine("-Typing 'l' lets you take a more detailed 'Look' at your surroundings");
            System.Console.WriteLine($"{CurrentRoom.Description}");
        }

        public void Reset()
        {
            Setup();
        }

    }
}