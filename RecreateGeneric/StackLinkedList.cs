using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecreateGeneric
{
    internal class StackLinkedList<T>
    {
            NodeClass<T> top;
            public StackLinkedList()
            {
                this.top = null;
            }
            public void Push(T item)
            {
                // the head of a stack has a top node and the tail has a bottom node 
                // Created a temp memory which stores a node value
                NodeClass<T> Temp = new NodeClass<T>(item);
                if (top == null)
                {
                    Temp.Next = null;
                }
                else
                {
                    Temp.Next = top;
                }
                top = Temp;
            }

            //Using a boolean function to check if the stack is empty or not
            public bool IsEmpty()
            {
                return top == null;
            }

            // Function to return the top element in a stack
            public T Peek()
            {
                //Checking if the stack is empty
                if (!IsEmpty())
                {
                    return top.Data;
                }
                else
                {
                    Console.WriteLine("Stack is Empty");
                    return default;
                }
            }

            // A function to pop element from the stack
            public void Pop() // pop removes element at the beginning
            {

                // check for stack underflow
                if (top == null)
                {
                    Console.WriteLine("\nStack UnderFlow");
                    return;
                }

                // update the top pointer to point to the next node
                top = top.Next;
                Console.WriteLine(top.Data);
            }

            // A function to check the size of the stack
            public int Size()
            {
                NodeClass<T> current = top;
                if (current == null)
                {
                    return 0;
                }
                int counter = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    counter++;
                }
                return counter;
            }

            //Method to print the items in the Stack on the Console
            public void PrintNode()
            {
                NodeClass<T> current = top;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
    }
}
