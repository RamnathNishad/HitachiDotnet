namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); //LIFO

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);


            Console.WriteLine(stack.Peek()); //does not remove
            Console.WriteLine(stack.Pop());



            int len =stack.Count;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            //Console.WriteLine(stack.Pop());

            Console.WriteLine("\n");

            Queue<string> queue = new Queue<string>(); //FIFO
            queue.Enqueue("ravi");
            queue.Enqueue("rahul");
            queue.Enqueue("raman");
            queue.Enqueue("ramit");
            queue.Enqueue("rakesh");


            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
