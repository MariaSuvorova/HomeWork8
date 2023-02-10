/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] InitMatrix(int rows, int columns, int param3)
{
    int[,,] matrix = new int[rows, columns, param3];
    Random rnd = new Random();
    Dictionary<int,int> MatrixElements = new Dictionary<int,int>();  
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int n = 0; n < param3; n++)
            {
                matrix[i,j,n] = rnd.Next(10,100);
                while (MatrixElements.ContainsKey(matrix[i,j,n]))
                {
                    matrix[i,j,n] = rnd.Next(10, 100);
                }
                MatrixElements.Add(matrix[i,j,n], 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                Console.Write($"{matrix[i,j,n]}({i},{j},{n}) ");
            }
            
        }
    Console.WriteLine();
    }
}

int rows = 3;
int columns = 3;
int param3 = 3;
int[,,] unicElementMatrix = InitMatrix(rows,columns,param3);
PrintMatrix(unicElementMatrix);