/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7*/

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
            Console.Write($"{matrix[i,j]} ");
        }

    Console.WriteLine();
    }
}

(int, int) GetElementIndex(string line)
{
    string[] arrayOfChar = line.Split(",");

    int rowIndex = Convert.ToInt32(arrayOfChar[0]);
    int columnIndex = Convert.ToInt32(arrayOfChar[1]);
    
    return (rowIndex, columnIndex);
}

var m = 3;
var n =4;
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("Введите позицию искомого элемента (через ,)");
string indexInLine = Console.ReadLine();
(int row, int column) = GetElementIndex(indexInLine);
if (row < m && column < n)
    Console.WriteLine($"{matrix[row,column]}");
else
    Console.WriteLine("Такого элемента нет");
