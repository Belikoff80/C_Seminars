//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 


string? inputLine = Console.ReadLine();

if (num1Line != null)

{
    //создаем массив с днями недели
    string[] dayofWeek[0] = "понедельник";
    string[] dayofWeek[1] = "вторник";
    string[] dayofWeek[2] = "среда";
    string[] dayofWeek[3] = "четверг";
    string[] dayofWeek[4] = "пятница";
    string[] dayofWeek[5] = "суббота";
    string[] dayofWeek[6] = "восскресенье";

    int inputNumber = int.Parse(inputLine);
    //находим название дня недели по введеному номеру
    string outDayOfWeek = dayOfWeek[inputNumber = 1];

}

//Считываем данные с 
//    //Находим название дня недели по введенному номеру
//    string outDayOfWeek = dayOfWeek[inputNumber-1];
//string outDayOfWeek = string.Empty;
// switch (inputNumber)
// {
//     case 1: outDayOfWeek = "понедельник"; break;
//     case 2: outDayOfWeek = "вторник"; break;
//     case 3: outDayOfWeek = "среда"; break;
//     case 4: outDayOfWeek = "четверг"; break;
//     case 5: outDayOfWeek = "пятница"; break;
//     case 6: outDayOfWeek = "суббота"; break;
//     case 7: outDayOfWeek = "воскресенье"; break;
//     default: outDayOfWeek = "это не день недели!"; break;
// }

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));


//От препода


//Считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //    //Создаем массив с днями недели
    //    string[] dayOfWeek = new string[7];
    //    dayOfWeek[0] = "понедельник";
    //    dayOfWeek[1] = "вторник";
    //    dayOfWeek[2] = "среда";
    //    dayOfWeek[3] = "четверг";
    //    dayOfWeek[4] = "пятница";
    //    dayOfWeek[5] = "суббота";
    //    dayOfWeek[6] = "воскресенье";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);


    // Выводим данные в консоль 
    Console.WriteLine(outDayOfWeek);
}

