// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива






int[] GenArray(int num, int lowRange, int upRange)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowRange, upRange + 1);
    }

    return arr;
}

void PrintResult(string res, int value)
{
    Console.WriteLine(res + value);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}


void negotivePosetiveSum(int[] arr)
{
    int negotiveSum = 0;
    int posetiveSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posetiveSum += arr[i];
        }
        else
        {
            negotiveSum += arr[i];
        }
    }
    Console.WriteLine(posetiveSum);
    Console.WriteLine(negotiveSum);
}

int[] testArr = GenArray(12, -9, 9);


PrintArray(testArr);
Console.WriteLine();
negotivePosetiveSum(testArr);


