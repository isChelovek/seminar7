// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

using System;
using static System.Console;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray = GetArray(m, n);
PrintArray(mainArray);


int[] Unique = countUnique(mainArray);
int[] numsCount = countRepeatNums(mainArray, Unique);

int[] countRepeatNums(int[,] array, int[]uniqueNums)
{
    int[] result = new int[uniqueNums.GetLength(0)];
    for (int i = 0; i < uniqueNums.GetLength(0); i++)
    {
        result[i] = SerchElInArray(array, uniqueNums[i]);
    }
    return result;
}



for (int i = 0; i < Unique[0]; i++)
{
    WriteLine($"{Unique[i+1]} встречается {numsCount[i+1]}");
}

int SerchElInArray(int[,] array,int El)
{
    int Count=0;
    for(int i=0;i<array.GetLength(0);i++)
        for(int j=0;j<array.GetLength(0);j++)
        {
            if(El==array[i,j]) Count++;
        }
    return Count;
}

int[] countUnique (int[,] array)
{
    int count = 1;
    int[] uniqueArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (findEl(uniqueArray, array[i,j]))
            {
                uniqueArray[count] = array[i,j];
                count++;
            }
        }
    }
    uniqueArray[0] = count;
    return uniqueArray;
}

bool findEl (int[] array, int find)
{
    bool result = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i]==find) result = false;
    }
    return result;
}


int [,] GetArray (int m, int n)
{
    int [,] result=new int [m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(0,2);
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