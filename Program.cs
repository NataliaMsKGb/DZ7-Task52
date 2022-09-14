// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[ , ] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   //row 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

          for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j] ,3},");
            // else Console.Write($"{matrix[i, j], 3} ");
        Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i,j] ,3}," : $"{matrix[i, j], 3}");

        }


        Console.WriteLine("]");
    }
}


double SredneeCol(int[,] matrix)
{
    int summa = 0;
    double srednee  = 0;
    {for (int i = 0; i < matrix.GetLength(0); i++)
    //summa = matrix[i,j];
    { 
         for (int j = 0; j < matrix.GetLength(1); j++)
         srednee = summa/j;
          }
    }
    return srednee;

}
int[,] matrix2D = CreateMatrixRndInt(7, 4, 2, 9);
PrintMatrix(matrix2D);
Console.WriteLine($"Сумма столбцов: {SredneeCol(matrix2D)}");







// void SredneeCol (int[,] matrix)
// {
// for (int j = 0; i < matrix.GetLength(0); j++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//     matrix[i,j] *= matrix[i,j];
//    }
// }
// }



