using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    internal class Stacks
    {
       public Node top;

        public  Stacks() 
        { 
          top=null; 
        }
        public void Push(int data) 
        {
            Node node= new Node(data);            
            node.next=top;
            top=node;        
        }
        public void Peek()
        {
            if (top == null) 
            {
                Console.WriteLine("Stack is empty");
            }
            else 
            {
                Console.WriteLine(top.data);
            }

        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node node = top;
                top = top.next;
            }
        }
        public void Display()
        {
            if (top==null)
            {
                Console.WriteLine("Stack is empty");
            }
            else 
            {
                Node temp=top;

                while (temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.next;
                }
            
            }
        }

    }
}
