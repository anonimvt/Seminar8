Console.Clear();
int n = InputInt("Введите размер квадратного массива: ");
int[,] arr = new int[n, n];
FillArrayRandomNumbers(arr);
PrintArray(arr);
int minsum = Int32.MaxValue;
int index = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] arr)
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