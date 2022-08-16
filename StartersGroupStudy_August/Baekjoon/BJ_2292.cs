//https://www.acmicpc.net/problem/2292
// 벌집

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2292
    {
        public static void Mai()
        {
            int N = int.Parse(Console.ReadLine());

            // (1) 1  : 1개
            // (6) 2 ~ 7 : 2개
            // (12 8~ 19 : 3개
            // ...

            int edge = 0;
            int to = 1;
            int count = 1;

            while (true)
            {
                to = to + 6 * edge++;

                if (N <= to)
                {
                    break;
                }
                count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
