
void task_34()
{
    // Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    int[] gen_array(int arrayLength)
    {

        int[] arr1 = new int[arrayLength];
        Random rand_num = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            arr1[i] = rand_num.Next(-999, 1000);
        }
        return arr1;
    }
    int even_num(int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) counter++;
        }
        return counter;
    }
    void print_array(int[] arr)
    {
        Console.WriteLine("Вывод массива:");
        Console.Write("[ ");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + " ] количество чётных чисел в массиве --> " + even_num(arr));
    }
    Console.WriteLine("Введите длину массива:");
    int arrayL = Int32.Parse(Console.ReadLine());
    print_array(gen_array(arrayL));
}

void task_36()
{
    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0
    int[] gen_array(int arrayLength)
    {

        int[] arr1 = new int[arrayLength];
        Random rand_num = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            arr1[i] = rand_num.Next(-999, 1000);
        }
        return arr1;
    }
    int even_index_summ(int[] arr)
    {
        int summa = 0;
        for (int i = 1; i < arr.Length; i = i + 2)
        {
            summa = summa + arr[i];
        }
        return summa;
    }
    void print_array2(int[] arr)
    {
        Console.WriteLine("Вывод массива:");
        Console.Write("[ ");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + " ] сумма элементов, стоящих на нечётных позициях --> " + even_index_summ(arr));
    }
    Console.WriteLine("Введите длину массива:");
    int arrayL = Int32.Parse(Console.ReadLine());
    print_array2(gen_array(arrayL));
}

void task_38()
{
    // Задача 38: Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76
    double[] gen_array(int arrayLength)
    {
        double[] arr1 = new double[arrayLength];
        Random rand_num = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            arr1[i] = Math.Round(rand_num.NextDouble() * rand_num.Next(-999, 1000),2);
        }
        return arr1;
    }
    double find_max_min(double[] arr)
    {
        double max = -999;
        double min = 1000;

        for (int i = 0; i < arr.Length; i++)
        {
          if(arr[i] > max) max = arr[i]; 
          if(arr[i] < min) min = arr[i];
        }
        double result = max - min;
        return result;
    }
    void print_array2(double[] arr)
    {
        Console.WriteLine("Вывод массива:");
        Console.Write("[ ");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + "; ");
        }
        Console.Write(arr[arr.Length - 1] + " ] разница между максимальным и минимальным --> " + find_max_min(arr));
    }
    Console.WriteLine("Введите длину массива:");
    int arrayL = Int32.Parse(Console.ReadLine());
    print_array2(gen_array(arrayL));

}
task_38();

