// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SumElementsLine(int[,] arr2, int[] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j ++)
        {
            sum = sum + arr2[i, j];
        }
        arr1[i] = sum;
        sum = 0;
    }
}

int MinimalElement(int[] arr)
{ 
    int i = 0;
    int min = arr[i];
    int mini = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            mini = i;
        }
    }
     return mini + 1;
}


Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[m, n];
int[] array1 = new int[m];
NewArray(array2);
PrintArray(array2);
Console.WriteLine();
SumElementsLine(array2, array1);
Console.Write($"Номер строки с наименьшей суммой элементов: {MinimalElement(array1)} строка");