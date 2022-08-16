using System;

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
            List list1 = new List();
            list1.Add(56);
            list1.Add(30);
            list1.Add(70);
            list1.Display();
            Console.WriteLine("\nAfter Inserting Element...");
            list.InserAtParticularPosition(3, 40);
            list.Display();
            Console.WriteLine("\nPosition of 30--> " + list.findPoistion(30));
            
            Console.ReadLine();
        }
    }
} 
