//https://www.acmicpc.net/problem/2941
// 크로아티아 알파벳

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2941
    {
        public static void Mai()
        {
            string str = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length - i >= 3)
                {
                    //'='로 끝난다면.
                    if (str[i] == 'd' && str[i + 1] == 'z' && str[i + 2] == '=')
                    {
                        i += 2;
                    }
                }
                if (str.Length - i >= 2)
                {
                    // '-' 나 '='로 끝나는 경우이거나
                    // 'nj'나 'lj'이거나
                    if (str[i + 1] == '-' || str[i + 1] == '=' ||
                        (str[i] == 'l' || str[i] == 'n') && str[i + 1] == 'j')
                    {
                        i += 1;
                    }
                }
                count++;
            }

            Console.WriteLine(count);
        }
    }
}