Console.Clear();
int size = InputInt("Размерность Матрицы: ");

int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixC = new int[size, size];

FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);


for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}


Console.WriteLine("\nМатрица - А");
PrintArray(matrixA);

Console.WriteLine("\nМатрица - В");
PrintArray(matrixB);

Console.WriteLine("\nПроизведение матриц А*В");
PrintArray(matrixC);


// Functions
void FillArrayRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + ",  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}