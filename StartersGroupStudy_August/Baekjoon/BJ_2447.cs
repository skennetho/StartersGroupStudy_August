//https://www.acmicpc.net/problem/2447
//별 찍기 - 10

using System.Text;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2447
    {
        static bool[,] arr = new bool[6561, 6561]; //3^8 == 6561
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());
            //디버그용
            //debug = n;    

            MakeHole(0, 0, n);
            Print(n);
            Console.Read(); //stop terminal
        }
        //디버그용
        //static int debug;

        static void MakeHole(int fromI, int fromJ, int width)
        {
            //9등분시 변 하나.
            int _width = width / 3;

            //가운데 뚫기
            for (int i = _width; i < _width * 2; i++)
            {
                for (int j = _width; j < _width * 2; j++)
                {
                    arr[fromI + i, fromJ + j] = true;
                }
            }

            //디버그
            //Print(debug);
            //Console.WriteLine();

            //3x3이라면 즉 9등분시 변이 1이라면 재귀종료
            if (_width == 1)
            {
                return;
            }

            // 9등분시 1,2,3,4,_,6,7,8,9 번쨰 돌기
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1) continue; // 5번째는 패쓰

                    MakeHole(fromI + i * _width, fromJ + j * _width, _width);
                }
            }
        }


        static void Print(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(arr[i, j] ? ' ' : '*');
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
