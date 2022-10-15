// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
//Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значения элемента масссива: ");

string[]Str=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix1 = FullRealNumber(int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]), int.Parse(Str[3]));
PrintMatrix(matrix1);
WriteLine();
int[] tet=SumStr(matrix1);
Min(tet);



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

int[] SumStr (int[,]array)
{
    int sum=0;
    int count=0;
    int[] result=new int[array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j<array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
            
        }
        
        result[count]=sum;
        count++;
        sum=0;
    }    
    return result;    
}

void Min (int[] array01)    
{
    int min=array01[0];
    int index=0;
for (int i=0; i<array01.Length; i++)
{
if (array01[i]<min) 
    min=array01[i]; 
}
for (int i=0; i<array01.Length; i++)
{
    if (array01[i]==min)
    WriteLine($" Строка с наименьшей сумммой элементов: {i}");
}
}


