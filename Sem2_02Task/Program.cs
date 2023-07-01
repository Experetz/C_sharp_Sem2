// Напишите программу, которая выводит случайное число 
//из отрезка [10,99] и показывает наибольшую цифру числа. 

int randNumb = new Random().Next(10, 100);
Console.WriteLine($"Random number is {randNumb} ");

int firstDigit = randNumb / 10;
int secondDigit = randNumb % 10;

    if (firstDigit > secondDigit)
{
    Console.WriteLine($"The biggest digit of your number is {firstDigit} ");
}

    else
{
    Console.WriteLine($"The biggest digit of your number is {secondDigit} ");
}

