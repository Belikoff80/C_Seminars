// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = GenArray(123, -100, 100);
PrintArray(array);

int result = CountElem(array, 10, 99);
Console.WriteLine();

int[] GenArray(int num, int lowRange, int upRange)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lowRange, upRange + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}




void PrintResult(string res)
{
    Console.WriteLine(res);
}

int CountElem(int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max)
        {
            res++;
        }
    }
    return res;
}

// int[] array = GenArray(123,-100,100);
// PrintArray(array);

// int result = CountElement(array,10,99);
// PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99] составляет", result);

// int[] GenArray(int len, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] outArray = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         outArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return outArray;
// }
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }
// void PrintArray(int[] arr) 
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
// }
// int CountElement(int[] array, int min, int max)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > min && array[i] < max)
//         {
//             res++;
//         }
//     }
//     return res;
// }
