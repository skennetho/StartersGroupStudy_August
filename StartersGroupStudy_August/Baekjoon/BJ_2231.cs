//https://www.acmicpc.net/problem/2231
// 분해합

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2231
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());

            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                int dec = Decomposition(i);
                if (dec == n)
                {
                    answer = i;
                    break;
                }

            }

            Console.WriteLine(answer);

            Console.Read(); // stop terminal
        }

        static int Decomposition(int num)
        {
            int sum = num;

            //일의 자리부터 하나씩, 첫번째 자리 빼고
            int i;
            for (i = 10; num % i != num; i *= 10)
            {
                // ex
                // 234 %10  /  1 == 4,
                // 234 %100 / 10 == 3,
                // 234 %1000/100 => break
                sum += (num % i) / (i / 10);
            }

            //첫번째 자리         
            sum += (num % i) / (i / 10);

            return sum;
        }
    }
}
