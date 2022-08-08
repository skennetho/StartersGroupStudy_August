//https://www.acmicpc.net/problem/3052
// 나머지

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_3052
    {
        public static void Mai()
        {
            bool[] visited = new bool[43];
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                visited[num % 42] = true;
            }

            int count = 0;
            foreach (bool b in visited)
            {
                if (b) count++;
            }
            Console.WriteLine(count);
        }
    }
}
