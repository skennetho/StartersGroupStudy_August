//https://www.acmicpc.net/problem/5622
// 다이얼

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_5622
    {
        public static void Mai()
        {
            int[] times = { 3,3,3,
            4,4,4,
            5,5,5,
            6,6,6,
            7,7,7,
            8,8,8,8,
            9,9,9,
            10,10,10,10};

            string str = Console.ReadLine();

            int sum = 0;
            foreach (char c in str)
            {
                sum += times[c - 'A'];
            }
            Console.WriteLine(sum);
        }
    }
}
 