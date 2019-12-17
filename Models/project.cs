using System;
using ToDoList.Models;
using System.Collections.Generic;


    class Project 
    {
        static void Main()
        {
            Item placeholderItem = new Item("fill out to do list");
            Console.WriteLine("Wecome To the To Do List");
            Console.WriteLine("Would tou like to add an item to yout list or view your list (Add/View)");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "Add":
                Console.WriteLine("Add Task");
                string task = Console.ReadLine();
                Item newItem1 = new Item(task);
                Console.WriteLine("Task:" + newItem1.Description + "has been added to list.");
                break;

                case "View":
                List<Item> result = Item.GetAll();
                foreach (Item thisItem in result)
                {
                    Console.WriteLine(thisItem.Description);
                }
                break;    
            }
        }
    }