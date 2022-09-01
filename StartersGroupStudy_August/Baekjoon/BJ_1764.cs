using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1764
    {
        public static void Mai()
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            HashSet<string> 듣도못한사람들 = new HashSet<string>();
            List<string> 듣보잡 = new List<string>();

            for (int i = 0; i < n; i++)
            {
                듣도못한사람들.Add(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                string 보도못한사람 = Console.ReadLine();
                if (듣도못한사람들.Contains(보도못한사람))
                {
                    듣보잡.Add(보도못한사람);
                }
            }
            듣보잡.Sort();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(듣보잡.Count + "");
            듣보잡.ForEach(name => sb.AppendLine(name));
            

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
