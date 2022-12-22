// Задача №42 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


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


// 1st coverting merhod from dec to bin
string DectoBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

//2nd
string DecToBin2(int num)
{
    return Convert.ToString(num, 2);
}

int inputNumber = ReadData("Input number: ");
Console.WriteLine();
PrintResult("Result 1st method: " + DectoBin(inputNumber));
Console.WriteLine();
PrintResult("Result 2nd metod: " + DecToBin2(inputNumber));

PrintResult("Result oct(8) method: " + Convert.ToString(inputNumber, 8));
PrintResult("Result hex(16) method: " + Convert.ToString(inputNumber, 16));