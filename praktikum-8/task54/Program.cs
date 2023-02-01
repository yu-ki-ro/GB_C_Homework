// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




using static System.Console;
Clear();

 Write("Введите размер матрицы и диапазон значений через пробел:");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int [,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));

PrintMatrixArray(array);

WriteLine();
PrintSortArray(array);



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


void PrintSortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int t = 0; t < inArray.GetLength(1)-1; t++)
            if (inArray[i,t] > inArray[i,t+1])
            {
                int H = inArray [i,t+1];
                inArray [i,t+1] = inArray[i,t];
                inArray [i,t] = H;

            }
        Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}