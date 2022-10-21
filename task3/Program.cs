//Задача 3: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение 
// по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int Prompt()
{
    System.Console.WriteLine("Write number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a; 
}

int[,] RandomMatrixFill(int line, int column)
{
    int[,] matrix = new int [line, column];
    Random rnd = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
    
}
void PrintMatrix(int[,] matrix, int line, int column)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            System.Console.Write($"{matrix[ i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Это наша матрица");
}
int SumOfMaxLine(int [,] matrix, int line, int column)
{
    int sum = 0;
    int max = -1;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if( max < matrix[i,j]) max = matrix[i,j];
        }
        sum += max;
        max = -1;
    }
    System.Console.WriteLine($"Сумма максимальных по строкам {sum}");
    return sum;
}
int SumOfMinColumn(int [,] matrix, int line, int column)
{
    int sum = 0;
    int min = 10;
    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < line; j++)
        {
            if( min > matrix[j,i]) min = matrix[j,i];
        }
        sum += min;
        min = 10;
    }
    System.Console.WriteLine($"Сумма минимальных по столбцам {sum}");
    return sum;
}
int line = Prompt();
int column = Prompt();
int[,] matrix = RandomMatrixFill(line, column);
PrintMatrix(matrix, line, column);
System.Console.WriteLine(SumOfMaxLine(matrix, line, column) - SumOfMinColumn(matrix, line, column));