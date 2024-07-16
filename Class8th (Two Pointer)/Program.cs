namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 문제를 해결하는 알고리즘이다.
            // start와 end(left와 right) : 참조 변수 생성

            // 1. 시작점과 끝점이 첫 번째 원소의 인덱스를 가리키게 한다.
            // 2. 현재 부분합이 M과 같다면 카운트한다.
            // 3. 현재 부분합이 M보다 작다면 end를 1 증가시킨다.
            // 4. 현재 부분합이 M보다 크거나 같다면 start를 1 증가시킨다.

            int[] ary = new int[] { 1, 2, 5, 2, 5 };

            int m = 5;
            int sum = 0;        // 부분합을 저장할 변수

            int count = 0;
            int start = 0;
            int end = 0;

            while (start <= end)
            {
                if (sum >= m)
                {
                    sum -= ary[start++];
                }
                else if (end >= ary.Length)
                {
                    break;
                }
                else
                {
                    sum += ary[end++];
                }

                if (sum == m)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            #endregion
        }
    }
}