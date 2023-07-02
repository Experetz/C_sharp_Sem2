// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Please put 3 digits number   ");
int Numb = int.Parse(Console.ReadLine());

if ((Numb < 100) || (Numb > -99) || (Numb > 999) || (Numb < -999))
{
    Console.WriteLine("Invalid number! Put three digits number");
}
else
{
int secondDigit = Numb / 10 % 10;

Console.Write(secondDigit);
}