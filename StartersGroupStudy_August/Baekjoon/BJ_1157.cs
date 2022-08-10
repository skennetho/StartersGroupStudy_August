namespace StartersGroupStudy_August.Baekjoon
{
    internal class BJ_1157
    {
        public static void Mai()
        {
            string str = Console.ReadLine();
            int[] counter = new int[26];

            foreach(char c in str)
            {
                counter[ToIndex(c)]++;
            }

            int index = 0;
            bool isMaxTwo = false;
            for(int i = 1; i < counter.Length; ++i)
            {
                if (counter[index] == counter[i])
                {
                    isMaxTwo = true;
                }
                else
                {
                    if (counter[index] < counter[i])
                    {
                        index = i;
                        isMaxTwo = false;
                    }
                }    
            }

            if (isMaxTwo)
            {
                Console.WriteLine('?');
            }
            else
            {
                Console.WriteLine((char)(index+'A'));
            }
            Console.ReadLine();
        }

        static int ToIndex(char c)
        {
            if ('a' <= c && c <= 'z')
            {
                return c - 'a';
            }
            else
            {
                return c - 'A';
            }
        }
    }
}
