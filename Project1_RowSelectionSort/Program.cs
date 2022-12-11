// Программа, задающая двумерный массив
// и упорядочивающая по убыванию элементы каждой его строки.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] RowSelectionSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int temporary = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temporary;
                }
            }
        }
    }
    return matrix;
}
Console.WriteLine();
Console.WriteLine("Программа создания двумерного массива и его упорядочивания");
Console.WriteLine("(по убыванию элементов каждой строки).");
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
Console.WriteLine("Двумерный массив с упорядоченными по убыванию элементами строк:");
int[,] newMatrix = RowSelectionSort(matrix);
PrintMatrix(newMatrix);
Console.WriteLine();