using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }

        public Dictionary<string, Room> Exits { get; set; }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;

        }

        void UseItem(Item item)
        {

        }

    }
}












