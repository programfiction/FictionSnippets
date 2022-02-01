using System.Collections;

namespace FictionSnippets.Snippets
{
    public class MyQueue
    {
        Stack s1 = new Stack();
        Stack s2 = new Stack();

        public void Enqueue(int valx)
        {
            if (s1.Count <= 0)
            {
                s1.Push(valx);
            }
            else
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Peek());
                }
                s2.Push(valx);
                s1=s2;
                s2=null;
            }
        }
        public void Dequeue()
        {
            s1.Pop();
        }
        public int Size()
        {
            return s1.Count;
        }
        public int Peek()
        {
            return (int)s1.Peek();
        }
    }
}