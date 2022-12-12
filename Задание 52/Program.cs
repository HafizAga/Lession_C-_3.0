﻿// Task 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

ShowArray();
PrintAverageInColumns();

void PrintAverageInColumns()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }

        average = average / array.GetLength(0);
        Console.Write($"{average: 0.00}\t");
    }
}

void ShowArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}
