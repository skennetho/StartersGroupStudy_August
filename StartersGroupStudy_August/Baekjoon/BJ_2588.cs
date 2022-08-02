namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2588
    {
        public static void Mai()
        {
            int upNum = int.Parse(Console.ReadLine());
            string downNum = Console.ReadLine();

            for (int i = 2; i >= 0; --i)
            {
                Console.WriteLine(upNum * (downNum[i] - '0'));
            }
            Console.WriteLine(upNum * int.Parse(downNum));
        }
    }
}
