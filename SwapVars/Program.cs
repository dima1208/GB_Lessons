/*  Написать программу обмена значениями двух переменных:
 *  а) с использованием третьей переменной;
 *	б) *без использования третьей переменной.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 22;
            Console.WriteLine($"a={a}, b={b}", a, b);
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"a) a={a}, b={b}", a, b);
            (a, b) = (b, a);
            Console.WriteLine($"b) a={a}, b={b}", a, b);
            Console.ReadLine();
        }
    }
}
