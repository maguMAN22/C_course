void task47()
{
    // Задайте двумерный массив размером m×n, 
    // заполненный случайными вещественными числами.


    double[,] gen_array(int arrLines, int arrColumns)
    {
        double[,] arr1 = new double[arrLines, arrColumns];
        Random rand_num = new Random();
        for (int j = 0; j < arrColumns; j++)
        {
            for (int i = 0; i < arrLines; i++)
            {
                arr1[i, j] = Math.Round(rand_num.NextDouble() * rand_num.Next(-9, 10), 1);
            }
        }
        return arr1;
    }
    void PrintArr(double[,] arr)
    {
        int line = arr.GetLength(0);
        int column = arr.GetLength(1);

        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {

                string arr1 = arr[i, j].ToString();
                if (arr1.Length == 1)
                    Console.Write("  " + arr1 + "  | ");
                if (arr1.Length == 2)
                    Console.Write(" " + arr1 + "  | ");
                if (arr1.Length == 3)
                    Console.Write(" " + arr1 + " | ");
                if (arr1.Length == 4)
                    Console.Write(arr1 + " | ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine("Задайте размер массива:");
    Console.WriteLine("Строки:");
    int arrLine = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Столбцы:");
    int arrColumn = Int32.Parse(Console.ReadLine());
    if (arrColumn > 16)
    {
        Console.WriteLine("!!!Возможно нарушение форматирования!!!");
        Console.WriteLine("Продолжить? Y/N");
        string exit = Console.ReadLine().ToLower();
        if (exit == "n") System.Environment.Exit(0);
    }

    PrintArr(gen_array(arrLine, arrColumn));
}

void task50()
{
    //     Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //     и возвращает значение этого элемента или же указание, что такого элемента нет.
    int[,] gen_array2dim(int arrayLine, int arrayColumn)
    {
        int[,] arr = new int[arrayLine, arrayColumn];
        Random rand = new Random();
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++)
            {
                arr[i, j] = rand.Next(0, 9);
            }
        }
        return arr;
    }
    void find_in_2dimAarr(int[,] arr, string position)
    {

        int lineLength = arr.GetLength(0);
        int columnLength = arr.GetLength(1);
        char ch_posLine = position[0];
        char ch_posColumn = position[1];
        int line_position = ch_posLine - '0' - 1;
        int column_position = ch_posColumn - '0' - 1;
        if (line_position < lineLength & column_position < columnLength)
        {
            Console.WriteLine("--> " + arr[line_position, column_position]);
        }
        else
        {
            Console.WriteLine("Такого элемента нет.");
        }
        Console.WriteLine();


    }
    void printArr2dim(int[,] arr)
    {
        int lineLength = arr.GetLength(0);
        int columnLength = arr.GetLength(1);
        for (int i = 0; i < lineLength; i++)
        {
            for (int j = 0; j < columnLength; j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }

    Console.WriteLine("Задайте размер массива:");
    Console.WriteLine("Строки:");
    int arrLine = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Столбцы:");
    int arrColumn = Int32.Parse(Console.ReadLine());
    int[,] dimensions2_array = gen_array2dim(arrLine, arrColumn);
    Console.WriteLine("Введите позицию элемента массива (например: 11):");
    string arrIndex = Console.ReadLine();
    printArr2dim(dimensions2_array);
    find_in_2dimAarr(dimensions2_array, arrIndex);

}

void task52()
{
    // Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.
    int[,] gen_array2dim(int arrayLine, int arrayColumn)
    {
        int[,] arr = new int[arrayLine, arrayColumn];
        Random rand = new Random();
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++)
            {
                arr[i, j] = rand.Next(0, 9);
            }
        }
        return arr;
    }
    void printArr2dim(int[,] arr)
    {
        int lineLength = arr.GetLength(0);
        int columnLength = arr.GetLength(1);
        for (int i = 0; i < lineLength; i++)
        {
            for (int j = 0; j < columnLength; j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }
    void averageNum(int[,] arr)
    {
        int lineLength = arr.GetLength(0);
        int columnLength = arr.GetLength(1);
        int summa = 0;
        for (int j = 0; j < columnLength; j++)
        {
            for (int i = 0; i < lineLength; i++)
            {
                summa += arr[i, j];
            }
            double averageNumber = Convert.ToDouble(summa) / Convert.ToDouble(lineLength);
            Console.Write(Math.Round(averageNumber,1) + "; ");
            summa = 0;
        }
    }
    Console.WriteLine("Задайте размер массива:");
    Console.WriteLine("Строки:");
    int arrLine = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Столбцы:");
    int arrColumn = Int32.Parse(Console.ReadLine());
    int[,] array2dim = gen_array2dim(arrLine, arrColumn);
    printArr2dim(array2dim);
    averageNum(array2dim);
}
task52();