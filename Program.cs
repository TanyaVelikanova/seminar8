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
            sumMin =+ array[i,j]; 
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
            sumRow =+ array[i,j];
        }
        if (sumRow < sumMin)
        {
            sumMin=sumRow;
            RowMinSum=i;
        }
    }
    return RowMinSum;
}

//Залача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение 
//двух матриц.

int rows1 = new Random().Next(2,3);
int columns1 = new Random().Next(2,3);
int[,] array1 = new int[rows1, columns1];
int rows2 = new Random().Next(2,3);
int columns2 = new Random().Next(2,3);
int[,] array2 = new int[rows2, columns2];

CreateArray(array1);
CreateArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);

if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] array3 = MultiplyMatrix(array1, array2);
    Console.WriteLine("Произведение 2-х матриц");
    PrintArray(array3);
}
else Console.WriteLine("Не выполняется условие для произведения");

 
int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{  
    int[, ] arrayresult = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {   
            int tmpSum = 0;
            for (int k = 0; k < array2.GetLength(0); k++)
            {
               tmpSum = tmpSum + (array1[i,k] * array2[k,j]);                     
            }
             arrayresult[i,j] = tmpSum ; 
        }
    }
    return arrayresult;
}
 

