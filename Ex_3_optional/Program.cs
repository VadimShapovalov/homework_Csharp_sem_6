// Необязательная задача 6-го семинара
int[,] CreateAndPrintMatrix(int row, int col)
{
    int[,] arr = new int[row, col];
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("end");
    return arr;
}
void CreateAndPrintNewMatrix(int[,]arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int[,] arr2 = new int[row, col];
    if (row > 1 && col > 1)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (i == row - 1 && j < col - 1 && j > 0) arr2[i, j] = arr[i - 1, j] + arr[0, j] + arr[i, j - 1] + arr[i, j + 1];
                if (i == 0 && j < col - 1 && j > 0) arr2[i, j] = arr[row - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, j + 1];
                if (j == col - 1 && i < row - 1 && i > 0) arr2[i, j] = arr[i - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, 0];
                if (j == 0 && i < row - 1 && i > 0) arr2[i, j] = arr[i - 1, j] + arr[i + 1, j] + arr[i, col - 1] + arr[i, j + 1];
                if (i == row - 1 && j == col - 1) arr2[i, j] = arr[i - 1, j] + arr[0, j] + arr[i, j - 1] + arr[i, 0];
                if (i == 0 && j == col - 1) arr2[i, j] = arr[row - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, 0];
                if (j == 0 && i == 0) arr2[i, j] = arr[row - 1, j] + arr[i + 1, j] + arr[i, col - 1] + arr[i, j + 1];
                if (j == 0 && i == row - 1) arr2[i, j] = arr[i - 1, j] + arr[0, j] + arr[i, col - 1] + arr[i, j + 1];
                if (i < row - 1 && i > 0 && j < col - 1 && j > 0) arr2[i, j] = arr[i - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, j + 1];
                Console.Write(arr2[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    if (row == 1 && col > 1)
    {
        int i = 0;
        for (int j = 0; j < col; j++)
        {
            if (j < col - 1 && j > 0) arr2[i, j] = arr[0, j] * 2 + arr[i, j - 1] + arr[i, j + 1];
            if (j == 0) arr2[i, j] = arr[i, j] * 2 + arr[i, col - 1] + arr[i, j + 1];
            if (j == col - 1) arr2[i, j] = arr[i, j] * 2 + arr[i, j - 1] + arr[i, 0];
            Console.Write(arr2[i, j] + "\t");
        }
    }
    if (row > 1 && col == 1)
    {
        int j = 0;
        for (int i = 0; i < row; i++)
        {
            if (i < row - 1 && i > 0) arr2[i, j] = arr[i - 1, j] + arr[i + 1, j] + arr[i, j] * 2;
            if (i == 0) arr2[i, j] = arr[row - 1, j] + arr[i + 1, j] + arr[i, j] * 2;
            if (i == row - 1) arr2[i, j] = arr[i - 1, j] + arr[0, j] + arr[i, j] * 2;
            Console.WriteLine(arr2[i, j] + "\t");
        }
    }
    if (row == 1 && col == 1)
    {
        arr2[0, 0] = arr[0, 0] * 4;
        Console.Write(arr2[0, 0] + "\t");
    }
}
Console.WriteLine("Введите количество строк в Вашей матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в Вашей матрице: ");
int col = Convert.ToInt32(Console.ReadLine());
CreateAndPrintNewMatrix(CreateAndPrintMatrix(row, col));
