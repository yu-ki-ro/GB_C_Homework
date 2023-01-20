// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

Write("Введите размер массива:");
int parameters = int.Parse(ReadLine()!);
double[] array = GetArray(parameters);
PrintArray(array);
PrintSum(array);




double[] GetArray(int size)
{
    double[] resultArray=new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Math.Round(rnd.NextDouble()*(100-10)+10,2);
    }
    return resultArray;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; ++i)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

void PrintSum(double[] inArray)
{
    double min = inArray[0];
    double max = inArray[0];
    for (int i = 0; i < inArray.Length; ++i)
    {
        if (inArray[i] > max) 
        {
            max = inArray[i];
        }   
        if (inArray[i] < min)
        {
            min = inArray[i];
        } 
    }
    WriteLine($" -> {max-min}");
}