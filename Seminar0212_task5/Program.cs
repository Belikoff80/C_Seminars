//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Random numberSintezator = new System.Random();

int number = new Random().Next(10, 100);

int firstNumber = number / 10;
int secondNumber = number % 10;

//  // 1 вариант решения

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine(number);
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(number);
//     Console.WriteLine(secondNumber);
// }


// //Вариант 2

char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
firstNumber = ((int)digits[0] - 48);//данные из сводной таблицы ASCII (преобразовали из символа(из числа) в char) 48 по ASCII что то там такое, я ничего не понял, но это преобразование из digit в чар 
secondNumber = ((int)digits[1] - 48);
//использование тернарного оператора
int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;
Console.WriteLine(resultNumber);
// //