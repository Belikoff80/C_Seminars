//Программа получает число и должна посчитать количество цифр в числе

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

int VariantSimple1(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num / 10;
    }
    return res;
}

//2 вариант - расчет длинна string. 

int VariantSimple2(int num)
{
    int res2 = num.ToString().Length;
    return res2;
}

//3 вариант  - расчет через 10 логарифм  Math.log10(num)+1

int VariantSimple3(int num)
{
    int res3 = (int)Math.Log10(num) + 1;
    return res3;
}

int number = ReadData("input numberA: ");

DateTime d1 = DateTime.Now;
int length3 = VariantSimple3(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int length2 = VariantSimple2(number);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int length1 = VariantSimple1(number);
Console.WriteLine(DateTime.Now - d3);


PrintResult("numbers of digits = " + length3);
PrintResult("numbers of digits = " + length2);
PrintResult("numbers of digits = " + length1);

//выигрывает метод строк. но это заблуждение. так как это слишком маленькое число. но в случае больших чисел победил бы 
// метод с while. 
// логорифм оказывается слишком сложный для масштабных вычислений
