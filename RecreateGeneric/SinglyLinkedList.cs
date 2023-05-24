using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecreateGeneric
{
    public class SinglyLinkedList<T>
    {
        // Properties:To find out the first and last item in the Linkedlist
        public NodeClass<T> FirstItem { get; set; }

        public NodeClass<T> LastItem { get; set; }

        public int Count { get; set; }

        //Constructor

        public SinglyLinkedList() 
        {
            this.FirstItem = null;
            this.LastItem = null;
        }


        public T GetFirstItem(T FirstItem)
        {
            return FirstItem;
        }

        //Method to Add item to the last (tail)
        public void AddToTail(T data)
        {
            if (FirstItem == null)
            {
                FirstItem = new NodeClass<T>(data);
                return;
            }
            NodeClass<T> current = FirstItem;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new NodeClass<T>(data);

        }

        //Method to remove item from the list
        public bool RemoveFirstOccurance(T value)
        {
            NodeClass<T> current = FirstItem;
            NodeClass<T> temp = null;
            while (current.Next != null)
            {
                if (value.Equals(current.Data))
                {
                    temp.Next = current.Next;
                    return true;
                }
                else
                {
                    temp = current;
                    current = current.Next;
                }

            }
            return false;
        }


        //Method to check the items in a list
        public bool CheckValue(T value)
        {
            NodeClass<T> current = FirstItem;
            while (current != null)
            {
                if (value.Equals(current.Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        //Method to find the index of an item in the list
        public int Index(T value)
        {
            NodeClass<T> current = FirstItem;
            int count = 0;
            while (current != null)
            {
                if (value.Equals(current.Data))
                {
                    return count;
                }
                current = current.Next;
                count++;
            }
            return count;
        }

        //Method to print the item(s) in the Linkedlist on the Console
        public void PrintNode()
        {
            NodeClass<T> current = FirstItem;
            while (current != null)
            {
                Console.WriteLine("value of a Node is {0}", current.Data);
                current = current.Next;
            }
        }
    }   
    
}
