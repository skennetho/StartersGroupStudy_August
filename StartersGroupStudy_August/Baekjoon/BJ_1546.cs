//https://www.acmicpc.net/problem/1546
// 평균

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1546
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //scores = scores.OrderByDescending(c => c).ToArray();
            Array.Sort(scores);

            double best = (double)scores[n - 1];
            double sum = 100;
            for (int i = 0; i < scores.Length - 1; i++)
            {
                sum += (((double)scores[i] / best) * 100.0);
            }

            double avg = sum / (double)n;
            Console.WriteLine(avg);
        }
    }
}
