//https://www.acmicpc.net/problem/15650
// N과 M(2)
using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_15650
    {
        static bool[] visited;
        static int[] result;
        public static void Mai()
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            visited = new bool[n];
            result = new int[m];
            Doo(m);

            Console.Read();
        }

        static void Doo(int max, int cnt = 0)
        {
            // m개를 골랐다면 출력
            if (cnt == max)
            {
                PrintResult();
                return;
            }

            // 아직 m개를 못골랐다면, 그동안 안고른것 중에서 고르기
            int begin = cnt > 0 ? result[cnt - 1] : 0;
            for (int i = begin; i < visited.Length; i++)
            {
                if (visited[i]) continue;

                visited[i] = true;
                result[cnt] = i + 1;
                Doo(max, cnt + 1);
                visited[i] = false;
            }
        }

        static void PrintResult()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in result)
            {
                sb.Append(i + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
