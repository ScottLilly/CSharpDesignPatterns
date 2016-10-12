using System.Collections.Generic;

namespace Engine.PrototypePattern.PatternVersion_Complex
{
    public class Monster
    {
        public string Name { get; private set; }
        public int HitPoints { get; private set; }
        public List<LootTableEntry> LootTable { get; set;}

        // Public constructor, called to create the prototype Monster object.
        public Monster(string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;

            // In this part, pretend we are populating LootTable using a database query.
            LootTable = new List<LootTableEntry>();

            LootTable.Add(new LootTableEntry { ItemID = 1, DropPercentage = 10 });
            LootTable.Add(new LootTableEntry { ItemID = 2, DropPercentage = 5 });
            LootTable.Add(new LootTableEntry { ItemID = 5, DropPercentage = 1 });
            LootTable.Add(new LootTableEntry { ItemID = 12, DropPercentage = 50 });
            LootTable.Add(new LootTableEntry { ItemID = 27, DropPercentage = 33 });
            LootTable.Add(new LootTableEntry { ItemID = 42, DropPercentage = 100 });
        }

        // Private contructor called by Clone method.
        // Does not need to connect to the database to populate the LootTable property.
        private Monster(string name, int hitPoints, List<LootTableEntry> lootTable)
        {
            Name = name;
            HitPoints = hitPoints;
            LootTable = lootTable;
        }

        public void ApplyDamage(int amountOfDamage)
        {
            HitPoints -= amountOfDamage;
        }

        public Monster Clone()
        {
            // This version of Clone calls the private constructor,
            // to prevent re-running the database query to populate LootTable.
            return new Monster(Name, HitPoints, LootTable);
        }
    }
}
