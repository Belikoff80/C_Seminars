//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

System.Random numberSintezator = new System.Random();


int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int A = num / 100;

int B = num % 10;

int R = A * 10 + B;

Console.WriteLine(R);

//для упрощения вс вгоняеся в одну строку вывода