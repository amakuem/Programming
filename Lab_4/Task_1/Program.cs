using System.Text.RegularExpressions;

namespace Task_1
{
    internal class Program
    {
        public static string ProverkaInfoRegion()
        {
            string? input;
            string infoRegion;
            //string pattern = @"^[а-яА-Яa-zA-Z\s]+$";

            while (true)
            {
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[a-zA-Z]+$") || Regex.IsMatch(input, @"^[а-яА-ЯёЁ]+$"))
                {
                    infoRegion = input;
                    return infoRegion;
                }
                else
                {
                    Console.WriteLine("Регион должен состоять только из букв!");
                    continue;
                }
            }
        }
        public static int ProverkaNumberOfHousingService()
        {
            string? input;
            int result;
            while (true)
            {
                input = Console.ReadLine();
                bool ok = int.TryParse(input, out result);
                if (ok && result > 0)
                {
                    ;
                    return result;
                }
                else
                {
                    Console.WriteLine("Номер должен быть положительной и не равна 0!");
                    continue;
                }
            }
        }
        public static int ProverkaNumberOfResidents()
        {
            string? input;
            int result;
            while (true)
            {
                input = Console.ReadLine();
                bool ok = int.TryParse(input, out result);
                if (ok && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Количество жильцов должно быть положительной и не равна 0!");
                    continue;
                }
            }
        }
        public static int ProverkaNumberOfPaid(int NumberOfResidents)
        {
            string? input;
            int result;
            while (true)
            {
                input = Console.ReadLine();
                bool ok = int.TryParse(input, out result);
                if (ok && result > 0 && result <= NumberOfResidents)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Количество оплативших должно быть положительной, не равна 0 и не больше количества жильцов!");
                    continue;
                }
            }
        }
        public static double ProverkaPaymentPerMonth()
        {
            string? input;
            double result;
            while (true)
            {
                input = Console.ReadLine();
                bool ok = Double.TryParse(input, out result);
                if (ok && result >= 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Цена должна быть положительной и не равна 0!");
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            HousingService housingService = HousingService.getInstance();
            
            Console.Write("1.Введите район ЖЭС: ");
            housingService.InfoRegion = ProverkaInfoRegion();
            Console.Write("2.Введите номер ЖЭС: ");
            housingService.NumberOfHousingService = ProverkaNumberOfHousingService();
            Console.Write("3.Введите количество жильцов: ");
            housingService.NumberOfResidents = ProverkaNumberOfResidents();
            int NumberOfResidents = housingService.NumberOfResidents;
            Console.Write("4.Введите число оплативших: ");
            housingService.NumberOfPaid = ProverkaNumberOfPaid(NumberOfResidents);
            Console.Write("5.Введите тариф: ");
            housingService.RateSet(ProverkaPaymentPerMonth());
            Menu.SetHousingService(housingService);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Menu.WriteMenu();
        }
    }
}