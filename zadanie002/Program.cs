//2. Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = m + n;
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0;  i< matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Двумерный массив заполненный по следующим правилом  A[mn] = m+n: ");
PrintArray(matrix);
