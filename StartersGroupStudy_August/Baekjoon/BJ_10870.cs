//https://www.acmicpc.net/problem/10870
// 피보나치 수 5

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10870
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));

            Console.ReadLine(); // stop terminal
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
