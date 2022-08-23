namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2839
    {
        public static void Mai()
        {
            int N = int.Parse(Console.ReadLine());

            int[] kilos = new int[5001];
            Array.Fill(kilos, -1);
            kilos[3] = 1;
            kilos[5] = 1;


            for(int i = 6; i< kilos.Length; i++)
            {
                if (kilos[i - 3] == -1 && kilos[i - 5] == -1)
                    continue;

                // kilos[n] = Math.min(kilos[n-3], kilos[n-5]) + 1;
                kilos[i] = Math.Min(
                    kilos[i - 3] != -1 ? kilos[i - 3] : int.MaxValue,
                    kilos[i - 5] != -1 ? kilos[i - 5] : int.MaxValue
                    ) + 1;
            }

            Console.WriteLine(kilos[N]);
        }
    }
}
