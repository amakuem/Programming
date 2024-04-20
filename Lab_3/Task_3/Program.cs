namespace Task_3
{
    internal class Program
    {
        static DateTime ProverkaFirst()
        {
            while(true)
            {
                string? input = Console.ReadLine();
                string?[] parts = input.Split('.');
                if (parts.Length < 3)
                {
                    Console.WriteLine("Введенная строка не является действительной датой. Пожалуйста, введите дату в формате дд.мм.гггг.");
                    continue;
                }
                else
                {
                    int day, month, year;
                    bool isDayValid = int.TryParse(parts[0], out day);
                    bool isMonthValid = int.TryParse(parts[1], out month);
                    bool isYearValid = int.TryParse(parts[2], out year);

                    if (isDayValid && isMonthValid && isYearValid)
                    {
                        DateTime date = new DateTime(year, month, day);
                        //Console.WriteLine($"Введенная дата: {date.Day.ToString("D2")}.{date.Month.ToString("D2")}.{date.Year}");
                        return date;
                    }
                    else
                    {
                        Console.WriteLine("Введенная строка не является действительной датой. Пожалуйста, убедитесь, что вы ввели день, месяц и год.");
                        continue;
                    }
                }
            }
        }
        static int BaseProverka()
        {
            int result;
            while(true)
            {
                string? day = Console.ReadLine();
                bool checkDay = int.TryParse(day, out result);
                if (checkDay)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Дата должна содержать целые цифры!");
                    continue;
                }

            }
        }
        static bool ProverkaSecond(int day, int month, int year)
        {
            if (DateTime.TryParse($"{day}/{month}/{year}", out DateTime date))
            {
                return true;
                //Console.WriteLine("Дата корректна");
            }
            else
            {
                return false;
                //Console.WriteLine("Дата некорректна");
            }
        }
        static void Main(string[] args)
        {
            string? answ;
            do
            {
                int day, month, year, difference;
                DateTime date;
                string dayOfWeek;
                bool ok;

                Console.WriteLine("Введите дату для рассчета следующего год (в формате дд.мм.гггг):");
                
                date = ProverkaFirst();
                dayOfWeek = DateService.GetDay(date.ToString());
                Console.WriteLine($"День недели: {dayOfWeek}");

                Console.WriteLine("Введите дату для рассчета следующего дня");
                while (true)
                {
                    Console.Write("День: ");
                    day = BaseProverka();
                    Console.Write("Месяц: ");
                    month = BaseProverka();
                    Console.Write("Год: ");
                    year = BaseProverka();

                    ok = ProverkaSecond(day, month, year);
                    if (ok)
                        break;
                    else
                    {
                        Console.WriteLine("Дата введена неправильно!");
                        continue;
                    }
                        
                }
                

                difference = DateService.GetDaysSpan(day, month, year);

                Console.WriteLine($"Разница между днями: {difference}");

                //Console.WriteLine($"Следующий день: {nextDay.ToString("dd.MM.yyyy")}");
                Console.WriteLine("Хотите ли вы продолжить? (1 - Продолжить / 2 - Закончить)");
                answ = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            } while (answ == "1");
        }
    }
}