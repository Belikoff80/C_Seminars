//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int starNumber = inputNumber * (-1);

    //входное значение_

    string outLine = string.Empty;

    while ()


        //ОТ ПРЕПОДА
        //Считываем данные с консоли
        string? inputLine = Console.ReadLine();

    //Проверяем, чтобы данные были не пустыми
    if (inputLine != null)
    {

        //Парсим введенное число
        int inputNumber = int.Parse(inputLine);

        int startNumber = inputNumber * (-1);

        //Выходное значение
        string outLine = string.Empty;

        while (startNumber < inputNumber)
        {
            outLine = outLine + startNumber + ", ";
            startNumber++;
            //startNumber=startNumber+1;
        }
        outLine = outLine + inputNumber;

        // Выводим данные в консоль 
        Console.WriteLine(outLine);
    }
