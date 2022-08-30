//https://www.acmicpc.net/problem/2750
// 수 정렬하기

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_2750
    {
        public static void Mai()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for(int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(int[] array, Comparison<int> comparison)
            Array.Sort(nums, (int a, int b) =>
            {
                return a - b;
                //true  => a와 b 바 꿈   
                //false => a와 b 그대로
            });

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
