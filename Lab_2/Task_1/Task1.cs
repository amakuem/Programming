string answ;
do
{
    string a;
    long x;
    Console.WriteLine("Введите целоче число: ");
    while(true)
    {   

        a = Console.ReadLine();
        bool result = long.TryParse(a, out x);
        if (!result)
        {
            Console.WriteLine("Вводите только числа.");
            continue;
        }
        else
        {
            break;
        }
    }
    //string a = Console.ReadLine();
    switch (a[a.Length - 1])
    {
        case '7':
            Console.WriteLine("Это число заканчивается на 7.");
            break;
        default:
            Console.WriteLine("Число не заканчивается на 7.");
            break;
    }
    Console.WriteLine("Хотите ли вы продолжить? (Продолжить/Закончить)");
    answ = Console.ReadLine();
    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------"); 
} while (answ == "Продолжить" || answ == "Да" || answ == "Yes" || answ == "Y" || answ == "y" || answ == "1");

