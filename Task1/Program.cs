﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void NewArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
      
    }
}

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void OrderingElements(int[,] arr)
{ 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int k = 0;
        while (k < arr.GetLength(1))
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr [i, j + 1] > arr[i, j])
                    {
                    (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
                    }
                }
            k++;
        }
    }
}


Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

NewArray(array);
PrintArray(array);
Console.WriteLine();
OrderingElements(array);
PrintArray(array);



