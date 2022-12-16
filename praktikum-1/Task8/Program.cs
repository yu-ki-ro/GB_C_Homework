/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

using static System.Console;
Clear();

WriteLine("Enter N: ");
float N = float.Parse(ReadLine()!);
int i = 1;
while (i <= N)
    if (i % 2 == 1)
        i++;
    else 
    {
        Write($"{i} ");
        i++;
    }
WriteLine();