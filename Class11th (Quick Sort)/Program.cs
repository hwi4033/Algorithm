﻿namespace Class11th__Quick_Sort_
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void QuickSort(int[] list, int start, int end)
        {
            // 재귀를 탈출할 수 있도록 조건을 상단에 걸어둔다.
            if (start >= end)
            {
                return;
            }

            // 첫 번째 인덱스가 pivot이 되고 두 번째 인덱스가 left, 마지막 인덱스가 right가 된다.
            // 1. pivot 변수의 값을 설정한다.
            int pivot = start;
            // 2. start 변수의 값을 설정한다.
            int left = start + 1;
            // 3. end 변수의 값을 설정한다.
            int right = end;

            // 4. start가 end보다 크거나 같을 때까지 반복한다.
            while (left <= right)
            {
                // 5. left가 end보다 작거나 같고 list[left]가 list[pivot]보다 작거나 같을 때까지 반복한다.
                while (left <= end && list[pivot] >= list[left])
                {
                    left++;
                }

                // 6. right가 start보다 크고 list[right]가 list[pivot]보다 크거나 같을 때까지 반복한다.
                while (right > start && list[pivot] <= list[right])
                {
                    right--;
                }

                if (left > right)
                {
                    Swap(ref list[pivot], ref list[right]);
                }
                else
                {
                    Swap(ref list[left], ref list[right]);
                }
            }

            // 8. pivot을 기준으로 나누어진 두 배열에 대해 재귀적으로 퀵 정렬을 호출한다.
            QuickSort(list, start, right - 1);
            QuickSort(list, right + 1, end);
        }

        static void Main(string[] args)
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고
            // 한 쪽에는 기준점보다 작은 값들이 위치하고 다른 한 쪽에는 기준점보다 큰 값들이 위치하도록 한다.

            // 나누어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여 모든 배열이 기본 배열이 될 때까지 반복하면서 정렬한다.

            // 퀵 정렬은 평균적으로 O(n log n)의 시간 복잡도를 가지며,
            // 최악의 경우 O(n²)의 시간 복잡도를 가진다.

            // 1. 기준점을 선택한다.
            // 2. 기준점을 기준으로 왼쪽은 기준점보다 작은 값, 오른쪽은 기준점보다 큰 값을 탐색한다.
            // 3. 양방향에서 찾은 두 원소를 교환한다.
            // 4. 왼쪽에서 탐색하는 위치와 오른쪽에서 탐색하는 위치가 엇갈리지 않을 때까지 2번으로 돌아가 위의 과정을 반복한다.
            // 5. 엇갈린 기점을 기준으로 두 개의 부분 리스트로 나누어 1번으로 돌아가 해당 부분 리스트의 길이가 1이 될 때까지 반복한다.
            // 6. 인접한 부분 리스트끼리 합하여 수행한다.

            int[] ary = new int[] { 5, 3, 8, 9, 2, 4, 7, 1, 6, 10 };

            QuickSort(ary, 0, ary.Length - 1);

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            #endregion
        }
    }
}