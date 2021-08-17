using System;
using FictionSnippets.Interfaces;

namespace FictionSnippets.Snippets
{
    public class ShortestPathAlgo : IShortestpath
    {
        static int V = 9;

        public int FindMinimumDistance(int[] dist, bool[] shortestPathSet)
        {
            int
                min = int.MaxValue,
                min_index = -1;

            for (int v = 0; v < V; v++)
            if (shortestPathSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }

            return min_index;
        }

        public void PrintShortestPath(int[] dist, int n, int destination)
        {
            Console.Write("Vertex     Distance " + "from Source\n");
            for (int i = 0; i < V; i++)
            if (i == destination) Console.Write(i + " \t\t " + dist[i] + "\n");
        }

        public void FindShortestPathWithDijkstra()
        {
            int src = 0; //Source vertice
            int destination = 8; //destination vertice  to find distance
            int[,] graph =
                new int[,] {
                    { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                    { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
                };

            int[] dist = new int[V];

            bool[] shortestPathSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                shortestPathSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = FindMinimumDistance(dist, shortestPathSet);
                shortestPathSet[u] = true;
                for (int v = 0; v < V; v++)
                if (
                    !shortestPathSet[v] &&
                    graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v]
                ) dist[v] = dist[u] + graph[u, v];
            }
            PrintShortestPath (dist, V, destination);
        }
    }
}
