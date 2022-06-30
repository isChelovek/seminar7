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

for (int i = 0; i < Unique.GetLength(0); i++)
{
    WriteLine(Unique[i]);
}
int[] countArray2 = new int[Unique.GetLength(0)];


for (int i = 0; i < Unique.GetLength(0); i++)
{
    countArray2[i] = SerchElInArray(mainArray, Unique[i]);
}

for (int i = 0; i < Unique.GetLength(0); i++)
{
    WriteLine($"{Unique[i]} встречается {countArray2[i]}");
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
    int count = 0;
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