/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] matrix = new int[4, 6];

void FullMatrix(int[,] array)
{
   for(int i=0; i<array.GetLength(0); i++)
   {
    for(int j=0; j<array.GetLength(1); j++)
    {array[i, j] = new Random().Next(10);}
   }
}

void ShowMatrix(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {Console.Write($"{array[i, j]}    "); }
    Console.WriteLine();
    }
}


FullMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine();

void FindSrAr(int[,] array)
{double Sr_Ar = 0;
double Sum_Column = 0;
int j;

for(int i=0; i<array.GetLength(1); i++)
{for(j=0; j<array.GetLength(0); j++)
{Sum_Column = Sum_Column + array[j, i];}
Sr_Ar = Sum_Column/j;
Console.Write($"{Sr_Ar}; "); Sum_Column = 0;
}
Console.Write(" <-Среднее арифметическое каждого столбца");
}

FindSrAr(matrix);