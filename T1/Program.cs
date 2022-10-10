// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значения элемента масссива: ");

string[]Str=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix1 = FullRealNumber(int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]), int.Parse(Str[3]));
PrintMatrix(matrix1);
WriteLine();
Sort(matrix1);
PrintMatrix(matrix1);



int[,] FullRealNumber (int row, int col, int min, int max)
{
   int[,] result= new int [row, col];

   for (int i=0; i<result.GetLength(0); i++) 
   {
    for (int j=0; j<result.GetLength(1); j++)
    
    result[i,j]=new Random().Next(min, max+1);

   }
   return result;
}

void PrintMatrix (int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} \t");
        }
        WriteLine();
    }
}

void Sort (int[,]array)
{
    
    for(int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int k=j+1; k<array.GetLength(1); k++)
            {
           if(array[i,j]<array[i,k])
           {
            int temp=array[i,j];
            array[i,j]=array[i,k];
            array[i,k]=temp;
           }
            }
        }        
    }
    
}