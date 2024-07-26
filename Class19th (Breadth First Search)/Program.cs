namespace Class19th__Breadth_First_Search_
{
    public class Graph
    {
        private int size;
        private Queue<int> queue;
        private List<int>[] graph;
        private bool[] visited;

        public Graph()
        {
            size = 8;
            queue = new Queue<int>();
            visited = new bool[size];
            graph = new List<int>[size];

            for (int i = 0; i < size; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void Insert(int vertex, int edge)
        {
            graph[vertex].Add(edge);
            graph[edge].Add(vertex);
        }

        public void Search(int start)
        {
            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int temp = queue.Dequeue();

                Console.Write(temp + " ");

                for (int i = 0; i < graph[temp].Count; i++)
                {
                    int next = graph[temp][i];

                    if (visited[next] != true)
                    {
                        queue.Enqueue(next);

                        visited[next] = true;
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
            #region 너비 우선 탐색 (BFS)
            // 시작 정점을 방문한 후 시작 정점의 인접한 모든 정점들을 우선 방문하는 방법이다.

            // 더 이상 방문하지 않은 정점이 없을 때까지 방문하지 않은 모든 정점들에 대해서도 너비 우선 탐색을 적용한다.

            Graph graph = new Graph();

            graph.Insert(1, 2);
            graph.Insert(1, 3);

            graph.Insert(2, 3);
            graph.Insert(2, 4);
            graph.Insert(2, 5);

            graph.Insert(3, 6);
            graph.Insert(3, 7);

            graph.Insert(4, 5);
            graph.Insert(6, 7);

            // graph.Show();

            graph.Search(1);
            #endregion
        }
    }
}