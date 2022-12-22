// Задача №39 
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

//вывод на печать массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод разворота 
int[] SwapArray(int[] arr)
{
    int bufElement = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;

    }
    return arr;
}

//метод разворота с особенностью
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];

    }
    return arr;
}


int[] array = GenArray(20, 1, 100);
Console.WriteLine("заполненный массив: ");
PrintArray(array);

int[] copyArr = SwapArray(array);
Console.WriteLine("новый массив перевернутый swaparray методом: ");
PrintArray(copyArr);
Console.WriteLine("Исходный: ");
PrintArray(array);

int[] copyArrTwo = SwapNewArray(array);
Console.WriteLine("новый массив перевернутый swapnewarray методом: ");
PrintArray(copyArrTwo);
Console.WriteLine("Исходный: ");
PrintArray(array);