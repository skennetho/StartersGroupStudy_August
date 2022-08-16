//https://www.acmicpc.net/problem/10757
// 큰 수 A+B

using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10757
    {
        public static void Mai()
        {
            string[] numbers = Console.ReadLine().Split();

            int index = 1;
            int extra = 0;
            int a, b;
            StringBuilder answer = new StringBuilder();

            while (true)
            {
                a = GetIndex(in numbers[0], index);
                b = GetIndex(in numbers[1], index);

                if (a == -1 && b == -1)
                {
                    if (extra != 0)
                    {
                        string ext = extra.ToString();
                        for (int i = ext.Length - 1; i >= 0; i--) //거꾸로 꺼내기
                        {
                            answer.Append(ext[i]);
                        }
                    }
                    break;
                }

                if (b != -1)
                {
                    extra += b;
                }

                if (a != -1)
                {
                    extra += a;
                }

                answer.Append(extra % 10);
                extra /= 10;

                index++;
            }

            string ans = answer.ToString();
            for (int i = ans.Length - 1; i >= 0; i--) //거꾸로 꺼내기
            {
                Console.Write(ans[i]);
            }

            Console.ReadLine();
        }

        static int GetIndex(in string str, int index)
        {
            if (index > str.Length)
            {
                return -1;
            }

            return str[str.Length - index] - '0';
        }
    }
}
