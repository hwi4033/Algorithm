using System.Runtime.ExceptionServices;

namespace Program
{
    internal class Program
    {
        static void MergeSort(int[] list, int start, int end)
        {
            int middle = (start + end) / 2;

            if (start >= end)
            {
                return;
            }

            MergeSort(list, start, middle);
            MergeSort(list, middle + 1, end);
            Merge(list, start, middle, end);

/*
            if (start < end)
            {
                int middle = (start + end) / 2;

                MergeSort(list, start, middle);
                MergeSort(list, middle + 1, end);
            }
*/
        }

        static void Merge(int[] list, int start, int middle, int end)
        {
            int count = 0;
            int left = start;
            int right = middle + 1;
            int[] newList = new int[(right - left) + 1];

            for (count = 0; count < newList.Length; count++)
            {
                if (right > end)
                {
                    newList[count] = list[left++];
                }
                else if (left > middle)
                {
                    newList[count] = list[right++];
                }

                if (list[left] > list[right])
                {
                    newList[count] = list[right++];
                }
                else
                {
                    newList[count] = list[left++];
                }
            }
            
            for (int i = 0; i < newList.Length; i++)
            {
                list[i] = newList[i];
            }
        }

        static void Main(string[] args)
        {
            #region 병합 정렬
            // 하나의 리스트를 두 개의 균등한 크기로 분할하고 분할된 부분 리스트를 정렬한 다음,
            // 두 개의 정렬된 부분 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 알고리즘이다.

            // 1. 리스트의 길이가 0 또는 1이면 이미 정렬된 것으로 간주한디.

            // 2. 그렇지 않은 경우

            // 2-1. 정렬되지 않은 리스트를 절반으로 잘라 비슷한 크기의 두 부분 리스트로 나눈다.
            // 2-2. 각 부분 리스트를 재귀적으로 병합 정렬을 이용해 정렬한다.
            // 2-3. 두 부분 리스트를 다시 하나의 정렬된 리스트로 병합한다.

            int[] ary = new int[] { 21, 10, 12, 20, 25, 13, 15, 22 };

            MergeSort(ary, 0, ary.Length - 1);
            #endregion
        }
    }
}