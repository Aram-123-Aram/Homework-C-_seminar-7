/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int[,] matrix = new int[5, 7];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {matrix[i,j] = new Random().Next(10); Console.Write($"{matrix[i,j]}  ");}
    Console.WriteLine();
}
Console.Write("Enter the raw position of element of matrix: k= ");
int.TryParse(Console.ReadLine(), out int k);
Console.Write("Enter the column position of element of matrix: m= ");
int.TryParse(Console.ReadLine(), out int m);

if(k<5 && m<7) {Console.Write($"Такой элемент в массиве есть и равно--->  {matrix[k,m]}");}
else {Console.Write("-> такого числа в массиве нет");}
