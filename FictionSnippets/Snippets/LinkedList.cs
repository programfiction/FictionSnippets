using System.Collections.Generic;

namespace FictionSnippets.Snippets
{
    public class LinkedList
    {
        private int data;
        private LinkedList next;
        public LinkedList()
        {
            data = 0;
            next = null;
        }
        public LinkedList(int valx)
        {
            data = valx;
            next = null;
        }

        public LinkedList InsertNext(int valx)
        {
            LinkedList node = new LinkedList(valx);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                LinkedList temp = this.next;
                node.next = temp;
                this.next = node.next;
            }

            return node;

        }
        public int DeleteNext(int valx)
        {
            if (next == null)
            {
                return 0;
            }
            LinkedList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }
        public List<int> Traverse(LinkedList node)
        {
            List<int> myList= new List<int>();
            if(node==null)
            {
                node=this;
            }
            while (node!=null)
            {
               myList.Add(node.data);
                node= node.next;
            }

            return myList;
        }
    }
}