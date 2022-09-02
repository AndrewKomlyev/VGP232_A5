using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            Inventory newInventory = new Inventory(3);

            

            Item item1 = new Item("key", 1, ItemGroup.Key);
            Item item2 = new Item("medkit", 1, ItemGroup.Consumable);
            Item item3 = new Item("sword", 1, ItemGroup.Equipment);

            newInventory.AddItem(item1);
            newInventory.AddItem(item2);


            List<Item> newList = newInventory.ListAllItems();

            if(newList.Count==2)
            {
                Console.WriteLine("Done");
            }

            



            // TODO: Create an inventory
            // TODO: Add 2 items to the inventory
            // Verify the number of items in the inventory.
        }
    }
}
