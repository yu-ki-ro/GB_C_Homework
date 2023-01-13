// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum=GetSum(number);
WriteLine($"SUM  = {sum}");





int GetSum(int A)
{
    int i=0;
    while (A != 0)
    {
        i = i + A % 10;
        A = A / 10;
    }
    return i;
}