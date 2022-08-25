//https://www.acmicpc.net/problem/1436
//영화감독 숌

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1436
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 0;
            int i;
            for (i = 666; i < int.MaxValue; i++)
            {
                if (IsContain666(i))
                {
                    if (++cnt == n)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(i);
            Console.Read();
        }

        static bool IsContain666(int num)
        {
            string str = num.ToString();

            int cnt = 0;
            foreach (char c in str)
            {
                if (c == '6')
                {
                    if (++cnt >= 3)
                    {
                        return true;
                    }
                }
                else
                {
                    cnt = 0;
                }
            }

            return false;
        }
    }
}
