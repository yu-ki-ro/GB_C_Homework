/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

using static System.Console;
Clear();

WriteLine("Введите число");
int num = int.Parse(ReadLine()!);

if (num == 7 || num == 6)
{
    WriteLine("-> Да");
}
else if (num < 6)
        {
            WriteLine("-> Нет");
        }
     else 
        {
            WriteLine("В неделе 7 дней");
        }