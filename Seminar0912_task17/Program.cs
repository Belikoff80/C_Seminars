//программа выводит массив из 8 элементов и заполняет его 0 и 1 в случайном порядке

int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

void PrintResult(string line, int[] arr)
{
    Console.WriteLine(line);
    PrintArray(arr);
}

int[] GenArray(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
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
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Input array lenth: ");

int[] arr = GenArray(arrLen);

PrintResult("Created array: ", arr);