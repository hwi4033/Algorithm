namespace Class6th__Shell_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬
            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로 정렬한 후, 점진적으로 더 작은 간격을 사용하는 정렬 알고리즘이다.

            // 1. 먼저 정렬해야 할 리스트(배열)를 일정한 기준에 따라 분류한다.
            // 2. 연속적이지 않은 여러 개의 부분 리스트를 생성한다.
            // 3. 각 부분 리스트를 삽입 정렬을 이용하여 정렬한다.
            // 4. 모든 부분 리스트가 정렬되면 다시 전체 리스트를 더 작은 개수의 부분 리스트로 만든 후에 정렬을 반복한다..
            // 5. 리스트 개수가 1이 될 떼까지 반복한다.

            #region  풀이
            int[] ary = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            int gap = 0;
            int i = 0;
            int j = 0;
            int key = 0;

            for (gap = ary.Length / 2; gap > 0; gap /= 2)
            {
                if (gap % 2 == 0)
                {
                    gap++;
                }

                for (i = gap; i < ary.Length; i++)
                {
                    key = ary[i];

                    for (j = i; j >= gap && ary[j - gap] > key; j -= gap)
                    {
                        ary[j] = ary[j - gap];
                    }

                    ary[j] = key;
                }
            }

            for (int k = 0; k < ary.Length; k++)
            {
                Console.Write(ary[k] + " ");
            }
            #endregion

            // int[] ary = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };
            // int key = 0;
            // int gap = ary.Length / 2;
            // 
            // while(gap != 1)
            // {
            //     for (int i = gap; i < ary.Length - 1; i++)
            //     {
            //         key = ary[i];
            // 
            //         if (key < ary[i - gap])
            //         {
            //             ary[i] = ary[i - gap];
            // 
            //             ary[i - gap] = key;
            //         }
            //     }
            // 
            //     gap = gap / 2;
            // 
            //     if (gap % 2 == 0)
            //     {
            //         gap += 1;
            //     }
            // }
            // 
            // int j = 0;
            // 
            // for (int i = 1; i < ary.Length; i++)
            // {
            //     key = ary[i];
            // 
            //     for (j = i - 1; j >= 0 && key < ary[j]; j--)
            //     {
            //         ary[j + 1] = ary[j];
            //     }
            // 
            //     ary[j + 1] = key;
            // }
            // 
            // for (int i = 0; i < ary.Length; i++)
            // {
            //     Console.Write(ary[i] + " ");
            // }

            #endregion
        }
    }
}