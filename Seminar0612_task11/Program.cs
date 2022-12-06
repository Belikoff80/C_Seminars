//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quter = ReadData("номер четверти");

PrintAnswer(quter);
//создадим функцию
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ф ция определяет четверть по координатам
void PrintAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("coordX > 0 && coordY > 0");
        if (num == 2) Console.WriteLine("coordX > 0 && coordY < 0");
        if (num == 3) Console.WriteLine("coordX < 0 && coordY < 0");
        if (num == 4) Console.WriteLine("coordX < 0 && coordY > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти");

}
