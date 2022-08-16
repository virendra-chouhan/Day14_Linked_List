using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class List
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        internal Node InserAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invlid position...");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range...");
            }
            return head;
        }

        // Displays this instance.
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty.");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        public int findPoistion(int value)
        {
            int position = 0;
            while (this.head != null)
            {
                position++;
                if (this.head.data == value)
                {
                    return position;
                }
                this.head = this.head.next;
            }
            return position;
        }
        public void deleteNode(int value)
        {

            // Store head node 
            Node temp = head, prev = null;

            if (temp != null && temp.data == value)
            {
                // Changed head 
                head = temp.next;
                return;
            }

            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public int count()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public void SortedList(int data)
        {
            Node newNode = new Node(data);
            Node Current;
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Current = head;
                while (Current.next != null && Current.next.data < newNode.data)
                    Current = Current.next;

                newNode.next = Current.next;
                Current.next = newNode;
            }
        }
    }
}
