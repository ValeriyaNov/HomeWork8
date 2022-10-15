// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значения элемента масссива: ");

string[]Str1=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix1 = FullRealNumber(int.Parse(Str1[0]), int.Parse(Str1[1]), int.Parse(Str1[2]), int.Parse(Str1[3]));
PrintMatrix(matrix1);
WriteLine();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значения элемента масссива: ");
string[]Str2=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix2 = FullRealNumber(int.Parse(Str2[0]), int.Parse(Str2[1]), int.Parse(Str2[2]), int.Parse(Str2[3]));
PrintMatrix(matrix2);
WriteLine();
if (matrix1.GetLength(1)!=matrix2.GetLength(0))
{ WriteLine("Произведение матрицы невозможно найти, так как количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
return;
}

int[,] multi=Multiplic(matrix1, matrix2);
WriteLine("Произведение матриц равно");
PrintMatrix(multi);



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

int[,] Multiplic (int[,] array1, int[,] array2 )
{
    int[,] mult=new int[array1.GetLength(0), array2.GetLength(1)];

    for(int i=0; i<mult.GetLength(0); i++)
    { 
        for (int j=0; j<mult.GetLength(1); j++)
        {
            for (int k=0; k<array2.GetLength(0); k++)
            {
            mult[i,j]+=array1[i,k]*array2[k,j]; 
            }
        }
    }    
    
    return mult;    
}

