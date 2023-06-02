// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralFilling (int[,] arr)
{
    int k = 1;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int i = 0;
        arr[i, j] = k;
        k++;
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int j = 3;
        arr[i, j] = k;
        k++;
    }
    for (int j = arr.GetLength(0) - 2; j >= 0; j--)   
    {
        int i = 3; 
        arr[i, j] = k;
        k++;
    }
    for (int i = arr.GetLength(0) - 2; i > 0; i--)
    {
        int j = 0;
        arr[i, j] = k;
        k++;
    } 
    for (int j = arr.GetLength(0) - 3; j < arr.GetLength(0) - 1; j++)   
    {
        int i = 1; 
        arr[i, j] = k;
        k++;
    }
    for (int j = arr.GetLength(0) - 2; j >= arr.GetLength(0) - 3; j--)   
    {
        int i = 2; 
        arr[i, j] = k;
        k++;
    }
}

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
            Console.Write($"0{arr[i,j]} ");
            }
            else
            {
            Console.Write($"{arr[i,j]} ");    
            }
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
SpiralFilling(array);
PrintArray(array);