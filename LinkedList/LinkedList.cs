using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node<T>
        {
            public Node(T value)
            {
                Value = value;
            }

            public Node<T> NextNode { get; set; }
            public T Value { get; }
        }

        private Node<T> head;

        public T MiddleElement()
        {
            if (head == null)
            {
                return default(T);
            }

            var element = head;
            var middleElement = head;

            var isNextElementEven = false;
            while (element.NextNode != null)
            {
                element = element.NextNode;
                if (isNextElementEven)
                {
                    middleElement = middleElement.NextNode;
                }

                isNextElementEven = !isNextElementEven;
            }
            return middleElement.Value;
        }

        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                return;
            }

            var lastElement = head;
            while(lastElement.NextNode != null)
            {
                lastElement = lastElement.NextNode;
            }
            lastElement.NextNode = new Node<T>(value);
        }
    }
}
