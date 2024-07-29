namespace Class21th__Union_Find_
{
    public class Graph
    {
        private int size;
        private int[] parent;

        public Graph()
        {
            size = 7;
            parent = new int[size];

            for (int i = 1; i < size; i++)
            {
                parent[i] = i;
            }
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
            if (i >= size)
            {
                return -9999;
            }

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
            // Find 함수를 이용해 부모를 찾는다.
            return Find(x) == Find(y);
        }

        public void Show()
        {
            for (int i = 1; i < parent.Length; i++)
            {
                Console.Write(parent[i] + " ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 유니온 파인드
            // 여러 노드가 존재할 때 어떤 두 개의 노드를 같은 집합으로 묶은 다음, 어떤 두 노드가 같은 집합에 있는지 확인하는 알고리즘이다.

            Graph graph = new Graph();

            graph.Union(2, 3);
            graph.Union(1, 3);

            Console.WriteLine(graph.Same(2, 3));

            Console.WriteLine(graph.Same(1, 3));

            graph.Show();
            #endregion
        }
    }
}