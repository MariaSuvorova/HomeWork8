/*Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void SortOfRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i,j] < matrix[i,j+1])
                {
                    int temp = matrix[i,j+1];
                    matrix[i,j+1] = matrix[i,j];
                    matrix[i,j] = temp;
                }
            }
        }
    }
}

int rows = 5;
int columns = 5;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
SortOfRows(matrix);
Console.WriteLine("Отсортированная матрица:");
PrintMatrix(matrix);