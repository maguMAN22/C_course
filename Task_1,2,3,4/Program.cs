void task1()
{
    // Задайте двумерный массив из целых чисел.
    // Напишите программу, которая удалит строку и столбец, 
    // на пересечении которых расположен наименьший элемент массива.
    void print_2DimArray(int[,] arr)
    {
        int arrayLine = arr.GetLength(0);
        int arrayColumn = arr.GetLength(1);
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }

    }
    int[] find_min_in2DimensionalArray(int[,] arr)
    {
        int arrayLine = arr.GetLength(0);
        int arrayColumn = arr.GetLength(1);
        int min_element = arr[0, 0];
        int min_Line = 0;
        int min_Column = 0;
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++)
            {
                if (min_element > arr[i, j])
                {
                    min_element = arr[i, j];
                    min_Line = i;
                    min_Column = j;
                }
            }
        }
        int[] minNum_Line_column = new int[] { min_element, min_Line, min_Column };
        return minNum_Line_column;
    }
    int[,] reassemble_2DimArray(int[,] arr, int mLine, int mColumn)
    {
        int arrayLine = arr.GetLength(0) - 1;
        int arrayColumn = arr.GetLength(1) - 1;
        int newi = 0;
        int newj = 0;
        int[,] newArr_2dim = new int[arrayLine, arrayColumn];
        for (int i = 0; i < arrayLine + 1; i++)
        {
            for (int j = 0; j < arrayColumn + 1; j++)
            {
                if (i != mLine && j != mColumn)
                {
                    newArr_2dim[newi, newj] = arr[i, j];
                    newj++;
                }
            }
            if (newj == arrayColumn)
            {
                newi++;
                newj = 0;
            }
        }
        return newArr_2dim;
    }

    int[,] array = { { 5, 3, 4, 4, 4 }, { 4, 2, 6, 1, 4 }, { 7, 8, 9, 4, 2 }, { 7, 8, 9, 4, 8 } };
    print_2DimArray(array);
    int[] num_Line_Column = find_min_in2DimensionalArray(array);
    Console.WriteLine("Минимальный элемент массива: " + num_Line_Column[0]);
    print_2DimArray(reassemble_2DimArray(array, num_Line_Column[1], num_Line_Column[2]));
}
void task2()
{
    // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
    // каждой строки двумерного массива.
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
    int[,] sort_2dimArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int count = 0; count < arr.GetLength(1); count++)
            {
                for (int j = count + 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, count] < arr[i, j])
                    {
                        int buffer = arr[i, count];
                        arr[i, count] = arr[i, j];
                        arr[i, j] = buffer;
                    }
                }
            }
        }
        return arr;

    }
    void print_2DimArray(int[,] arr)
    {
        int arrayLine = arr.GetLength(0);
        int arrayColumn = arr.GetLength(1);
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }

    }
    int[,] newArr = gen_array2dim(3, 3);
    print_2DimArray(newArr);
    Console.WriteLine();
    sort_2dimArray(newArr);
    print_2DimArray(newArr);
}
void task3()
{
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
    void print_2DimArray(int[,] arr)
    {
        int arrayLine = arr.GetLength(0);
        int arrayColumn = arr.GetLength(1);
        for (int i = 0; i < arrayLine; i++)
        {
            for (int j = 0; j < arrayColumn; j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }
    void find_min_row_in2DimensionalArray(int[,] arr)
    {
        int[] summaArrayRow = new int[arr.GetLength(0)];
        int summa = 0;
        int buffer = 0;
        int k = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                buffer = arr[i, j];
                summa += buffer;
            }
            summaArrayRow[k] = summa;
            summa = 0;
            k++;
        }

        int minNum = summaArrayRow[0];
        int minIndex = 0;
        for (int c = 0; c < summaArrayRow.Length; c++)
        {
            if (minNum > summaArrayRow[c])
            {
                minNum = summaArrayRow[c];
                minIndex = c;
            }
        }
        Console.WriteLine(minIndex + 1 + " строка.");
    }
    int[,] array = { { 9, 9, 2, 1 }, { 4, 9, 4, 5 }, { 3, 2, 3, 4 }, { 7, 8, 9, 4 } };
    // int[,] array = gen_array2dim(6, 3);
    print_2DimArray(array);
    find_min_row_in2DimensionalArray(array);
}
void task4()
{
    // Задайте две матрицы. Напишите программу, 
    // которая будет находить произведение двух матриц.
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
    int[,] matrixMultiplication(int[,] arr1, int[,] arr2)
    {
        if (arr1.GetLength(1) != arr2.GetLength(0))
        {
            Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй.");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        int[,] matrix_product = new int[arr1.GetLength(0), arr2.GetLength(1)];
        int result = 0;
        for (int c = 0; c < arr1.GetLength(0); c++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                for (int i = 0; i < arr2.GetLength(1); i++)
                {
                    result = arr1[c, j] * arr2[j, i];
                    matrix_product[c, i] += result;
                }
            }
        }
        return matrix_product;
    }
        void print_2DimArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) 
            {
                Console.Write(arr[i, j] + " ");          
            }
            Console.WriteLine();
        }
    }
    int[,] array1 = gen_array2dim(2,2);
    print_2DimArray(array1);
    Console.WriteLine();
    int[,] array2 = gen_array2dim(2,2);
    print_2DimArray(array2);
    Console.WriteLine();
    print_2DimArray(matrixMultiplication(array1,array2));

}

