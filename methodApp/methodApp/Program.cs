using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            long b = a;
            long c = 20;
            int d = (int) c;
                double answer = GetSquare(a);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        private static double GetSquare(double aValue)
        {
            double square = aValue*aValue;
            return square;
        }
    }
}
