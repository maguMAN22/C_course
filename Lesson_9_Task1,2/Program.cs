void Task1()
{
    // Задайте значения M и N. Напишите программу, которая выведет все чётные
    // натуральные числа в промежутке от M до N с помощью рекурсии.
    int firstNum = Int32.Parse(Console.ReadLine());
    int secondNum = Int32.Parse(Console.ReadLine());
    if (firstNum % 2 != 0) firstNum++;
    FindAndPrintEvenNumber(firstNum, secondNum);

    void FindAndPrintEvenNumber(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber - 1) Console.WriteLine(firstNumber);
        else
        {
            Console.Write(firstNumber + ", ");
            FindAndPrintEvenNumber(firstNumber + 2, secondNumber);
        }
    }

}

void Task2()
{
    // Задайте значения M и N.Напишите программу, которая найдёт сумму
    // натуральных элементов в промежутке от M до N с помощью рекурсии.
    int firstNum = Int32.Parse(Console.ReadLine());
    int secondNum = Int32.Parse(Console.ReadLine());
    int count = firstNum;
    int FindSummaFromFirstNumToSecondNum(int counter, int firstNumber, int secondNumber) =>
        counter == secondNumber ?
        firstNumber :
        FindSummaFromFirstNumToSecondNum(++counter, firstNumber + counter, secondNumber);

    Console.WriteLine(FindSummaFromFirstNumToSecondNum(count, firstNum, secondNum));
}


