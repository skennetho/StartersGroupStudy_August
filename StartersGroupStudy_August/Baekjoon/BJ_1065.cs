//https://www.acmicpc.net/problem/1065
// 한수

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1065
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isOneNumber = new bool[1001]; //0~1000

            for (int i = 0; i < 100; i++)
            {
                isOneNumber[i] = true;
            }

            for (int i = 1; i < 10; i++)
            {
                for (int diff = -4; diff < 5; diff++)
                {
                    if (i + (diff * 2) >= 0 && i + (diff * 2) < 10)
                    {
                        int num = 0;
                        num += (i + diff * 0) * 100;    //100의자리
                        num += (i + diff * 1) * 10;     //10의자리
                        num += (i + diff * 2) * 1;      //1의자리

                        isOneNumber[num] = true;
                    }
                }
            }

            int count = 0;
            for (int i = 1; i <=n; i++)
            {
                if (isOneNumber[i]) count++;
            }

            Console.WriteLine(count);
        }
    }
}