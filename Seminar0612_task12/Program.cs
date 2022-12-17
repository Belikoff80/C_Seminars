// Задача №20
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

//здесь надо сделать функцию
int coordX1 = ReadData("Ввдеите координату Х1");
int coordY1 = ReadData("Ввдеите координату Y1");
int coordX2 = ReadData("Ввдеите координату Х2");
int coordY2 = ReadData("Ввдеите координату Y2");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");

}

double Calculate_length(double x1, double x2, double y1, double y2)
{
    double res = 0;
    res = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2);
    return (res);
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}


PrintData("answer", Calculate_length(coordX1, coordX2, coordY1, coordY2));

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int xh = ReadData("Введите xh: ");
// int xv = ReadData("Введите xv: ");
// int yh = ReadData("Введите yh: ");
// int yv = ReadData("Введите yv: ");

// double CalculateLength(int x1, int x2, int y1, int y2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
//     return res;
// }


// void PrintData(string msg, double result)
// {
//     Console.WriteLine(msg + result);
// }

// PrintData("Расстояние между точками ", CalculateLength(xh, xv, yh, yv));
