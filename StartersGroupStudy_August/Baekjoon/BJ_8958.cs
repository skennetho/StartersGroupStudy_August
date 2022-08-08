//https://www.acmicpc.net/problem/8958
// OX퀴즈

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_8958
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string str = Console.ReadLine();

                int sum = 0;
                int count = str[0] == 'O' ? 1 : 0;
                for (int i = 1; i < str.Length; i++)
                {
                    sum += count;
                    if (str[i] == 'X')
                    {
                        count = 0;
                    }
                    if (str[i] == 'O')
                    {
                        if (str[i - 1] == 'O')
                        {
                            count++;
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                }
                sum += count;

                Console.WriteLine(sum);
            }
        }
    }
}
