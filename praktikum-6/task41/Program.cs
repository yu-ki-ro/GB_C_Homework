// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


using static System.Console;
Clear();

Write("Введите числа через пробел:");
string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

PrintArray(parameters);
PrintCount(parameters);




void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; ++i)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

void PrintCount(string[] inArray)
{
    int Count = 0;
    for (int i = 0; i < inArray.Length; ++i)
    {
        if (Convert.ToInt32(inArray[i]) > 0) Count = Count + 1;
    }
    Write($" -> {Count}");
}