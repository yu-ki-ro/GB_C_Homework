/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

using static System.Console;
Clear();

WriteLine("Введите число N");
int N = int.Parse(ReadLine()!);
int i = 1;
int stepen = 3;

while ( i <= N )
    {
        Write($"{Math.Pow(i, stepen)}, ");
        i++;
    }