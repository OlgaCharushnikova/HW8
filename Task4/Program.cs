// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void NewArray (int[, ,] arr)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                arr[i, j, k] = new Random().Next(10, 100);
            }
        }
    } 
}

void PrintArray3 (int[, ,] arr)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                {
                    Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
                }

            }
            Console.WriteLine();
        } 
    }
}

void FromThreeInOne(int[, ,] arr3, int[] arr1)
{
    int index = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                {
                    arr1[index] = arr3[i, j, k];
                    index++;
                }

            }
        } 
    }
}


void ReplacingDuplicateValue(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length - 1; j++)        
        {
            if (arr[j + 1] == arr[i])
            {
                arr[j + 1] = new Random().Next(10, 100);
                ReplacingDuplicateValue(arr);
            }
        }
    }
}

void FromOneInThree(int[] arr1, int[, ,] arr3)
{
    int index = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                {
                    arr3[i, j, k] = arr1[index];
                    index++;
                }

            }
        } 
    }
}


int[, ,] array3 = new int[2, 2, 2];
int[] array1 = new int[8];

NewArray(array3);
FromThreeInOne(array3, array1);
ReplacingDuplicateValue(array1);
FromOneInThree(array1, array3);
PrintArray3(array3);


