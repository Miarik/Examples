// Задача 50. Напишите программу, которая на вход принимает число и ищет в 
// двумерном массиве, и возвращает индексы этого элемента или же указание, что 
// такого элемента нет.
// Например, задан массив:

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[,] FillArray (int rows, int columns)
{
    Random random = new Random ();
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(0,10);
        }
    }
    return arr;
}

void CheckNumber(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (number == arr[i,j])
           {
              Console.WriteLine($"{i}, {j}");  
           } 
           else
           {
            Console.WriteLine("Нет такого элемента");
           }
        }
    }
}

void PrintArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write($"{arr[i,j]} "); 
        }  
        Console.WriteLine();
    }
}

int[,] array = FillArray(rows, columns);
PrintArray(array);
CheckNumber(array, number);

