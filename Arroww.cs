using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тортики
{
    internal class Arroww
    {
        public static int Arrow(int pos, int summa, string spisok)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine(" ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 2)
                        pos = 9;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 10)
                        pos = 3;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menushka.Tort(pos, summa, spisok);
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}