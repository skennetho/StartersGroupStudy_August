//https://www.acmicpc.net/problem/10872
// 팩토리얼

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10872
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));

            //for(int i =1; i)

            Console.Read(); //stops terminal
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
