using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class Menu
    {
        private static HousingService housingService;
        private static bool ok;
        public static void SetHousingService(HousingService ones)
        {
            housingService = HousingService.getInstance();
            housingService = ones;
        }
        public static void StartMenu()
        {
            string? input;
            int temp;
            Console.WriteLine("Выберите номер варианта:\n1.Увеличить тариф.\n2.Уменьшить тариф.\n3.Посчитать количество общих долгов.\n4.Вывести данные.");
            while (true)
            {
                input = Console.ReadLine();
                bool ok = int.TryParse(input, out temp);
                if (ok && temp > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите номер определённого варианта!");
                    continue;
                }
            }
            switch (temp)
            {
                case 1:
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Введите число на которое хотите увеличить цену тарифа: ");

                        string? inp;
                        double increasingValue;
                        while (true)
                        {
                            inp = Console.ReadLine();
                            bool ok = Double.TryParse(inp, out increasingValue);
                            if (ok && increasingValue > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Цена должна быть положительной!");
                                continue;
                            }
                        }
                        housingService.RateIncr(increasingValue);

                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Menu.StartMenu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Введите число на которое хотите уменьшить цену тарифа: ");

                        string? inpt;
                        double degreesingValue;
                        while (true)
                        {
                            inpt = Console.ReadLine();
                            bool ok = Double.TryParse(inpt, out degreesingValue);
                            if (ok && degreesingValue > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Цена должна быть положительной!");
                                continue;
                            }
                        }
                        housingService.RateDegr(degreesingValue);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Menu.StartMenu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Количество общего долга: {housingService.TotalDebtOfResidents()}");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Menu.StartMenu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Menu.WriteMenu();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Menu.StartMenu();
                        break;
                    }
            }
        }
        public static void WriteMenu()
        {
            Console.WriteLine($"1.Район: {housingService.InfoRegion}");
            Console.WriteLine($"2.Номер ЖЭС: {housingService.NumberOfHousingService}");
            Console.WriteLine($"3.Количеество жильцов:{housingService.NumberOfResidents}");
            Console.WriteLine($"4.Количество оплативших: {housingService.NumberOfPaid}");
            Console.WriteLine($"5.Тариф: {housingService.RateGet()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Menu.StartMenu();
        }
    }
}
