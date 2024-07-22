namespace Class13th__Dynamic_Programming_
{
    internal class Program
    {
        static int Fibo(int num)
        {
            if (num <= 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }

            return Fibo(num - 1) + Fibo(num - 2);
        }

        static int Fibonacci(int num, int[] list)
        {
            if (num <= 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }

            if (list[num] != 0)
            {
                return list[num];
            }

            return list[num] = Fibonacci(num - 1, list) + Fibonacci(num - 2, list);
        }

        static long FibonacciNumbers(long[] list, long num)
        {
            if (list[num] != 0)
            {
                return list[num];
            }

            if (num <= 0)
            {
                list[0] = 0;
                return list[0];
            }
            else if (num == 1)
            {
                list[num] = 1;
                return list[num];
            }
            else
            {
                list[num - 1] = FibonacciNumbers(list, num - 1);
                list[num - 2] = FibonacciNumbers(list, num - 2);

                return list[num - 1] + list[num - 2];
            }
        }

        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해 그것과 다른 범위까지의 값을 이용하여 효율적으로 값을 구하는 알고리즘이다.

            // 메모이제이션
            // 프로그램이 동일한 계산을 반복해야 할 때, 이전에 계산한 값을 메모리에 저장함으로써 동일한 계산을 반복 수행하는 작업을 제거하여
            // 프로그램의 실행 속도를 향상시키는 기법이다.

            int[] ary = new int[10000];
            long[] array = new long[1000];

            Console.WriteLine(Fibo(7));
            //Console.WriteLine(Fibonacci(45, ary));
            //Console.WriteLine(FibonacciNumbers(array, 92));

            #endregion
        }
    }
}