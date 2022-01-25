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
        public FictionTestmain()
        {
            fact = new Factorial();
            qsort = new QuickSort();
            stack = new MyStack();
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

    }
}
