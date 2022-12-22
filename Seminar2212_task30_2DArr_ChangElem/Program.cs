// Задача №49  
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. 
// Например:  
// Например, изначально массив выглядел вот так:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// Новый массив будет выглядеть вот так:  
// 1 4 7 2  
// 5 81 2 9 
// 8 4 2 4 

int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Универсальный метод заполнения 2мерных массивов
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

void Update2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            //if (i % 2 == 0 && j % 2 == 0) arr[i, j] = Math.Pow(arr[i, j], 2);
            //так запись актуально если шаг +1. 
            // Мы сделаем шаг +2
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            //для универсального выравнивания можно также использовать метод заполнения
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

int row = ReadData("input row: ");
int col = ReadData("input column: ");
int[,] arr2D = Fill2DArray(row, col, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
Update2DArray(arr2D);
Print2DArray(arr2D);
