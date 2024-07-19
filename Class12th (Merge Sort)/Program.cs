namespace Class12th__Merge_Sort_
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
                Merge(list, start, middle, end);
            }
            */
        }

        static void Merge(int[] list, int start, int middle, int end)
        {
            int count = 0;
            int left = start;
            int right = middle + 1;
            int[] temporaryList = new int[(end - start) + 1];

            // 1. 두 부분의 배열을 병합한다.
            while (left <= middle && right <= end)
            {
                if (list[left] < list[right])
                {
                    temporaryList[count++] = list[left++];
                }
                else
                {
                    temporaryList[count++] = list[right++];
                }
            }

            // 2. 남은 왼쪽 배열의 요소들을 복사한다.
            while (left <= middle)
            {
                temporaryList[count++] = list[left++];
            }
            // 3. 남은 오른쪽 배열의 요소들을 복사한다.
            while (right <= end)
            {
                temporaryList[count++] = list[right++];
            }

            // 4. 원본 배열에 정렬된 임시 배열의 값을 복사한다.
            for (int i = 0; i < temporaryList.Length; i++)
            {
                list[start + i] = temporaryList[i];
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

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            #endregion
        }
    }
}