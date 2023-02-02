// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




using static System.Console;
Clear();

int [,,] array = GetMatrixArray(10,99);

PrintMatrixArray(array);

WriteLine();



int[,,] GetMatrixArray(int minValue, int MaxValue)
{
    Random rnd=new Random((DateTime.Now.Millisecond));
    int rows = 2;
    int colums = 2;
    int cub = 2;
    int[,,] resultArray=new int[rows,colums,cub];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < cub; k++)
            {
                resultArray[i,j,k]=rnd.Next(minValue, MaxValue);
            }
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
            Write($"{inArray[i,j,k],3}{(i,j,k)} "); 
            }
        }
        WriteLine();
    }
}


