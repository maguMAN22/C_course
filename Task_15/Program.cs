
void num2(int num)//для задачи 10 
{
    if ((num < 1000 && num > 99) || (num > -1000 && num < -99))
    {
        int result = num / 10 % 10;
        Console.WriteLine(result + " вторая цифра.");
    }
    else Console.WriteLine("Число не трёхзначное");
}

void num3(int num)//для задачи 13
{
    if (num > -100 && num < 100) Console.WriteLine("Третьей цифры нет.");
    else if (num < -99 || num > 99)
    {
        while (num < -999 || num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num + " третья цифра.");
    }

}

void task15()
{
    Console.WriteLine("Введите цифру, обозначающую день недели:");
    int a = Int32.Parse(Console.ReadLine());
    if (a < 8 && a > 5)
    {
        Console.WriteLine("Это выходной.");
    }
    else if (a > 0 && a < 6)
    {
        Console.WriteLine("Это рабочий день.");
    }
    else Console.WriteLine("Это не день недели.");
}

void task13()
{
    Console.WriteLine("Введите число:");
    int a = Int32.Parse(Console.ReadLine());
    num3(a);
}

void task10()
{
    Console.WriteLine("Введите трехзначное число:");
    int a = Int32.Parse(Console.ReadLine());
    num2(a);
}

Console.WriteLine("Введите номер задачи(10,13,15):");
int tuskNum = Int32.Parse(Console.ReadLine());
if (tuskNum == 15) task15();
else if (tuskNum == 13) task13();
else if (tuskNum == 10) task10();
else Console.WriteLine("Нет такой задачи.");