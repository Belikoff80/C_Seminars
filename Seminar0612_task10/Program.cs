// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

//1 этап вводим данные 



int coordX = ReadData("Ввдеите координату Х");
int coordY = ReadData("Ввдеите координату Y");
PrintQuterTest();
//создадим функцию
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//ф ция определяет четверть по координатам
void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}


// from nadej
// Console.WriteLine("Введите х: ");
// int x = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите y: ");
// int y = int.Parse(Console.ReadLine() ?? "0");

// if (x>0)
// {
//     if (y>0) Console.WriteLine("Это первая четверть");
//     else  Console.WriteLine("Это вторая четверть");
// }
// else
// {
//     if (y>0) Console.WriteLine("Это четвертая четверть");
//     else  Console.WriteLine("Это третья четверть");
// }
