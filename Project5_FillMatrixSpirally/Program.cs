// Программа, заполняющая спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] FillMatrixSpirally(int n)
{
    int[,] matrix = new int[n, n];
    int number = 1;
    for (int i = 1; i < n; i++)
    {
        for (int j = i - 1; j < n - i + 1; j++)
        {
            matrix[i - 1, j] = number++;
        }
        for (int j = i; j < n - i + 1; j++)
        {
            matrix[j, n - i] = number++;
        }
        for (int j = n - i - 1; j >= i - 1; j--)
        {
            matrix[n - i, j] = number++;
        }
        for (int j = n - i - 1; j >= i; j--)
        {
            matrix[j, i - 1] = number++;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write("{0,3}", "0" + matrix[i, j]);
            else
                Console.Write("{0,3}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Программа заполнения массива 4 на 4 спирально.");
Console.WriteLine();
int n = 4;
int[,] matrix = FillMatrixSpirally(n);
PrintMatrix(matrix);
Console.WriteLine();