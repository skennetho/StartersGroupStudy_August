namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2525
    {
        public static void Mai()
        {
            int[] clock = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int time = int.Parse(Console.ReadLine());

            clock[1] = (clock[0] * 60 + clock[1]) + time;
            if (clock[1] >= 24 * 60)
            {
                clock[1] -= 24 * 60;
            }

            Console.WriteLine(clock[1] / 60);
            Console.WriteLine(clock[1] % 60);
        }
    }
}
