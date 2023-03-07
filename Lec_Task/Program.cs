
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

void replText()
{
    string text = "Roll and Run ";

    string ReplaceText(string old_text, char OLD, char NEW)
    {
        string result = String.Empty;
        foreach (char c in old_text)
        {
            if (c == OLD) result = result + $"{NEW}";
            else result = result + $"{c}";
        }
        return result;
    }

    string NewText = ReplaceText(text, ' ', '_');
    Console.WriteLine(NewText);
    NewText = ReplaceText(NewText, 'R', 'T');
    Console.WriteLine(NewText);
    NewText = ReplaceText(NewText, 'a', 'U');
    Console.WriteLine(NewText);
}

// Сортировка массива (Сортировка выбором (Selection sort))

void SortArraymain()
{
int[] arr = { 3, 1, 9, 8, 1, 2, 9, 8, 1, 1, 1, 8, 2, 3, 4 };
void PrintArray(int[] array1)
{
    int length = array1.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}

void SortArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array2.Length - 1; j++)
        {
            if (array2[j] < array2[minPos]) minPos = j;
        }
        int Buf = array2[i];
        array2[i] = array2[minPos];
        array2[minPos] = Buf;
    }
}


PrintArray(arr);
SortArray(arr);
PrintArray(arr);
}

Console.WriteLine("Введите номер задачи(1 или 2):");
int tuskNum = Int32.Parse(Console.ReadLine());
if (tuskNum == 1) replText();
else if (tuskNum == 2) SortArraymain();