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
            list1.InserAtParticularPosition(3, 40);
            list1.Display();
            Console.WriteLine("\nPosition of 30--> " + list1.findPoistion(30));
            list1.deleteNode(40);
            Console.WriteLine("After Deleting Node");
            list1.Display();
            Console.WriteLine("Linkelist Size " + list1.count());
            List list2 = new List();
            list2.SortedList(56);
            list2.SortedList(30);
            list2.SortedList(70);
            list2.SortedList(40);
            Console.Write("Sorted List is :");
            list2.Display();
            Console.ReadLine();
        }
    }
} 
