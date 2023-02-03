// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

Write("Введите число m и число n через пробел: ");

string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int m = int.Parse(parameters[0]);
int n = int.Parse(parameters[1]);
Write($"A({m},{n}) = ");
WriteLine(FuncAkkerman(m,n));



int FuncAkkerman(int n, int m)
{
    if ( n == 0 )
        return m + 1;
    else if ((n != 0 ) && ( m ==0 ))
        return FuncAkkerman(n-1,1);
    else
        return FuncAkkerman(n - 1, FuncAkkerman(n,m-1));
}