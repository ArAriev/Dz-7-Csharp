// 6. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($" {matr[i, j]}");
                }
            Console.WriteLine();
        }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 10); 
                }
        }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
            Console.WriteLine(array[j, i]);
        }
    Console.WriteLine($"Среднее арифметическое {i+1} столбца равно {sum/m}");
    sum = 0;
}

Console.WriteLine();