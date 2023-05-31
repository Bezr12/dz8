//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray2DRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
        }
        Console.WriteLine();
    }
}

void SortLow (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i, k + 1])
                {
                    int res = array[i, k + 1];
                    array[i, k + 1] = array[i,k];
                    array[i,k] = res;
                }
            }
        }
    }
}

int[,] array = new int [3,4];
FillArray2DRandom(array);
PrintArray2D(array);
SortLow(array);
Console.WriteLine();
PrintArray2D(array);
