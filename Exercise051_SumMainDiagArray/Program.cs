int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода");

int[,] array = GetArray(rows, columns, 1, 10);
int result =  SumMaunDiagonal(array);

    
PrintArray(array);
Console.WriteLine($"Сумма элементов на главной диагонали массива  -> {result}");


int SumMaunDiagonal(int[,] array)
{
    int sum =  0;   

    for (int i = 0; i < array.GetLength(0); i++)
    {
              
        sum += array[i,i];
    }
    return sum;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return result;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}