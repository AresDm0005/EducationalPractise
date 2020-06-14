using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Корректный ввод гарантирован тестирующей системой -> проверок не нужно
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int r = int.Parse(Console.ReadLine());

            // Полупериметр
            double p = (a + b + c) / 2.0;
            // Радиус вписаной окружности (максимально возможный)
            double Rmax = Math.Sqrt((p - a) * (p - b) * (p - c) / p);

            if (r <= Rmax) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
