Console.Write("Въведи брой редове: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Въведи брой колони: ");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"[{i},{j}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nГотовата матрица е:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}                

}
