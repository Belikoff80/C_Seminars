// Задача №33
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве и выводит индекс числа

int[] array = GenArray(10, -9, 9);
PrintArray(array);
int num = ReadData("Input number");
int result = SearchElem(array, num);
PrintResult("Answer: " + result);


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

int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}


void PrintResult(string res)
{
    Console.WriteLine(res);
}


int SearchElem(int[] arr, int elem)//вместо bool сделали int, чтобы сделать метод более универсальным
{
    int res = -1;//вместо bool и false вставляем int и -1, это все про универсальность. было  bool res = false
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}

// int[] array = GenArray(10, -9, 10);
// Print1DArr(array);
// int num = ReadData("Введите число");
// int result = SearchElem(array, num);

// PrintData("" + result);

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// int[] GenArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]);
// }

// int SearchElem(int[] arr, int elem)
// {
//     int res = -1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == elem)
//         {
//             res = i;
//             break;
//         }
//     }
//     return res;
// }
