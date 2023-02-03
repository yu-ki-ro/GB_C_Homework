//  Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int j = 8;
double Fatorial (int n)
{
    if (n==1) return 1;
    else  return n;
for (int i = j; i != 0; i--)
{
    Console.Write($"{i}!: ");
    Console.WriteLine(Fatorial(i));
}