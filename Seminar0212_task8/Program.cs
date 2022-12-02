//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.



int A = int.Parse(Console.ReadLine() ?? "0");


int R1 = A % 7;
int R2 = A % 23;



if ((R1 == 0) && (R2 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}