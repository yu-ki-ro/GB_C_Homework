﻿// Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

int [] arr = GetArray(8);

Write("[ ");
PrintArray(arr);
WriteLine("]");


int [] GetArray(int size)
    {
        int [] array = new int [size];
        for (int i = 0 ; i < array.Length; i++)
        {
            array[i] = new Random().Next(99);
        }
        return array;
    }

void PrintArray (int [] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Write($"{array[i]} ");
        }
    }