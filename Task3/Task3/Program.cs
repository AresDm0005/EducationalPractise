using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            bool ok = false;
            do
            {
                Console.WriteLine("x:");
                ok = double.TryParse(Console.ReadLine(), out x);
            } while (!ok);

            do
            {
                Console.WriteLine("y:");
                ok = double.TryParse(Console.ReadLine(), out y);
            } while (!ok);

            bool ans = Math.Abs(x) <= 1 && Math.Abs(y) <= 1;
            Console.WriteLine(ans ? "Принадлежит" : "Не принадлежит");
        }
    }
}
