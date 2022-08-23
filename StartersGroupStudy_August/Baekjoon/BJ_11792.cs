//https://www.acmicpc.net/problem/11729
//하노이 탑 이동 순서
using System;
using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_11792
    {
        static StringBuilder sb = new StringBuilder();
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = HanoiMove(1, 2, 3, n);
            Console.WriteLine(result);
            Console.WriteLine(sb.ToString());

            Console.Read(); // stop terminal
        }

        static int HanoiMove(int from, int mid, int to, int blocks)
        {
            if( blocks == 1)
            {
                sb.AppendLine(from + " " + to);
                return 1;
            }

            int result = 0;
            result += HanoiMove(from, to, mid, blocks - 1);
            result += HanoiMove(from, mid, to, 1); // 한개이동
            result += HanoiMove(mid, from, to, blocks - 1);

            return  result;
        }
    }
}
