// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




using static System.Console;
Clear();

 Write("Введите диапазон значений 1ой матрицы через пробел:");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int [,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));

PrintMatrixArray(array);

 Write("Введите диапазон значений 2ой матрицы через пробел:");
string[] parameters2=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int [,] array2 = GetMatrixArray(int.Parse(parameters2[0]),int.Parse(parameters2[1]));

PrintMatrixArray(array2);


WriteLine();
PrintResultMatrix(array,array2);



int[,] GetMatrixArray(int minValue, int MaxValue)
{
    Random rnd=new Random();
    int rows = 2;
    int colums = 2;
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


void PrintResultMatrix(int[,] inArray, int [,] inArray2)
{
    int[,] resultArray=new int[inArray.GetLength(0),inArray2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j]=0;
            for (int n = 0; n < inArray.GetLength(1); n++)
            {
                resultArray[i,j] += inArray[i,n] * inArray2[n,j];
            }
            Write($"{resultArray[i,j],3} "); 
        }
        
        WriteLine();
    }
}