// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = new Random().Next(3,4);
int columns = new Random().Next(3,4);
int[,] array = new int[rows, columns];

CreateArray(array);
PrintArray(array);
Console.WriteLine("Вывод отсортированного массива");
SortRowsArray(array);
PrintArray(array);

void SortRowsArray(int[,] array)
{
    int tempStorageEl = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1-j; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                tempStorageEl = array[i,k];
                array[i,k] = array[i,k+1];
                array[i,k+1] = tempStorageEl;
                }
            }
        }
    }
}
    
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
         Console.WriteLine();
    }
}

//Задача 2.  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

int sumMin = GetSumFirstRow(array);
Console.WriteLine($"строка с наименьшей суммой элементов - {GetRowMinSum(array, sumMin)}");

int GetSumFirstRow(int [,] array)
{
    int sumMin = 0;
    for (int i = 0, j = 0; j < array.GetLength(1); j++)
        {
            sumMin = sumMin + array[i,j]; 
        }
return sumMin;
}

int GetRowMinSum(int [,] array, int sumMin)
{   
    int RowMinSum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {   
        int sumRow = 0;
       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i,j];
        }
        if (sumRow < sumMin)
        {
            sumMin=sumRow;
            RowMinSum=i;
        }
    }
    return RowMinSum;
}


