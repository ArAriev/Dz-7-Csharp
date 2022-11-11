// 8. В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sumMinString = int.MaxValue;
int stringMinSum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) sum = sum + array[i, j];
    if (sum < sumMinString)
    {
        sumMinString = sum;
        stringMinSum = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов {stringMinSum} = {sumMinString}");