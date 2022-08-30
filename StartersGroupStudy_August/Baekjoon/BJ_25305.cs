//https://www.acmicpc.net/problem/25305
// 커트라인

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_25305
    {
        public static void Mai()
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //선택 정렬
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[maxIndex] < scores[j])
                    {
                        maxIndex = j;
                    }
                }
                int temp = scores[maxIndex];
                scores[maxIndex] = scores[i];
                scores[i] = temp;
            }

            Console.WriteLine(scores[k - 1]);

            Console.ReadLine();
        }
    }
}
