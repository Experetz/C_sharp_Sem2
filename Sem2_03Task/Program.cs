//Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа.

int randNumber = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {randNumber} ");

int firstDigit = randNumber / 100;
int thirdDigit = randNumber % 10;

Console.Write(firstDigit);
Console.Write(thirdDigit);


