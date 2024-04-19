string answ;
const int b = 123; 
do
{
    long x, y;
    Console.WriteLine("Введите координаты x, y: ");
    while (true)
    {
        string xString = Console.ReadLine();
        bool result = long.TryParse(xString, out x);
        if (!result)
        {
            Console.WriteLine("Вводите только числа.");
            continue;
        }

        string yString = Console.ReadLine();
        bool result1 = long .TryParse(yString, out y);
        if (!result1)
        {
            Console.WriteLine("Вводите только числа.");
            continue;
        }
        if(result && result1)
        {
            break;
        }
        //int x = Convert.ToInt32(xString);
        //int y = Convert.ToInt32(Console.ReadLine()); 
    }
    double dist = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
    int otvet = 0;
    if (dist == 15 || dist == 25)
    {
        otvet = 1;
    }
    else if (dist > 15 && dist < 25)
    {
        otvet = 2;
    }
    else if (dist < 15 || dist > 25)
    {
        otvet = 3;
    }

    switch (otvet)
    {
        case 1:
            Console.WriteLine("Точка лежит на границе.");
            break;
        case 2:
            Console.WriteLine("Точка лежит вне заштрихованной области.");
            break;
        case 3:
            Console.WriteLine("Точка лежит в заштрихованной зоне.\n");
        break;
    }

        Console.WriteLine("Хотите ли вы продолжить? (Продолжить/Закончить)");
        answ = Console.ReadLine();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
} while (answ == "Продолжить" || answ == "Да" || answ == "Yes" || answ == "Y" || answ == "y" || answ == "1");

