// Задача №48   
//Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран. 
// Пример: m = 3, n = 4.  
// 0 1 2 3   
// 1 2 3 4  
// 2 3 4 5 

int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Универсальный метод заполнения 2мерных массивов
int[,] Fill2DIndexed(int row, int col)
{

    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write(" " + matrix[i, j] + " |");
            else Console.Write(matrix[i, j] + " |");
            //для универсального выравнивания можно также использовать метод заполнения
            //Console.Write(matrix[i,j]+"   ".Substring(matrix[i,j].Tostring().Length))
        }
        Console.WriteLine();
    }
}

int row = ReadData("input row: ");
int col = ReadData("input column: ");
int[,] arr2D = Fill2DIndexed(row, col);
Print2dArray(arr2D);