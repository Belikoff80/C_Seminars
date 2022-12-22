// Задача №40 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


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

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (b + c > a));
}

int A = ReadData("input:");
int B = ReadData("input:");
int C = ReadData("input:");
TriangleTest(A, B, C);
PrintResult("Result:" + TriangleTest(A, B, C));