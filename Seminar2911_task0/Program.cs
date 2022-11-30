string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num1Line != null) ;

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
