using System;
using System.Collections.Generic;

namespace maze_bfs
{
    class Program
    {
        const int n = 20;
        static Random r = new Random();
        static int[,] maze = new int[n, n];
        static int[] parent = new int[n * n];
        static Queue<int> q = new Queue<int>();
        static void Main(string[] args)
        {
            
            while (parent[n*n-1] == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int value = r.Next(2);
                        maze[i, j] = value;
                    }
                }
                // конец генерации лабиринта

                if (maze[0, 0] == 1)
                {
                    for (int i = 0; i < n*n; parent[i++] = 0) { }
                    q.Clear();
                    q.Enqueue(0); // номер элемента = i * n + j
                    Check();
                }
            }
            MakeWay();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (maze[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(1 + "  ");
                    }
                    else
                    {
                        if (maze[i, j] == 2)
                        {
                            Console.Write(1 + "  ");
                        }
                        else
                        {
                            Console.Write(maze[i, j] + "  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Check() 
        {
            int u; int i; int j;
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                i = u / n;
                j = u % n;
                maze[i, j] = 2;

                if ((i == n-1) && (j == n-1)) { return; }
                if (i > 0) { 
                    if (maze[i - 1, j] == 1) { 
                        q.Enqueue(u - n);
                        parent[u - n] = u;
                    }
                }
                if (i < n-1) {
                    if (maze[i + 1, j] == 1) { 
                        q.Enqueue(u + n);
                        parent[u + n] = u;
                    }
                }
                if (j > 0) {
                    if (maze[i, j - 1] == 1) { 
                        q.Enqueue(u - 1);
                        parent[u - 1] = u;
                    }
                }
                if (j < n - 1)
                {
                    if (maze[i, j + 1] == 1)
                    {
                        q.Enqueue(u + 1);
                        parent[u + 1] = u;
                    }
                }
            }
        }
        static void MakeWay()
        {
            maze[0, 0] = 3;
            int i = n*n-1;
            while (i != 0)
            {
                maze[i / n, i % n] = 3;
                i = parent[i];
            }
        }
    }
}
