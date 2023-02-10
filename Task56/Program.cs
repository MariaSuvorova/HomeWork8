/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}  ");
        }
    Console.WriteLine();
    }
}

int[] SumsOfRows(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sums[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i] += matrix[i,j];
        }
    }
    return sums;
}

void PrintIndexOfMinSumsRow(int[] sums)
{
    int minSum = sums[0];
    int minIndex = 0;
    for (int i = 0; i < sums.Length; i++)
    {
        Console.WriteLine(sums[i]);
        if (sums[i] < minSum)
        {   minSum = sums[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке {minIndex}");
}

int rows = 5;
int columns = 5;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
PrintIndexOfMinSumsRow(SumsOfRows(matrix));