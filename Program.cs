using Тортики;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spisok = "";
            int summa = 0;
            int pos = 3;
            do
            {
                Console.Clear();
                Menushka.Tort(pos, summa, spisok);
            }
            while (true);
        }
    }
}