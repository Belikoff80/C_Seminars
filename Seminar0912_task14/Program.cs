//Программа принимает число А и выдает сумму чисел от 1 до А

//Рассматриваем два метода решения задач: АЛГОРИТМИЧЕСКИЙ  / АНАЛИТИЧЕСКИЙ
// и сравниваем скорости их работы

//Шаги:
// 1. ввод данных 
// 2. расчет
// 3. вывод данных

// data request to user 
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//здесь мы используем простейший метод расчеа суммы.
//Но для ПК это проблема - время затраты. Для сокращения времени вычисления 
//в алгоритме правильнее использовать формулы. В данном случае это будет формула Гаусса(см ниже метод)  S(n)=((a1+an)/2)*n
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int number = ReadData("Input nunber A:");

//Для измерения времени обработки команды используется следующий метод:
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(number);
Console.WriteLine(DateTime.Now - d1);


DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(number);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Sum of digits: -simple-" + res1 + " -Gause- " + res2);

// Вывод: скорость работы аналитического метода в 82 раз выше