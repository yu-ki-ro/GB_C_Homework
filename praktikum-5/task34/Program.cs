// Задача 34: Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();

Write("Введите размер массива:");
int parameters = int.Parse(ReadLine()!);
int[] array = GetArray(parameters);
PrintArray(array);
PrintChetnChislo(array);




int[] GetArray(int size)
{
    int[] resultArray=new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(100, 999);
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

void PrintChetnChislo(int[] inArray)
{
    int Chetn = 0;
    for (int i = 0; i < inArray.Length; ++i)
    {
        if (inArray[i] % 2 != 1) Chetn = Chetn + 1;
    }
    Write($" -> {Chetn}");
}