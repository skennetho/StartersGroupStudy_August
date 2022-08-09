//https://www.acmicpc.net/problem/4673
// 셀프 넘버

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_4673
    {
        public static void Mai()
        {
            int n = 10000;

            //d[n] == n이뜨는 경우의수.
            int[] counter = new int[n]; 

            // 1부터 n까지 나올수 있는 경우의 수들 체크.
            for (int i = 1; i < n; ++i)
            {
                int selfNum = GetSelfNum(i);
                if (selfNum >= n) continue;
                counter[selfNum]++;
            }

            //위 for문에서 못찾아낸 숫자들 == SelfNum
            for (int i = 1; i < n; ++i)
            {
                if (counter[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int GetSelfNum(int n)
        {
            int sum = n;

            for (int i = 1; i <= 10000; i *= 10)
            {
                sum = sum + (n / i) % 10;
            }
            return sum;
        }
    }
}
