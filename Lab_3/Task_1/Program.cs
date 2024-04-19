using System.Globalization;

namespace Task_1
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
                ok = double.TryParse(str, CultureInfo.InvariantCulture,out result);
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
                double a, b, answer;
                Console.Write("Введите числa:\nA: ");

                a = Proverka();

                Console.Write("B: ");
                b = Proverka();

                answer = MyClass.Calculate(a, b);
                if (answer == a)
                {
                    Console.WriteLine($"Функция принимает наименьшее значение в точке {a}");
                }
                else
                {
                    Console.WriteLine($"Функция принимает наименьшее значение в точке {b}");
                }

                Console.WriteLine("Хотите ли вы продолжить? (1 - Продолжить / 2 - Закончить)");
                answ = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            } while (answ == "1");
        }
    }
}