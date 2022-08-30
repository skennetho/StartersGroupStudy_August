//https://www.acmicpc.net/problem/1427
// 소트인사이트

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1427
    {
        public static void Mai()
        {
            string numStr = Console.ReadLine();

            int[] nums = new int[numStr.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numStr[i] - '0';
            }


            //그냥 Sort시 오름차순
            Array.Sort(nums, (int a, int b) => { return b - a; });

            int answer = 0;
            foreach (int i in nums)
            {
                answer *= 10;
                answer += i;
            }
            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
