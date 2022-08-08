//https://www.acmicpc.net/problem/10818
// 최소, 최대

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10818
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers);

            Console.WriteLine(numbers[0]+" " + numbers[n-1]);

            Console.Read();
        }
    }
}
