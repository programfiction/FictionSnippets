using System;
using FictionSnippets.Snippets;

namespace FictionSnippets
{
    class ProgramFiction
    {
        protected ProgramFiction()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello ProgramFiction");
            // ShortestPathAlgo myShortestPath = new ShortestPathAlgo();
            // myShortestPath.FindShortestPathWithDijkstra();

            QuickSort myObj= new QuickSort();
            var result =myObj.QSort(new int[]{2,1,3});
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
