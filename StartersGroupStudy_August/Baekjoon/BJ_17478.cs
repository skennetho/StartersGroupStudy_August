//https://www.acmicpc.net/problem/17478
// 재귀함수가 뭔가요?
using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_17478
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
            Echo(n);
            Console.ReadLine(); // stop terminal
        }

        static void Echo(int n, int cnt = 0)
        {
            string header = new string('_', cnt * 4);

            Console.WriteLine(header + "\"재귀함수가 뭔가요?\"");

            if (cnt < n)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(header + "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
                sb.AppendLine(header + "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
                sb.AppendLine(header + "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
                Console.Write(sb.ToString());

                Echo(n, cnt + 1);
            }
            else
            {
                Console.WriteLine(header + "\"재귀함수는 자기 자신을 호출하는 함수라네\"");
            }
            Console.WriteLine(header + "라고 답변하였지.");
        }
    }
}
