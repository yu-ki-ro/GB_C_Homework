// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9


using static System.Console;
Clear();

 Write("Введите размер матрицы и диапазон значений через пробел:");
// double[] parameters = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), double.Parse);
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double [,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));

PrintMatrixArray(array);


Write("Введите позицию нужного элемента через пробел:");
string[] pos_params=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

PrintArrayPos(int.Parse(pos_params[0]), int.Parse(pos_params[1]), array);



double[,] GetMatrixArray(int rows, int colums, int minValue, int MaxValue)
{
    Random rnd=new Random();
    double[,] resultArray=new double[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i,j]=Math.Round(rnd.NextDouble()*(MaxValue+1-Math.Abs(minValue)),2);
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
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


void PrintArrayPos(int posX, int posY, double[,] inArray)
{
    if (posX >= 0 & posX <= inArray.GetLength(0))
    {
        if (posY >= 0 & posY <= inArray.GetLength(1))
        {
            WriteLine($"{inArray[posX,posY],3} ");
        }
        else WriteLine("Такого элемента в массиве нет");
    }
    else WriteLine("Такого элемента в массиве нет");
}