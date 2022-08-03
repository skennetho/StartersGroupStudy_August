//https://www.acmicpc.net/problem/1110
// 더하기 사이클

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1110
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            int target = n;
            int count = 0;
            do
            {
                count++;
                int first = target / 10;
                int second = target % 10;
                int third = first + second;

                target = second * 10 + third % 10;
            } while (n != target);

            Console.WriteLine(count);
        }

        //public static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    Check(n, n);
        //    Console.WriteLine(count);
        //}


        //public static int count = 0;
        //public static void Check(int num, int target)
        //{
        //    count++;
        //    int first = num / 10;
        //    int second = num % 10;
        //    int third = first + second;

        //    if (second * 10 + third % 10 != target)
        //    {
        //        Check(second * 10 + third % 10, target);
        //    }
        //}
    }
}
