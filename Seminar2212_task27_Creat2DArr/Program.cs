// Задача 46
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.  
// Например:  
// m = 3, n = 4.  
// -1 4 8 19  
// 5 -2 33 -2  
// -77 3 8 1 

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

void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int row = ReadData("input rows: ");
int column = ReadData("input columns: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);

Print2dArray(arr2D);