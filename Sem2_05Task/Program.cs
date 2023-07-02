// Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Lets check if your number is multple to 7 and 21    ");
int number = int.Parse(Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0)){
    Console.WriteLine("Yes! Your number is multiple");
}
else 
{
    Console.WriteLine("No, Your number is NOT multiple");
}

