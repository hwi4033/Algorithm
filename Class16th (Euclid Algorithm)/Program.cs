namespace Class16th__Euclid_Algorithm_
{
    internal class Program
    {
        static int Euclid(int x, int y)
        {
            // 유클리드 호제법
            if (y == 0)
            {
                return x;
            }
            else
            {
                return Euclid(y, x % y);
            }
        }

        static int Eu(int x, int y)
        {
            int max = Math.Max(x, y);
            int min = Math.Min(x, y);
            int temp = max % min;

            if (temp == 0)
            {
                return min;
            }
            else
            {
                return Eu(min, temp);
            }
        }

        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 2개의 자연수 또는 정식의 최대 공약수를 구하는 알고리즘으로 
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘이다.
            // O(log n)?

            int x = 30, y = 48;
            int temp = 1;

            for (int i = 2; i <= x;)
            {
                if (x % i == 0 && y % i == 0)
                {
                    x = x / i;
                    y = y / i;

                    temp *= i;
                }
                else
                {
                    i++;
                }
            }

            // 일반 풀이
            int result = 0;

            for (int i = 1; i <= Math.Min(x, y); i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    result = i;
                }
            }

            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            Console.WriteLine("최대 공약수 : " + temp);

            // 두 수 중에서, 큰 수(A)를 작은 수(B)로 나눈 다음
            // 작은 수(B)를 큰 수를 작은 수로 나눈 나머지(C)로 나눠서 나머지가 0일 때까지 반복한다.

            Console.WriteLine(Euclid(78696, 19332));
            #endregion
        }
    }
}