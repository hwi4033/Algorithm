namespace Class7th__Count_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬
            // 데이터의 값을 직접 비교하지 않고 단순하게 각 숫자가 몇 개 있는지 개수를 세어 저장한 다음 정렬하는 알고리즘이다. 

            #region 풀이
            int[] array = new int[] { 1, 4, 5, 2, 3, 1, 1, 5 };

            int[] countList = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                countList[array[i] - 1] += 1;
            }

            for (int i = 0; i < countList.Length; i++)
            {
                Console.Write(countList[i] + " ");
            }

            Console.WriteLine();
            #endregion

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