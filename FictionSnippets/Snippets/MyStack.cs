using System.Collections;
namespace FictionSnippets.Snippets
{
    public class MyStack
    {
        Queue q1 = new Queue();
        Queue q2 = new Queue();
        public void Push(int valX)
        {
            if (q1.Count <= 0)
            {
                q1.Enqueue(valX);
            }
            else
            {
                q2.Enqueue(valX);
                while (q1.Count > 0)
                {
                    q2.Enqueue(q1.Peek());
                    q1.Dequeue();
                }
                Queue q = q1;
                q1 = q2;
                q2 = q;
            }

        }
        public void Pop()
        {
            if (q1.Count > 0)
                q1.Dequeue();
        }
        public int Top()
        {
            if (q1.Count <= 0)
                return -1;
            return (int)q1.Peek();
        }
        public int Size()
        {
            if (q1.Count <= 0)
                return 0;
            return q1.Count;
        }

    }
}