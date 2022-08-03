//https://www.acmicpc.net/problem/11022
// A + B - 8

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_11022
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Console.WriteLine($"Case #{i+1}: {num[0]} + {num[1]} = {num[0] + num[1]}");
            }
            Console.ReadLine();
        }
    }
}
