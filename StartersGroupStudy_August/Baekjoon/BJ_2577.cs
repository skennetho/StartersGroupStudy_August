//https://www.acmicpc.net/problem/2577
// 숫자의 개수
using static System.Console;
namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2577
    {
        public static void Mai()
        {
            int num1 = int.Parse(ReadLine());
            int num2 = int.Parse(ReadLine());
            int num3 = int.Parse(ReadLine());

            int num = num1 * num2 * num3;
            string str = num + "";
            int[] counts = new int[10];
            foreach (char c in str)
            {
                counts[c - '0']++;
            }

            foreach (int count in counts)
            {
                WriteLine(count);
            }
        }
    }
}
