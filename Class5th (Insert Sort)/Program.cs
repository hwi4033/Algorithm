namespace Class5th__Insert_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 삽입 정렬
            // 데이터를 하나씩 확인하면서 이미 정렬된 부분과 비교하며 자신의 위치를 찾아 삽입하는 방식으로 정렬하는 알고리즘이다.
            // 시간 복잡도가 최악의 경우 n^2

            int[] ary = new int[] { 9, 6, 8, 1, 3 };
            int key = 0;
            int j = 0;

            for (int i = 1; i < ary.Length; i++)
            {
                key = ary[i];

                for (j = i - 1; j >= 0 && ary[j] > key; j--)
                {
                    ary[j + 1] = ary[j];
                }

                ary[j + 1] = key;
            }

            // int[] ary = new int[] { 9, 6, 8, 1, 3 };
            // int key = 0;

            // for (int i = 1; i < ary.Length; i++)
            // {
            //     key = ary[i];
            // 
            //     for (int j = i - 1; j >= 0; j--)
            //     {
            //         if (key < ary[j])
            //         {
            //             ary[j + 1] = ary[j];
            // 
            //             if (j == 0)
            //             {
            //                 ary[j] = key;
            //             }
            //         }
            //         else if (key > ary[j])
            //         {
            //             ary[j + 1] = key;
            //         }
            //     }
            // }

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }

            #endregion
        }
    }
}