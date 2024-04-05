using System;
using System.Collections.Generic;

namespace ShoppingListApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping List Application!");

            // Create a list to store shopping items
            List<Item> shoppingList = new List<Item>();
            
            // User interaction loop
            while (true)
            {
                Console.WriteLine("\nPlease select the operation you want to perform:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. List Shopping Items");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();
                bool exit = false;
                switch (choice)
                {
                    case "1":
                        AddItem(shoppingList);
                        break;
                    case "2":
                        ListShoppingItems(shoppingList);
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (exit)
                {
                    break;
                }
            }
        }

        static void AddItem(List<Item> shoppingList)
        {
            Console.WriteLine("\nAdd Item");

            Console.Write("Enter the name of the item: ");
            string name = Console.ReadLine();


            Console.Write("Enter the price of the item: ");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid price. Please enter a number.");
                Console.Write("Enter the price of the item: ");
            }

            // Create the item and add it to the list
            Item newItem = new Item(name, price);
            shoppingList.Add(newItem);

            Console.WriteLine("Item added successfully!");
        }

        static void ListShoppingItems(List<Item> shoppingList)
        {
            Console.WriteLine("\nShopping Items:");

            if (shoppingList.Count == 0)
            {
                Console.WriteLine("Your shopping list is empty.");
            }
            else
            {
                foreach (var item in shoppingList)
                {
                    Console.WriteLine($"Item Name: {item.Name}, Price: {item.Price:C}");
                }
            }
        }
    }

    // Item class
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
