using System;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues");
            Stacks stacks = new Stacks();
            Queues queue = new Queues();
            queue.Enqeue(56);
            queue.Enqeue(30);
            queue.Enqeue(70);
            Console.WriteLine("stored data in Qeue");
            queue.Displya();

            Console.WriteLine("\n"+queue.front.data+"<-top data in qeueu");
            queue.Deqeue();
            Console.WriteLine("remaing stored data in Qeueue after deqeue");
            queue.Displya();

            Console.WriteLine("\n" + queue.front.data + "<-top data in qeue after deqeue");

            //stacks.Push(70);
            //stacks.Push(30);
            //stacks.Push(56);
            //Console.Write("peek ->");
            //stacks.Peek();
            //Console.WriteLine("\n");
            //Console.WriteLine("Stored data in stack");
            //stacks.Display();
            //Console.WriteLine("\n"+stacks.top.data+" <-top data");
            //stacks.Pop();

            //Console.WriteLine("Stored data in stack after pop");
            //stacks.Display();
            //Console.WriteLine("\n" + stacks.top.data + "<-top data after pop");


        }
    }
}
