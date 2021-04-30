/*  а) Написать программу, которая подсчитывает расстояние между точками с координатами
 *  x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 *  Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 *  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static double DistCount(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*** Подсчет расстояния между точками ***\n");
            Console.Write("Введите x первой точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x второй точки: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nРасстояние между точками: {dist:0.00}");
            Console.WriteLine("Расстояние между точками (метод): {0:0.00}", DistCount(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}
