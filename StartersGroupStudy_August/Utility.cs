using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartersGroupStudy_August
{
    internal class Utility
    {

        public static int[,] StringTo2DArray(string str)
        {
            var rows = str.Split('[');
            int row = rows.Length;

            rows[2] = rows[2].Replace("],", "");
            rows[2] = rows[2].Replace("]]", "");
            var cols = rows[2].Split(',');
            int col = cols.Length;

            int[,] arr = new int[row - 2, col];

            for (int i = 2; i < rows.Length; i++)
            {
                rows[i] = rows[i].Replace("],", "");
                rows[i] = rows[i].Replace("]]", "");
                cols = rows[i].Split(',');

                for (int j = 0; j < col; j++)
                {
                    arr[i - 2, j] = int.Parse(cols[j]);
                }
            }
            return arr;
        }

        public static int[] StringToArray(string str)
        {
            str = str.Replace("[", "");
            str = str.Replace("]", "");
            var rows = str.Split(',');

            int[] arr = new int[rows.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(rows[i]);
            }

            return arr;
        }
    }
}
