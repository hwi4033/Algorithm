﻿namespace Class10th__Divide___Conquer_
{
    internal class Program
    {
        static int Find(int[] list, int left, int right)
        {
            if (left == right)
            {
                return list[left];
            }
            else
            {
                int maxLeft = Find(list, left, (left + right) / 2);
                int maxRight = Find(list, (left + right) / 2 + 1, right);

                if (maxLeft > maxRight)
                {
                    return maxLeft;
                }
                else
                {
                    return maxRight;
                }
            }
        }

        static void Main(string[] args)
        {
            #region 분할 정복
            // 주어진 문제를 2개 이상의 부분으로 문제를 나눈 뒤 각 부분 문제에 대한 답을 재귀 호출을 이용해서 계산한 다음
            // 그 답으로부터 전체 문제의 답을 계산해내는 알고리즘이다.

            // 분할(Divide) : 주어진 문제를 두 개 혹은 그 이상의 형식으로 나눈다.

            // 정복(Conquer) : 나누어진 문제를 재귀적으로 해결해서 나누어진 문제를 더 이상 나누어 문제를 해결할 필요가 없을 때까지 계속 분할한다.

            // 통합(Combine) : 나누어서 해결한 문제들을 통합해서 원래 문제의 해답을 생성한다.

            int[] ary = new int[] { 3, 6, 1, 5, 8, 9, 2, 10 };

            Console.WriteLine(Find(ary, 0, ary.Length - 1));
            #endregion
        }
    }
}