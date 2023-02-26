// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число на которое нужно делить без остатка:");
int div = Int32.Parse(Console.ReadLine());
int buf = 0;
int count = 1;

List<int> nums = new List<int>(a);

while (count <= a)
{
    buf = count;
    buf = buf % div;
    if (buf == 0)
    {
        nums.Add(count);
        count++;
    }
    else count++;
}
Console.WriteLine(string.Join(" ", nums));

