// В матрице чисел найти сумму элементов главной диагонали.

int[,] arr = new int[5, 5];
Random rand = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }

}
void PrintMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindSumD(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

FillArray(arr);
PrintMassiv(arr);
int sum = FindSumD(arr);
Console.WriteLine($"Сумма главной диагоняли {sum}");