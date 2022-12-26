/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using static System.Console;
Clear();

int[] A = new int[3];
WriteLine("Введите координаты A");

for (int i = 0; i < 3; i++)
    {
        A[i] = Int32.Parse(ReadLine()!);
    }

int[] B = new int[3];
WriteLine("Введите координаты B");

for (int i = 0; i < 3; i++)
    {
        B[i] = Int32.Parse(ReadLine()!);
    }

double Dist = 0;
for (int i = 0; i < 3; i++)
    {
        Dist = Dist + Math.Pow((B[i]-A[i]),2);
    }

Dist = Math.Sqrt(Dist);

WriteLine(Dist);