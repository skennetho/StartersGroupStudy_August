//https://www.acmicpc.net/problem/2798
// 블랙잭

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2798
    {
        public static void Mai()
        {
            //input
            int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = NM[0];
            int m = NM[1];

            //brute force
            int big = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        int current = arr[i] + arr[j] + arr[k];
                        if (big < current && current <= m)
                        {
                            big = current;
                        }
                    }
                }
            }

            //output
            Console.WriteLine(big);

            Console.Read(); // stop terminal
        }
    }
}
