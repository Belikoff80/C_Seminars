//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.



int A = int.Parse(Console.ReadLine() ?? "0");

int B = int.Parse(Console.ReadLine() ?? "0");

bool R1 = (A / B == B);
bool R2 = (B / A == A);

if (R1) Console.WriteLine("Да A квадрат B");
if (R2) Console.WriteLine("Да B квадрат А");
if (!R2 && !R1) Console.WriteLine("Нет");

// //От препода пример
// void TestSQRT(int i, int j)
// {
//     bool result = (i/j==j);
//     if(result==true)Console.WriteLine(" Число "+i+" является квадратом числа "+j);
//     else Console.WriteLine(" Число "+i+" не является квадратом числа "+j);
// }

// int number1 = int.Parse(Console.ReadLine()??"0");
// int number2 = int.Parse(Console.ReadLine()??"0");
// TestSQRT(number1,number2);
// TestSQRT(number2,number1);
