// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.


Console.WriteLine("Please put two numbers    ");
int firstNumb = int.Parse(Console.ReadLine());
int secondNumb = int.Parse(Console.ReadLine());
int div = firstNumb % secondNumb;
int remainder = div % 10;

if ( div == 0){
    Console.Write("Your number is multiple");
}
else 
{
   
   Console.Write($"Your number is not multiple, remainder is {remainder}");
}
