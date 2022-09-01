using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_10815
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] arrM = Console.ReadLine().Split().Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();
            HashSet<int> set = new HashSet<int>(arrN);

            foreach (int i in arrM)
            {
                if (set.Contains(i))
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        void code1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] arrM = Console.ReadLine().Split().Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                map.Add(arrN[i], 1);
            }

            foreach (int i in arrM)
            {
                if (map.ContainsKey(i))
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
