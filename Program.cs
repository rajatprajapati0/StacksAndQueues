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
            stacks.Display();

            Console.WriteLine("\n"+stacks.top.data);
            //
            

        }
    }
}
