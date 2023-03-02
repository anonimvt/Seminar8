Console.Clear();
int n = InputInt("Введите кол-во строк: ");
int m = InputInt("Введите кол-во столбоцов: ");
int[,] arr = new int[n, m];
FillArrayRandomNumbers(arr);
Console.WriteLine();
Console.WriteLine("Массив до изменения: ");
PrintArray(arr);


//const int x = 76; 
//const int y = 85;
//const int z = 88;


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < arr.GetLength(1) - 1; z++)
        {
            if (arr[i, z] < arr[i, z + 1]) 
            {
                int temp = 0;
                temp = arr[i, z];
                arr[i, z] = arr[i, z + 1];
                arr[i, z + 1] = temp;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
PrintArray(arr);


// Functions
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