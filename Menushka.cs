using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тортики
{
    internal class Menushka
    {
        private static int Etapi(int position, int summa, string spisok)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню\n-------------------------------------");
            if (position == 3)
            {
                Console.WriteLine(" Круг - 500");
                Console.WriteLine(" Квадрат - 500");
                Console.WriteLine(" Прямоугольник - 500");
                Console.WriteLine(" Сердечко - 700");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    summa += 500;
                    spisok += "Круг - 500; ";
                }
                else if (position == 4)
                {
                    spisok += "Квадрат - 500; ";
                    summa += 500;
                }
                else if (position == 5)
                {
                    spisok += "Прямоугольник - 500; ";
                    summa += 500;
                }
                else if (position == 6)
                {
                    spisok += "Сердечко - 700; ";
                    summa += 700;
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 4)
            {
                Console.WriteLine(" Маленький - 1000");
                Console.WriteLine(" Обычный - 1500");
                Console.WriteLine(" Большой - 2000");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    summa += 1000;
                    spisok += "Маленький - 1000; ";
                }
                else if (position == 4)
                {
                    spisok += "Обычный - 1500; ";
                    summa += 1500;
                }
                else if (position == 5)
                {
                    spisok += "Большой - 2000; ";
                    summa += 2000;
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 5)
            {
                Console.WriteLine(" Ванильный - 200");
                Console.WriteLine(" Шоколадный - 100");
                Console.WriteLine(" Карамельный - 100");
                Console.WriteLine(" Ягодный - 300");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    summa += 200;
                    spisok += "Ванильный - 200; ";
                }
                else if (position == 4)
                {
                    spisok += "Шоколадный - 100; ";
                    summa += 100;
                }
                else if (position == 5)
                {
                    spisok += "Карамельный - 100; ";
                    summa += 100;
                }
                else if (position == 6)
                {
                    spisok += "Ягодный - 300; ";
                    summa += 300;
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 6)
            {
                Console.WriteLine(" 1 корж - 200");
                Console.WriteLine(" 2 коржа - 400");
                Console.WriteLine(" 3 коржа - 600");
                Console.WriteLine(" 4 коржа - 800");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    spisok += "1 корж - 200; ";
                    summa += 200;
                }
                else if (position == 4)
                {
                    spisok += "2 коржа - 400; ";
                    summa += 400;
                }


                else if (position == 5)
                {
                    spisok += "3 коржа - 600; ";
                    summa += 600;
                }
                else if (position == 6)
                {
                    spisok += "4 коржа - 800; ";
                    summa += 800;
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 7)
            {
                Console.WriteLine(" Шоколад - 110");
                Console.WriteLine(" Крем - 150");
                Console.WriteLine(" Бизе - 200");
                Console.WriteLine(" Ягоды - 100");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    spisok += "Шоколад - 110; ";
                    summa += 110;
                }
                else if (position == 4)
                {
                    spisok += "Крем - 150; ";
                    summa += 150;
                }
                else if (position == 5)
                {
                    spisok += "Бизе - 200; ";
                    summa += 200;
                }
                else if (position == 6)
                {
                    spisok += "Ягоды - 100; ";
                    summa += 100;
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 8)
            {
                Console.WriteLine(" Шоколадная - 150");
                Console.WriteLine(" Ягодная - 200");
                Console.WriteLine(" Кремовая - 100");
                position = Arroww.Arrow(position, summa, spisok);
                if (position == 3)
                {
                    summa += 150;
                    spisok += "Шоколадная - 150; ";
                }
                else if (position == 4)
                {
                    summa += 200;
                    spisok += "Ягодная - 200; ";
                }
                else if (position == 5)
                {
                    summa += 100;
                    spisok += "Кремовая - 100; ";
                }
                Console.Clear();
                Tort(position, summa, spisok);
            }
            else if (position == 9)
            {
                Console.Clear();
                Console.WriteLine("Записано, нажмите Escape для повторного заказа");
                File.AppendAllText("C:\\Users\\vdb12\\OneDrive\\Рабочий стол\\История заказов.txt", "Заказ от: " + DateTime.Now.ToString() + "\n");
                File.AppendAllText("C:\\Users\\vdb12\\OneDrive\\Рабочий стол\\История заказов.txt", "Ваш заказ:  " + spisok + "\n");
                File.AppendAllText("C:\\Users\\vdb12\\OneDrive\\Рабочий стол\\История заказов.txt", "Сумма заказа:  " + summa.ToString() + "\n\n\n");
                summa = 0;
                spisok = "";
            }
            Arroww.Arrow(position, summa, spisok);
            return summa;
        }

        public static void Tort(int position, int summa, string spisok)
        {
            Console.WriteLine("Заказ тортов в Кондитере\nВыберите параметр торта\n------------------------------");
            Console.WriteLine(" Форма торта");
            Console.WriteLine(" Размер торта");
            Console.WriteLine(" Вкус коржей");
            Console.WriteLine(" Количество коржей");
            Console.WriteLine(" Глазурь");
            Console.WriteLine(" Декор");
            Console.WriteLine(" Конец заказа\n");
            Console.WriteLine("Цена: " + summa);
            Console.WriteLine("Ваш торт: " + spisok);
            position = Arroww.Arrow(position, summa, spisok);
            Etapi(position, summa, spisok);
        }
    }
}
