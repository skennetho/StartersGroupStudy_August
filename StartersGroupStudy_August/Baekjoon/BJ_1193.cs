//https://www.acmicpc.net/problem/1193
// 분수찾기

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1193
    {
        public static void Mai()
        {
            int num = int.Parse(Console.ReadLine());
            Solve(num);
            //Console.ReadLine();
        }

        private static void Solve(int num)
        {
            int lineMax = 0;
            int line = 1;

            for (; lineMax <= 10000000; line++)
            {
                lineMax += line;
                if (num <= lineMax)
                {
                    break;
                }
            }

            int diff = lineMax - num + 1;

            if (line % 2 == 0)
            {
                Console.WriteLine((line - diff + 1) + "/" + diff);
            }
            else
            {
                Console.WriteLine(diff + "/" + (line - diff + 1));
            }
        }
    }
}