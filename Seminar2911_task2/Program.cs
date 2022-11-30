//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 



//От препода


//Считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторник";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    string outDayOfWeek = dayOfWeek[inputNumber - 1];


    // Выводим данные в консоль 
    Console.WriteLine(outDayOfWeek);
}

