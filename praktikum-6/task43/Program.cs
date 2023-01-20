// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using static System.Console;
Clear();

Write("Введите числа b1, k1, b2, k2, через пробел:");
double[] parameters = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), double.Parse);

PrintArray(parameters);
PrintCrosline(parameters);




void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; ++i)
    {
        Write($"{inArray[i]},");
    }
    WriteLine($"{inArray[inArray.Length-1]}] ");
}

void PrintCrosline(double[] inArray)
{
    var x = -(inArray[0]- inArray[2])/(inArray[1]-inArray[3]);
    var y = inArray[1]*x+inArray[0];

    WriteLine($"Пересечение в точке: ({x};{y})");
}