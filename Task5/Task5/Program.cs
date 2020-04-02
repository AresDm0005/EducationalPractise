using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static int[,] check =
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, -2, 3, 4, 5, 6, 7, 8, 9, 10 }, // 51
            { 1, 2, -3, 4, 5, 6, 7, 8, 9, 10 }, // 49
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, 2, 3, 4, 5, 6, -7, 8, 9, 10 }, // 41
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10 } // 35
        };


        static void Main(string[] args)
        {
            int N = 10;
            int[,] matr = new int[N, N];
                        
            for(int i = 0; i<N; i++)
            {
                for(int j = 0; j<N; j++)
                {
                    matr[i, j] = int.Parse(Console.ReadLine());
                }
            }            

            //matr = check;
            for (int i = 0; i < N; i++)
            {
                if (matr[i, i] < 0)
                {
                    int sum = 0;
                    for (int j = 0; j < N; j++)
                    {
                        sum += matr[i, j];
                    }
                    Console.WriteLine($"Строка {i+1}, гл. диаг.: {matr[i,i]} - сумма: {sum}");
                } 
                else Console.WriteLine($"Строка {i + 1}, гл. диаг.: {matr[i, i]}");
            }
        }
    }
}
