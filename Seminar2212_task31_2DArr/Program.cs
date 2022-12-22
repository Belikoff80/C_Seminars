// Задача №51  
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.   
// Например: Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// Сумма элементов главной диагонали: 1+9+2 = 12 


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

int DiogElemSum(int[,] arr)
{
    int result = 0;
    //так как считаем по мин диоганале то применим метод тернального оператора
    int min = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        result += arr[i, i];
    }
    return result;
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

void PrintResult(string line)
{
    Console.WriteLine(line);

}

int row = ReadData("input row: ");
int col = ReadData("input column: ");
int[,] arr2D = Fill2DArray(row, col, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
int SumOfDiog = DiogElemSum(arr2D);
PrintResult("Sum of elements: " + SumOfDiog);
