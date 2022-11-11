//1. Показать двумерный массив размером m×n заполненный вещественными числами

void PrintMass(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMass(double[,] massiv, int max, int min)
{
    Random random = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = (random.NextDouble() + random.Next(min, max));
        }
    }
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] array = new double[m, n];
FillMass(massiv: array, max: 10, min: -10);
PrintMass(array);
