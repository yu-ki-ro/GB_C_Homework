//ввод массива, создание нового с элементами <=3

using static System.Console;
Clear();

Write("Введите любые элементы через пробел: ");

string[] array=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

string[] array2 = GetNewArray(array);
PrintArray(array2);





string[] GetNewArray(string[] inArray)
{
    int j = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       if (inArray[i].Length <= 3 )
       {
        j++;
       }
    }
    string[] resultArray=new string[j];
    j = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       if (inArray[i].Length <= 3 )
       {
        resultArray[j] = inArray[i];
        j++;
       }
    }
    return resultArray;
}




void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (inArray[i].Length <= 3 ) Write($"{inArray[i]} ");
    }
    WriteLine();
}




/*

int m = int.Parse(parameters[0]);
int n = int.Parse(parameters[1]);
Write($"A({m},{n}) = ");
WriteLine(FuncAkkerman(m,n));

WriteLine();
PrintResultMatrix(array,array2);




int[] GetMatrixArray(int minValue, int MaxValue)
{
    int[] resultArray=new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
       
    }
    return resultArray;
}



int FuncAkkerman(int n, int m)
{
    if ( n == 0 )
        return m + 1;
    else if ((n != 0 ) && ( m ==0 ))
        return FuncAkkerman(n-1,1);
    else
        return FuncAkkerman(n - 1, FuncAkkerman(n,m-1));
}
*/




