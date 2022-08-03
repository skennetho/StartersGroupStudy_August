//https://www.acmicpc.net/problem/10871
// X보다 작은 수

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10871
    {
        public static void Mai()
        {
            int[] nx = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where((num) => (num < nx[1]))
                .Select((num)=>num)
                .ToArray();


            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
