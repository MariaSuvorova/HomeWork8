/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int value = 0;
    for (int loop = 0; loop < (rows/2+1); loop++)
    {
        for (int j = 0+loop; j < columns-loop; j++)
        { 
            int i = 0 + loop;
            value += 1;
            matrix[i,j] = value;
        }
        for (int i = 1 + loop; i < rows - loop; i++)
        {
            int j = columns-1-loop;
            value += 1;
            matrix[i,j] = value;
        }
        for (int j = columns-2-loop; j >= 0 + loop; j--)
        {
            int i = rows-1 - loop;
            value += 1;
            matrix[i,j] = value;
        }
        for (int i = rows-2-loop; i > 0 + loop; i--)
        {
            int j = 0 + loop;
            value += 1;
            matrix[i,j] = value;
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
            Console.Write($"{matrix[i,j].ToString("D2")}  ");
        }
    Console.WriteLine();
    }
}

int rows = GetNumber("Введите размер массива:");
int columns = rows;
int[,] spiralMatrix = InitMatrix(rows,columns);
PrintMatrix(spiralMatrix);