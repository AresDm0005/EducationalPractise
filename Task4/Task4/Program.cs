using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static double F(double x)
        {
            return x * x * x - 0.2 * x * x - 0.2*x - 1.2;
        }

        static void Main(string[] args)
        {
            double left = 1, right = 1.5;
            double eps;
            bool ok = false;

            do
            {
                Console.WriteLine("Введите точность вычисления (например 0,0001):");
                ok = double.TryParse(Console.ReadLine(), out eps);

                if (ok & (eps > 1 || eps <= 0)) ok = false;
            } while (!ok);

            while(Math.Abs(F(right) - F(left)) > eps)
            {
                double mid = left + (right - left) / 2.0;
                if (F(right) * F(mid) <= 0) left = mid;
                else right = mid;                
            }

            Console.WriteLine(left);
        }
    }
}
