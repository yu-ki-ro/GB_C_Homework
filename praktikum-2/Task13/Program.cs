/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 6

78 -> третьей цифры нет

32679 -> 6 */

using static System.Console;
Clear();

WriteLine("Введите число");
int num = int.Parse(ReadLine()!);
int i = 10;

if (num < 100)
    {
        WriteLine("Третей цифры нет");
        return;
    }
    else 
    {
        while (( num / i > 0 ) && (num / ( i * 10 ) != 0 ))
        {
            i = i * 10;
        }
    }
num = num / (i/100);
num = num % 10;



WriteLine(num);