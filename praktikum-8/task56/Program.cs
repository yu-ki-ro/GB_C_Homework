// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




using static System.Console;
Clear();

 Write("Введите размер матрицы и диапазон значений через пробел:");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int [,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));

PrintMatrixArray(array);

WriteLine();
PrintMinSumArray(array);



int[,] GetMatrixArray(int rows, int colums, int minValue, int MaxValue)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i,j]=rnd.Next(minValue, MaxValue);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}


void PrintMinSumArray(int[,] inArray)
{
    int[] resultArray=new int[inArray.GetLength(0)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            resultArray[i] = resultArray[i] + inArray[i,j];    
            
            
            
        }
        //Write($"{resultArray[i],3} ");
        //WriteLine();
    }
    int min = resultArray[0];
    int min_i = 1;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if ( resultArray[i] < min )
            {
                min = resultArray[i];
                min_i = i+1;
            }
    }
    WriteLine($"Мин сумма в {min_i} строке");
}