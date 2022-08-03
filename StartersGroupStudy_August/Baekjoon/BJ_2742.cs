//https://www.acmicpc.net/problem/2742
// 기찍 N
using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2742
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (; n > 0; n--)
            {
                sb.AppendLine(n.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
