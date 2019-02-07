using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0; 

        }

        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public Object Add(int index, object o)
        {
            if (index < 0){
                throw new ArgumentOutOfRangeException("");
            }

            if (index > count)
            {
                index = count;
            }

            Node current = this.head;
            // this insertion happens before a node at a particular index.
            if (this.Empty || index==0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(o, current.Next);
            }

            count++;

            return o;
        } 

        //Add at the end of the list 

        public object Add(object o)
        {
            return this.Add(count,o);
        }
    }
}
