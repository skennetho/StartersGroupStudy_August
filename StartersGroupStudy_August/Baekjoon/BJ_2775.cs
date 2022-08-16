//https://www.acmicpc.net/problem/2775
// 부녀회장이 될테야

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2775
    {
        public static void Mai()
        {
            int[,] arr = new int[15, 15];
            //0층 사람들 초기화.
            for (int i = 1; i <= 14; i++)
            {
                arr[0, i] = i;
            }

            //0~13층까지만 필요.
            for (int k = 1; k <= 14; k++)
            {
                int sum = 0;
                //k층 i호 필요인원 계산
                for(int i = 1; i <= 14; i++)
                {
                    sum += arr[k - 1, i];
                    arr[k, i] = sum;
                }
            }

            int testcase = int.Parse(Console.ReadLine());
            while (testcase-- > 0)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(arr[k,n]);
            }
            Console.ReadLine();
        }
    }
}