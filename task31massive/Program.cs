﻿// Задать массив из 8 элементов и вывести их на экран

int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9999999, 9999999);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"{position + 1} {col[position]}");
        position++;
    }
}

FillArray(array);
PrintArray(array);