/* 
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Print(string txt, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(txt);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("a) Дмитрий Пересёлкин, г. Красноярск");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("b) Дмитрий Пересёлкин, г. Красноярск");
            Print("c) Дмитрий Пересёлкин, г. Красноярск", 14, 24);
            Console.ReadLine();
        }
    }
}
