Console.Clear();
int len = 4;
int[,] arrz = new int[len, len];
FillArraySpiral(arrz, len);
PrintArray(arrz);



void FillArraySpiral(int[,] arr, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        
        do 
        {
            arr[i, j++] = value++; 
        }
        while (++k < n - 1);

        for (k = 0; k < n - 1; k++) 
        {
            arr[i++, j] = value++;
        }

        for (k = 0; k < n - 1; k++) 
        {
            arr[i, j--] = value++;
        }
        
        for (k = 0; k < n - 1; k++) 
        {
            arr[i--, j] = value++;
        }

        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
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