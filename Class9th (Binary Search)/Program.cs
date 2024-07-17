namespace Class9th__Binary_Search_
{
    internal class Program
    {
        static void BinarySearch(int[] list, int key)
        {
            int left = 0;
            int right = list.Length - 1;

            while (right >= left)
            {
                // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정한다.
                int pivot = (left + right) / 2;

                // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색을 종료한다.
                if (key == list[pivot])
                {
                    Console.WriteLine("Key Found : " + list[pivot]);
                    Console.WriteLine("[" + pivot + "] : " + key);
                    return;
                }
                // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot 사이의 값을 검색한다.
                else if (key < list[pivot])
                {
                    right = pivot - 1;
                }
                // 4. [pivot]의 값이 찾는 값보다 작다면 pivot ~ rigth 사이의 값을 검색한다.
                else
                {
                    left = pivot + 1;
                }
            }

            Console.WriteLine("Not key Found");
        }

        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾고자 하는 값을 포함하는 범위를 좁혀가는 방식으로 동작하는 탐색 알고리즘이다.

            int[] ary = new int[] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };

            BinarySearch(ary, 33);
            #endregion
        }
    }
}