// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается такой масив
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int minimum = UserInput("Введите минимальное значение = ");
int maximum = UserInput("Введите максимальное значение = ");
int[,] createRandomDoubleMatrix = CreateRandomDoubleMatrix(numberLine, numberColumb, minimum, maximum);
PrintArrayMatrix(createRandomDoubleMatrix);
int[,] descendingMatrixLine = DescendingMatrixLine(createRandomDoubleMatrix);
Console.WriteLine();
PrintArrayMatrix(descendingMatrixLine);
int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}
int[,] CreateRandomDoubleMatrix(int line, int columb, int min, int max)
{
    int[,] matrix = new int[line, columb];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columb; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
int[,] DescendingMatrixLine(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 2; k++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    int tmp = matrix[i, j - 1];
                    matrix[i, j - 1] = matrix[i, j];
                    matrix[i, j] = tmp;
                }
            }

        }
    }
    return matrix;
}

