﻿using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedList***");
            List list = new List();
            list.Add(56);
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAfter Inserting Element...");
            list.InserAtParticularPosition(2, 30);
            list.Display();
            
            Console.WriteLine("\nAfter Deleting First Node");
            list.RemoveFirstNode();
            list.Display();
            Console.ReadLine();
        }
    }
} 
