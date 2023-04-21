using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    internal class Queues
    {
       public Node front;
       public Node rear;
        public void Enqeue(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = rear;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }

        }
        public void Displya()
        {
            if (front == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
