// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplicationMatrices(int[,] arr1, int[,] arr2, int[,] arr3)
{
    arr3[0, 0] = (arr1[0, 0] * arr2[0, 0]) + (arr1[0, 1] * arr2[1, 0]);
    arr3[0, 1] = (arr1[0, 0] * arr2[0, 1]) + (arr1[0, 1] * arr2[1, 1]);
    arr3[1, 0] = (arr1[1, 0] * arr2[0, 0]) + (arr1[1, 0] * arr2[1, 0]);
    arr3[1, 1] = (arr1[1, 0] * arr2[0, 1]) + (arr1[1, 1] * arr2[1, 1]);
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] multiplicationMatrix = new int[2, 2];
NewArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
NewArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
MultiplicationMatrices(matrix1, matrix2, multiplicationMatrix);
PrintArray(multiplicationMatrix);