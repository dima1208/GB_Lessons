//Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class MyFunctions
    {
        static void PrintTxt(string txt, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(txt);
        }

        static void WaitKey()
        {
            Console.ReadLine();
        }
    }
}
