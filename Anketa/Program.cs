/*  Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
 *  В результате вся информация выводится в одну строчку:
 *  а) используя  склеивание;
 *	б) используя форматированный вывод;
 *  в) используя вывод со знаком $.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Анкета ***\n");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string family = Console.ReadLine();
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост: ");
            byte height = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите вес: ");
            byte weight = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\n\r a) " + name + " " + family + ", возраст " + age + ", рост " + height + " см, вес " +
                weight + " кг.");
            Console.WriteLine(" b) {0} {1}, возраст {2}, рост {3} см, вес {4} кг.", name, family, age, height, weight);
            Console.WriteLine($" c) {name} {family}, возраст {age}, рост {height} см, вес {weight} кг.");
            double imt = Math.Round(weight / Math.Pow(Convert.ToDouble(height) / 100, 2), 2);
            Console.WriteLine($"\nИндекс массы тела: {imt} кг/м2.");
            Console.ReadLine();
        }
    }
}
