using System;
using Xunit;
using FictionSnippets.Snippets;

namespace FictionTest
{
    public class FictionTestmain
    {
        private Factorial fact;
        private QuickSort qsort;
        private MyStack stack;
        private MyQueue q;
        private LinkedList myll;
        public FictionTestmain()
        {
            fact = new Factorial();
            qsort = new QuickSort();
            stack = new MyStack();
            q = new MyQueue();
            myll= new LinkedList();
        }

        [Fact]
        public void FactorialTest()
        {
            var result = fact.FindFactorialWithRecursion(5);
            Assert.Equal(120, result);
        }
        [Fact]
        public void QuickSortTest()
        {
            var result = qsort.QSort(new int[] { 2, 1, 3 });
            Assert.Equal(new int[] { 1, 2, 3 }, result);
        }
        [Fact]
        public void StackTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            var result = stack.Top();
            Assert.Equal(1, result);
            Assert.Equal(1, stack.Size());

        }
        [Fact]
        public void QueueTest()
        {
            q.Enqueue(1);
            q.Enqueue(2);
            q.Dequeue();
            var result = q.Peek();
            Assert.Equal(2, result);
            Assert.Equal(1, q.Size());

        }
        [Fact]
        public void LinkedListTest()
        {
            myll.InsertNext(5);
            var result= myll.Traverse(myll);
            Assert.Equal(5, result[1]);

        }
    }
}
