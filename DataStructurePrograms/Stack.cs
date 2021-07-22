﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class Stack<T>
    {
        public Node<T> top;
        //Pushing elements into stack
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }
        //Popping top element
        public int pop()
        {
            if (top == null)
            {
                Console.WriteLine("Unbalanced");
                return 0;

            }
            else
            {
                top = top.Next;
                return 1;
            }
        }
        //Finding the top element
        public int Peek()
        {
            if (top == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
