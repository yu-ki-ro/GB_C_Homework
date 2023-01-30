// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();

 Write("Введите размер матрицы и диапазон значений через пробел:");
// double[] parameters = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), double.Parse);
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double [,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));

PrintMatrixArray(array);

WriteLine();
PrintArrayMath(array);



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


void PrintArrayMath(double[,] inArray)
{
    double[] resultArray=new double[inArray.GetLength(1)];
    for ( int i = 0; i < inArray.GetLength(1); i++ )
    {
        for ( int j = 0; j < inArray.GetLength(0); j++ )
        {
            resultArray[i]=resultArray[i]+inArray[j,i];
        }
        // WriteLine($"{resultArray[i],3} ");
        resultArray[i] /= (inArray.GetLength(0));
        Write($"{resultArray[i],3} ");
    }

}