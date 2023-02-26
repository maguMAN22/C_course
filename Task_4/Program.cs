// Задача 4: Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Int32.Parse(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max + " максимальное число.");
