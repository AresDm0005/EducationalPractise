using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List(new int[]{ 1, 10, -4, 7, -9 });

            Console.WriteLine("Rec: {0}; Non-rec {1}", list.SumRecurs(), list.Sum());
        }
    }
}
