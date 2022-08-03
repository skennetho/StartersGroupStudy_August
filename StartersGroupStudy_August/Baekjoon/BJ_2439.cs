//https://www.acmicpc.net/problem/2439
// 별 찍기 - 2
namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2439
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if( j<= n - i)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
