namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2480
    {
        public static void Main()
        {
            int[] result = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] dice = new int[7];
            foreach (int r in result)
            {
                ++dice[r];
            }

            int money = 0;
            for (int i = 1; i < dice.Length; ++i)
            {
                if (dice[i] == 1)
                {
                    money = money > 100 * i ? money : 100 * i;
                }
                else if (dice[i] == 2)
                {
                    money = money > 1000 + 100 * i ? money : 1000 + 100 * i;
                }
                else if (dice[i] == 3)
                {
                    money = money > 10000 + 1000 * i ? money : 10000 + 1000 * i;
                    break;
                }
            }

            Console.WriteLine(money);
        }
    }
}
