﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
using static System.Console;
Clear();

WriteLine("Enter num: ");
float num = float.Parse(ReadLine()!);
if (num % 2 == 1)
    {
        WriteLine("Not even");
    }
    else
    {
        WriteLine("Even");
    }