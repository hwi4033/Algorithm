namespace Class23th__Prefix_sum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 누적합
            // 특정한 배열이 있을 때 해당 배열까지의 합을 의미한다.

            int[] array = new int[] { 7, 3, 4, 5, 1 };
            int[] sum = new int[array.Length];

            // O(n^2)
            // for (int i = 0; i < array.Length; i++)
            // {
            //     for (int j = 0; j <= i; j++)
            //     {
            //         sum[i] += array[j];    
            //     }
            // }

            // O(n)
            for (int i = 1; i < array.Length; i++)
            {
                array[i] += array[i - 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // 3 ~ 4 사이의 구간의 합
            Console.WriteLine("3 ~ 4 사이의 구간의 합 : " + (array[4] - array[2]));
            #endregion
        }
    }
}