// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


using System;
using static System.Console;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray = GetArray(m, n);

if (mainArray.GetLength(0) == mainArray.GetLength(1))
{
    PrintArray(mainArray);
    WriteLine("--------------------");
    arrayReversColums2(mainArray);
    PrintArray(mainArray);
}
else
{
    WriteLine("Размерность не правильная");
}

int[,] arrayReversColums(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            resultArray[j,i] = array[i,j];
        }
    }
    return resultArray;
}

void arrayReversColums2(int[,] array)
{
    int tempInt = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0)/2; j++)
        {
            tempInt    = array[j,i];
            array[j,i] = array[i,j];
            array[i,j] = tempInt;
        }
    }
}

int [,] GetArray (int m, int n)
{
    int [,] result=new int [m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(-10,11);
        }
    }
    return result;
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Write($"{result[i, j]} \t ");
        }
        WriteLine();
    }
}