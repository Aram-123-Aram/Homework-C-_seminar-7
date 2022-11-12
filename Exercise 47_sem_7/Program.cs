/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5   7    -2    -0,2
1    -3,3   8    -9,9
8     7,8  -7,1   9 */
int m, n;
Console.Write("Enter the size of raws of array: m= ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Enter the size of columns of array: n= ");
int.TryParse(Console.ReadLine()!, out n);

double[,] matrix = new double[m, n];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {matrix[i, j] = Math.Round(new Random().NextDouble()*10, 1); Console.Write($"{matrix[i,j]}       ");}
    Console.WriteLine();
}


