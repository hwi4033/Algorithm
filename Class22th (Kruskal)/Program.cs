namespace Class22th__Kruskal_
{
    public class Graph
    {
        public class Edge : IComparable<Edge>
        {
            private int x;
            private int y;
            private int distance;

            public int X
            {
                get { return x; }
            }

            public int Y
            {
                get { return y; }
            }

            public int Distance
            {
                get { return distance; }
            }

            public int CompareTo(Edge? other)
            {
                return Distance.CompareTo(other.Distance);
            }

            public Edge(int x, int y, int distance)
            {
                this.x = x;
                this.y = y;
                this.distance = distance;
            }
        }

        private int sum;
        private int size;
        private int[] parent;
        private List<Edge> graph;

        public Graph()
        {
            sum = 0;
            size = 8;
            parent = new int[size];
            graph = new List<Edge>();

            for (int i = 1; i < size; i++)
            {
                parent[i] = i;
            }
        }

        public void Insert(int x, int y, int distance)
        {
            graph.Add(new Edge(x, y, distance));
        }

        public void Kruskal()
        {
            graph.Sort();

            for (int i = 0; i < graph.Count; i++)
            {
                if (Same(graph[i].X, graph[i].Y) != true)
                {
                    sum += graph[i].Distance;

                    Union(graph[i].X, graph[i].Y);
                }
            }

            Console.WriteLine(sum);
        }

        public void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (Same(x, y) == true)
            {
                return;
            }
            else
            {
                if (x > y)
                {
                    parent[x] = y;
                }
                else
                {
                    parent[y] = x;
                }
            }
        }

        public int Find(int i)
        {
            if (parent[i] != i)
            {
                return Find(parent[i]);
            }
            else
            {
                return parent[i];
            }
        }

        public bool Same(int x, int y)
        {
            return Find(x) == Find(y);
        }

        public void Show()
        {
            for (int i = 1; i < graph.Count; i++)
            {
                Console.WriteLine(graph[i].X + " " + graph[i].Y + " " + graph[i].Distance);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 신장 트리
            // 그래프의 모든 정점을 포함하면서 사이클이 존재하지 않는 그래프로, 그래프의 모든 정점을 최소 비용으로 연결하는 트리이다.

            // 그래프의 정점의 수가 n개일 때, 간선의 수는 n-1개이다.

            Graph graph = new Graph();

            graph.Insert(1, 2, 73);
            graph.Insert(1, 4, 28);
            graph.Insert(1, 5, 17);
            graph.Insert(1, 7, 12);

            graph.Insert(2, 4, 24);
            graph.Insert(2, 5, 62);

            graph.Insert(3, 5, 20);
            graph.Insert(3, 6, 35);

            graph.Insert(4, 7, 13);

            graph.Insert(5, 6, 40);

            graph.Kruskal();

            // 최소 비용 신장 트리
            // 그래프의 간선들의 가중치 합이 최소인 신장 트리이다.
            #endregion
        }
    }
}