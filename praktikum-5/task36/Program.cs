// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Введите размер массива:");
int parameters = int.Parse(ReadLine()!);
int[] array = GetArray(parameters);
PrintArray(array);
PrintSum(array);




int[] GetArray(int size)
{
    int[] resultArray=new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(-100, 100);
    }
    return resultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; ++i)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

void PrintSum(int[] inArray)
{
    int Sum = 0;
    for (int i = 0; i < inArray.Length; ++i)
    {
        if (i % 2 == 1) Sum = Sum + inArray[i];
    }
    Write($" -> {Sum}");
}