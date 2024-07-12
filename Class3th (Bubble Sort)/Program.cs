namespace Class3th__Bubble_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 거품 정렬
            // 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘이다.

            int[] ary = new int[5] { 5, 7, 1, 29, 32 };

            for (int i = 0; i < ary.Length - 1; i++)
            {
                for (int j = 0; j < ary.Length - (i + 1); j++)
                {
                    if (ary[j] > ary[j + 1])
                    {
                        int temp = ary[j];

                        ary[j] = ary[j + 1];

                        ary[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }

            #endregion
        }
    }
}