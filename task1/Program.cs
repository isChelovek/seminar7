// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using static System.Console;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray = GetArray(m, n);
PrintArray(mainArray);
WriteLine("-------------------------------------");
PrintArray(reversArray(mainArray));

int[,] reversArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        resultArray[0, i] = array[array.GetLength(0)-1, i];
        resultArray[array.GetLength(0)-1, i] = array[0, i];
    }
    for (int i = 1; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[i,j] =  array[i,j];
        }
    }
    return resultArray;
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