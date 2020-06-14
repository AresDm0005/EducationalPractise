using System;

namespace Task2
{
    class Program
    {
        static long[] list = new long[15000];
        static int lastIndex = 0;

        static void Add(int index, long num, ref bool fl)
        {
            if (num < list[index] || list[index] == -1)
            {
                if (list[index - 1] == num) fl = false;
                else
                {
                    fl = false;
                    Array.Copy(list, index, list, index + 1, lastIndex - index + 1);
                    lastIndex++;
                    list[index] = num;
                }
            }
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < list.Length; i++) list[i] = -1;
            int N = int.Parse(Console.ReadLine()) - 1;

            list[0] = 1;
            for (int i = 0; i <= N + 1; i++)
            {
                long a = list[i];
                bool f1 = true;
                bool f2 = true;
                bool f3 = true;
                long p1 = 2 * a;
                long p2 = 3 * a;
                long p3 = 5 * a;

                int j;
                for (j = i + 1; j < list.Length && (f1 || f2 || f3); j++)
                {
                    if (f1)
                    {
                        Add(j, p1, ref f1);
                    }
                    if (f2)
                    {
                        Add(j, p2, ref f2);
                    }
                    if (f3)
                    {
                        Add(j, p3, ref f3);
                    }
                }
                if (j > lastIndex) lastIndex = j;
            }

            Console.WriteLine(list[N]);
        }
    }
}