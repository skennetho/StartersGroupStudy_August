//https://www.acmicpc.net/problem/7568
//덩치

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_7568
    {
        public static void Mai()
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            //모두가 1대1로 붙어본다. 진놈은 등수+1
            int[] ranking = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i][0] < arr[j][0] && arr[i][1] < arr[j][1])
                    {
                        ranking[i]++;
                    }
                    else if (arr[i][0] > arr[j][0] && arr[i][1] > arr[j][1])
                    {
                        ranking[j]++;
                    }
                }
            }

            //output
            foreach (int i in ranking)
            {
                Console.Write((i + 1) + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
