using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace Program
{

    internal class Program
    {
        static void hanoi(int n, char from, char by, char to)
        {
            if (n < 0)
            {
                Console.WriteLine(from + " -> " + to);
                return;
            }

            Console.WriteLine(from + " -> " + to);
            hanoi(n - 1, 'A', 'C', 'B');
            Console.WriteLine(from + " -> " + to);
        }

        static void Main(string[] args)
        {
            #region 백트레킹
            // 해를 찾아가는 도중에 지금의 경로가 해가 될 것 같지 않으면,
            // 더 이상 깊이 들어가지 않고, 이전 단계로 다시 돌아가는 알고리즘이다.

            // 백트레킹의 유망성 판단
            // 해가 될 만한지 판단한 후에 유망하지 않다고 결정되면,
            // 그 노드의 이전 노드로 돌아가 다음 자식 노드로 이동한다.

            // 해가 될 만한 가능성이 있으면 유망하다 - (Promising)
            // 유망하지 않은 노드에 가지 않는 것 - (Pruning)

            // 하노이
            // 1. 한 번에 하나의 원판만 이동한다.
            // 2. 맨 위에 있는 원판만 이동 가능하다.
            // 3. 크기가 작은 원판 위에 큰 원판을 쌓을 수 없다.

            hanoi(3, 'A', 'B', 'C');
            // a c
            // A C B
            // a b
            // c b

            // a c
            // A C B
            // b a
            // b c

            // a c
            // from to
            // from by
            // to by
            // from to
            #endregion
        }
    }
}