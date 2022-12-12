//Прогрмма принимает число N и выдает произведение от 1 до N. Т.е. ФАКТОРИАЛ

// запускаем библиотеку Numerics для работы с длинными числами
using System.Numerics;

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
//1 вариант через деление


//Так как факториал супер агрессивная ф-ция, которя быстро заполняет память, 
//используется другой тип данных не int = 4 байт, а long = 8 байт


long CalcData(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

// а этот метод уже для использования супер длинных чисел
BigInteger CalcData1(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}
int number = ReadData("input numberA: ");

DateTime d1 = DateTime.Now;
long length1 = CalcData(number);
Console.WriteLine(DateTime.Now - d1);

PrintResult("n! = " + length1);

DateTime d2 = DateTime.Now;
BigInteger length2 = CalcData1(number);
Console.WriteLine(DateTime.Now - d2);

PrintResult("n! = " + length2);
// при использовании типа long объема памяти уже недостаточно. и программа работает не правильно(выдает отрицательные значения)
// поэтому необходимо использовать особый тип данных BigInteger!
// для этого необходимо запустить библиотеку using System.Numerics