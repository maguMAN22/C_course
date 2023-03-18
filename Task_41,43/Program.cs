void task_41()
{
    // Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3
    int counter = 0;
    string nums = "В числах ";
    while (true)
    {
        string num = Console.ReadLine();
        if (num == "Q" || num == "q") break;
        else
        {
            int numInt = Int32.Parse(num);
            if (numInt > 0) counter++;
        }
        nums = nums + num + ", ";
    }
    Console.WriteLine(nums + "количество чисел больше 0 = " + counter);
}
void task_43()
{
    //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
    // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine("Введите K1:");
    double k1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите B1:");
    double b1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите K2:");
    double k2 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите B2:");
    double b2 = Double.Parse(Console.ReadLine());
    double x = -(b1 - b2) / (k1 - k2);
    double y = (k2 * x) + b2;
    Console.WriteLine("Точка пересечения двух прямых -> (" + x + " ; " + y + ")");
}
task_43();