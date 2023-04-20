using System;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues");
            Stacks stacks = new Stacks();

            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            Console.Write("peek ->");
            stacks.Peek();
            Console.WriteLine("\n");
            Console.WriteLine("Stored data in stack");
            stacks.Display();
            Console.WriteLine("\n"+stacks.top.data+" <-top data");
            stacks.Pop();

            Console.WriteLine("Stored data in stack after pop");
            stacks.Display();
            Console.WriteLine("\n" + stacks.top.data + "<-top data after pop");


        }
    }
}
