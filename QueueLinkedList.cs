using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecreateGeneric
{
    internal class QueueLinkedList<T>
    {
        NodeClass<T> front, rear;
        public QueueLinkedList()
        {
            this.front = rear = null;
        }


        //Method to add a key to the Queue.
        public void Enqueue(T key)

        {
            // Create a new Node
            NodeClass<T> temp = new NodeClass<T>(key);

            // if Queue is empty, then the new node has both the front and rear pointer

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the end of the Queue and change rear pointer

            this.rear.Next = temp;
            this.rear = temp;

        }


        // Method to remove a key from Queue
        public void Dequeue()
        {
            // if queue is empty, return null
            if (this.front == null)
                return;

            //Store previous front node and move front one node ahead
            NodeClass<T> temp = this.front;
            this.front = this.front.Next;

            // if front becomes null then change rear also as null
            if (this.front == null)
                this.rear = null;
        }


        //Method to check if a queue is empty
        public bool IsEmpty()
        {
            return this.front == null;
        }


        //MEthod to show the number of items in a queue
        public int Size()
        {
            NodeClass<T> current = front;
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


        //Method to print the elements in the queue on a Console
        public void PrintNode()
        {
            NodeClass<T> current = front;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        
    }
}
