/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using static System.Console;

Clear();

WriteLine("Enter num a: ");
int a = int.Parse(ReadLine());

WriteLine("Enter num b: ");
int b = int.Parse(ReadLine());

WriteLine("Enter num c: ");
int c = int.Parse(ReadLine());

if (a > b)
    {
        if (a > c)
            {
                WriteLine($"max = {a}");
            }
        else 
            {
                WriteLine($"max = {c}");
            }
    }
    else if (b > c)
            {
                WriteLine($"max = {b}");
            }
        else
            {
                WriteLine($"max = {c}");
            }    