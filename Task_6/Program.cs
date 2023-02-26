//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a = Int32.Parse(Console.ReadLine());

a = a % 2;
if (a == 0) Console.WriteLine("Число чётное.");
else Console.WriteLine("Число нечётное.");