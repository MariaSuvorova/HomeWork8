/*Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
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

int[,] ProductOfMatrix(int[,] matrix1, int[,] matrix2)
{
int[,] resultMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int n = 0; n < matrix2.GetLength(0); n++)
            {
                resultMatrix[i,j] += matrix1[i,n] * matrix2[n,j];  
            }
        }
    }
    return resultMatrix;
}

int row1 = 2;
int row2 = 2;
int column1 = 2;
int column2 = 2;
int[,] matrix1 = InitMatrix(row1,column1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = InitMatrix(row2,column2);
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(ProductOfMatrix(matrix1, matrix2));