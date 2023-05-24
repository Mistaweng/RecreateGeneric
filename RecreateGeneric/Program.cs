namespace RecreateGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
             SinglyLinkedList<int> LinkedList = new SinglyLinkedList<int>();
            LinkedList.AddToTail(11);
            LinkedList.AddToTail(21);
            LinkedList.AddToTail(23);
            LinkedList.AddToTail(40);

            Console.WriteLine(LinkedList.CheckValue(3));


            LinkedList.PrintNode();
            LinkedList.RemoveFirstOccurance(3);
            LinkedList.PrintNode();

            StackLinkedList<int> stacklist = new StackLinkedList<int>();
            stacklist.Push(4);
            stacklist.Push(3);
            stacklist.Push(2);
            stacklist.Push(1);
            stacklist.PrintNode();
            stacklist.Pop();
            Console.WriteLine (stacklist.Size());
            Console.WriteLine(stacklist.Peek());
            stacklist.PrintNode();

            QueueLinkedList<string> queuelist = new QueueLinkedList<string>();
            queuelist.Enqueue("James");
            queuelist.Enqueue("Michael");
            queuelist.Enqueue("Ubong");
            queuelist.Enqueue("Tobechukwu");
            queuelist.PrintNode();
            queuelist.Dequeue();

            Console.WriteLine(queuelist.IsEmpty());
            Console.WriteLine(queuelist.Size);
            Console.WriteLine();
            queuelist.PrintNode();
        }

       
    }
}