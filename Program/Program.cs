using System.Runtime.ExceptionServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬
            // 데이터의 값을 직접 비교하지 않고 단순하게 각 숫자가 몇 개 있는지 개수를 세어 저장한 다음 정렬하는 알고리즘이다. 

            int[] ary = new int[] { 1, 6, 6, 6, 5, 1, 2, 3, 1, 2, 3, 6, 5, 4 };
            int[] count = new int[6];

            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < ary.Length; j++)
                {
                    if (ary[j] == i + 1)
                    {
                        count[i]++;
                    }
                }
            }

            for (int k = 0; k < count.Length; k++)
            {
                Console.Write(count[k] + " ");
            }

            #endregion
        }
    }
}