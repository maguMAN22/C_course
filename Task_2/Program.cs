//Задача 2: Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Int32.Parse(Console.ReadLine());

if (a == b)
{
    Console.WriteLine(a + " равно " + b);
}
else if (a > b)
{
    Console.WriteLine(a + " больше " + b);
}
else
{
    Console.WriteLine(b + " больше " + a);
}
