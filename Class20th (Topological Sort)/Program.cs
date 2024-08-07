﻿namespace Class20th__Topological_Sort_
{
    public class Graph
    {
        private int size;
        private int[] inDegree;
        private Queue<int> queue;
        private List<int>[] graph;

        public Graph()
        {
            size = 8;
            inDegree = new int[size];
            queue = new Queue<int>();
            graph = new List<int>[size];

            for (int i = 0; i < size; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void Insert(int vertex, int edge)
        {
            graph[vertex].Add(edge);

            inDegree[edge]++;
        }

        public void Sort()
        {
            for (int i = 1; i < size; i++)
            {
                if (inDegree[i] <= 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                int temp = queue.Dequeue();

                Console.Write(temp + " ");

                for (int i = 0; i < graph[temp].Count; i++)
                {
                    int next = graph[temp][i];

                    inDegree[next]--;

                    if (inDegree[next] == 0) // queue.Contains(next) == false
                    {
                        queue.Enqueue(next);
                    }
                }
            }
        }

        public void Show()
        {
            for (int i = 1; i < graph.Length; i++)
            {
                Console.Write("[" + i + "]");
                for (int j = 0; j < graph[i].Count; j++)
                {
                    Console.Write(" -> " + graph[i][j]);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 위상 정렬
            // 방향 그래프에 존재하는 각 정점들의 선행 순서를 지키며, 모든 정점을 차례대로 진행하는 알고리즘이다.
            // 사이클이 발생하는 경우 위상 정렬을 수행할 수 없다.

            // DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프

            // 시간 복잡도 : O(V + E)

            // 위상 정렬하는 방법
            // 1. 진입 차수가 0인 정점을 Queue에 삽입한다.
            // 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거한다.
            // 3. 간선 제거 이후에 진입 차수가 0이 된 정점을 Queue에 삽입한다.
            // 4. Queue가 비어있을 떄까지 2번 ~ 3번을 반복 수행한다.

            Graph graph = new Graph();

            graph.Insert(1, 2);
            graph.Insert(1, 5);
            graph.Insert(2, 3);
            graph.Insert(3, 4);
            graph.Insert(4, 7);
            graph.Insert(5, 6);
            graph.Insert(6, 4);

            // graph.Show();

            graph.Sort();
            #endregion
        }
    }
}