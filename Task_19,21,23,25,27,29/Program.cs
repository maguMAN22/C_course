void task_23()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125
    Console.WriteLine("Введите число:");
    int a = Int32.Parse(Console.ReadLine());
    for (int i = 1; i <= a; i++)
    {
        int num = i * i * i; //можно Math.Pow(i,3) через double
        Console.WriteLine(i + " ^ 3 = " + num + " ");
    }
}

void task_21()
{
    // Напишите программу, которая принимает на вход координаты двух 
    // точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53
    Console.WriteLine("Введите координаты первой точки");
    Console.WriteLine("x1 = ");
    double a1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("y1 = ");
    double b1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("z1 = ");
    double c1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Координаты первой точки: " + a1 + "," + b1 + "," + c1);
    Console.WriteLine("Введите координаты второй точки");
    Console.WriteLine("x2 = ");
    double a2 = Double.Parse(Console.ReadLine());
    Console.WriteLine("y2 = ");
    double b2 = Double.Parse(Console.ReadLine());
    Console.WriteLine("z2 = ");
    double c2 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Координаты второй точки: " + a2 + "," + b2 + "," + c2);

    double distance_between3d(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double db = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        db = Math.Round(db, 2);
        return db;
    }
    Console.Write("Расстояние между координатами: ");
    Console.WriteLine(distance_between3d(a1, b1, c1, a2, b2, c2));

}

void task_19()
{
    //Напишите программу, которая принимает на вход пятизначное число и 
    //проверяет, является ли оно палиндромом
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да
    Console.WriteLine("Введите число");
    string num = Console.ReadLine();
    int NumL = num.Length;
    if (NumL % 2 != 1) Console.WriteLine("Не может быть палиндромом");
    else
    {
        int buf = 0;
        int i = 0;
        int Num2L = num.Length - 1;
        int count = (Num2L) / 2;
        char ch1 = num[i];
        char ch2 = num[Num2L];
        while (i < count)
        {
            if (ch1 == ch2)
            {
                i++;
                NumL--;
                ch1 = num[i];
                ch2 = num[NumL];
            }
            else
            {
                buf = 1;
                break;
            }
        }
        if (buf == 1) Console.Write("Не палиндром");
        else
            Console.WriteLine("Палиндром");
    }
}

void task_25()
{
    // Напишите цикл, который принимает на вход два числа (A и B) и 
    // возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16

    Console.WriteLine("Введите число A:");
    double numa = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    double numb = Double.Parse(Console.ReadLine());

    double numCube(double numA, double numB)
    {
        double result = Math.Pow(numA, numB);
        return result;
    }
    Console.WriteLine("Число " + numa + " в степени " + numb + "= " + numCube(numa, numb));
}

void task_27()
{
    // Задача 27: Напишите программу, которая принимает 
    // на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12
    Console.WriteLine("Введите число:");
    string numS = Console.ReadLine();
    string numSumm(string nums)
    {
        int summa = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            char term = nums[i];
            int term1 = term - '0';
            summa = summa + term1;
        }
        string result = Convert.ToString(summa);
        return result;
    }
    Console.WriteLine("Сумма всех цифр в числе = " + numSumm(numS));


}

void task_29()
{
    Console.WriteLine("Введите размер массива:");
    int arrL = Int32.Parse(Console.ReadLine());

    int[] gen_array(int arrLength)
    {
        int[] arr1 = new int[arrLength];
        Random rand_num = new Random();
        for (int i = 0; i < arrLength; i++)
        {
            arr1[i] = rand_num.Next(0, arrLength);
        }
        return arr1;
    }

    void print_array(int[] arr)
    {
        Console.WriteLine("Вывод массива:");
        Console.Write("[ ");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + " ]");
    }
    print_array(gen_array(arrL));
}
task_29();