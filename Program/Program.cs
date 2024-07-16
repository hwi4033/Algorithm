using System.Runtime.ExceptionServices;

namespace Program
{
    internal class Program
    {
        static void BinarySearch(int[] array, int num)
        {
            int left = 0;
            int right = array.Length - 1;
            int middle = (left + right) / 2;

            while(right >= left)
            {
                if (num > array[middle])
                {
                    left = middle + 1;
                    middle = (left + right) / 2;
                }
                else if (num < array[middle])
                {
                    right = middle - 1;
                    middle = (left + right) / 2;
                }
                
                if (num == array[middle])
                {
                    Console.WriteLine("[" + middle + "] : " + num);
                    return;
                }
            }

            Console.WriteLine("X");
        }

        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾고자 하는 값을 포함하는 범위를 좁혀가는 방식으로 동작하는 탐색 알고리즘이다.

            int[] ary = new int[] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };

            BinarySearch(ary, 33);
            #endregion
        }
    }
}