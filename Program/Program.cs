using System.Runtime.ExceptionServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과를 교체하는 방식으로 정렬하는 알고리즘이다.

            int[] ary = new int[] { 9, 6, 7, 3, 5 };

            for (int i = 0; i < ary.Length; i++)
            {
                int min = ary[i];

                int index = i;

                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (min > ary[j])
                    {
                        min = ary[j];

                        index = j;
                    }
                }

                int temp = ary[i];
                ary[i] = ary[index];
                ary[index] = temp;
            }

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }

            #endregion
        }
    }
}