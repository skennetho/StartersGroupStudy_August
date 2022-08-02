namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2884
    {
        public static void Mai()
        {
            //0: hour, 1: minute
            int[] time = Console.ReadLine().Split().Select(int.Parse).ToArray();

            time[1] = (time[0] * 60 + time[1]) - 45;
            if (time[1] < 0)
            {
                time[1] = (24 * 60) + time[1];
            }

            Console.Write(time[1] / 60 + " ");
            Console.WriteLine(time[1] % 60);
        }
    }
}
