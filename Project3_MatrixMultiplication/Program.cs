// Программа, находящая произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultiplicateMatrix(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
Console.WriteLine();
Console.WriteLine("Программа создания матрицы произведением двух заданных матриц");
Console.WriteLine("(для двух матриц размера n*n).");
Console.WriteLine();
Console.WriteLine("Задайте размер матриц.");
InputN:
Console.Write("Введите значение размерности n (число строк, число столбцов): ");
int n = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(n))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputN;
}
int[,] matrixA = new int[n, n];
FillMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixA);
int[,] matrixB = new int[n, n];
FillMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
PrintMatrix(MultiplicateMatrix(matrixA, matrixB));
Console.WriteLine();