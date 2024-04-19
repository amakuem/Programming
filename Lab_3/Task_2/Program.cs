using System.Globalization;
using Task_2.Services;

namespace Task_2
{
    internal class Program
    {
        static double Proverka()
        {
            bool ok;
            double result;

            while (true)
            {
                string? str = Console.ReadLine();
                ok = double.TryParse(str, CultureInfo.InvariantCulture, out result);
                if (ok)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            string? answ;
            do
            {
                double c, d, k, z, result;
                Console.WriteLine("Функуия для вычисления\ny = sin^3(c * x + d^2 + k * x^2)");
                Console.WriteLine("Введите переменные:");
                Console.Write("c: ");
                c = Proverka();
                Console.Write("d: ");
                d = Proverka();
                Console.Write("k: ");
                k = Proverka();
                Console.Write("z: ");
                z = Proverka();

                if (z < 0)
                {
                    Console.WriteLine("Переменная x рассчитываетсяпо формуле:\nx = z^2 - z");
                }
                else
                {
                    Console.WriteLine("Переменная x рассчитываетсяпо формуле:\nx = z^3");
                }
                result = ClassForTask2.Calculate(c, d, k, z);
                Console.WriteLine($"Ответ: {result}");

                Console.WriteLine("Хотите ли вы продолжить? (1 - Продолжить / 2 - Закончить)");
                answ = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            } while (answ == "1");

        }
    }
}