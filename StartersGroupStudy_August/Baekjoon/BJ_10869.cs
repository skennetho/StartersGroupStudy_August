namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10869
    {
        public static void Mai()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(nums[0] + nums[1]);
            Console.WriteLine(nums[0] - nums[1]);
            Console.WriteLine(nums[0] * nums[1]);
            Console.WriteLine(nums[0] / nums[1]);
            Console.WriteLine(nums[0] % nums[1]);
        }
    }
}
