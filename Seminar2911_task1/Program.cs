
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 


string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null)

{
    //Парсим введеное число. То есть переводим из сринга в интежер
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    if (num2 * num2 == num1)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число не квадрат второго");
    }


}



//string? Num1Line = Console.ReadLine();
//string? Num2Line = Console.ReadLine();


//if (Num1Line != null && Num2Line != null)
//{
//   int num1 = int.Parse(Num1Line);
//   int num2 = int.Parse(Num2Line);

//   if (num2 * num2 == num1)
//   {
//       Console.WriteLine("Yes");
//   }
//   else
//   {
//       Console.WriteLine("No");
//   }

//}

