//acmicpc.net/problem/10809
// 알파벳 찾기

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10809
    {
        public static void Mai()
        {
            string str = Console.ReadLine();

            int[] locations = new int[26];
            Array.Fill(locations, -1);

            for (int i = 0; i < str.Length; ++i)
            {
                char c = str[i];
                if (locations[c - 'a'] != -1)
                    continue;

                locations[c - 'a'] = i;
            }

            foreach (int i in locations)
            {
                Console.Write(i + " ");
            }
        }
    }
}