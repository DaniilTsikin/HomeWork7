//В двумерном массиве n×k заменить четные элементы на противоположные.
int[,] massiv = new int[5, 6];
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
            if(array[i, j] % 2 == 0)
            {
                array[i, j] *= -1;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(massiv);
PrintMassiv(massiv);
