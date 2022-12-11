// Программа, задающая прямоугольный двумерный массив
// и определяющая строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка.
bool IsIncorrectInput(int number)
{
    return number < 1;
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[] GetRowElementSums(int[,] matrix, int m)
{
    int[] rowElementSums = new int[m];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowElementSums[i] += matrix[i, j];
        }
    return rowElementSums;
}
int GetMinimumSumIndex(int[] rowElementSums)
{
    int minimumSum = rowElementSums[0];
    int minimumSumIndex = 0;
    for (int i = 0; i < rowElementSums.Length; i++)
    {
        if (rowElementSums[i] < minimumSum)
        {
            minimumSum = rowElementSums[i];
            minimumSumIndex = i;
        }
    }
    return minimumSumIndex;
}
Console.WriteLine();
Console.WriteLine("Программа определения строки матрицы с наименьшей суммой элементов.");
Console.WriteLine("(Программа позволяет задать прямоугольный двумерный массив.)");
Console.WriteLine();
Console.WriteLine("Задайте размер двумерного массива.");
InputM:
Console.Write("Введите значение размерности m (число строк): ");
int m = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(m))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputM;
}
InputN:
Console.Write("Введите значение размерности n (число столбцов): ");
int n = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(n))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputN;
}
int[,] matrix = new int[m, n];
FillMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Двумерный массив:");
PrintMatrix(matrix);
Console.WriteLine();
int[] rowElementSums = GetRowElementSums(matrix, m);
Console.WriteLine($"Номер строки матрицы с наименьшей суммой элементов: {GetMinimumSumIndex(rowElementSums) + 1} строка.");
Console.WriteLine();