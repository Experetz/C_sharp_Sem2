// Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Please put two numbers    ");
int firstNumb = int.Parse(Console.ReadLine());
int secondNumb = int.Parse(Console.ReadLine());

if (firstNumb / secondNumb == secondNumb){
    Console.WriteLine("YES, your 1 number is squared from 2 number   ");
}
else if (secondNumb / firstNumb == firstNumb){
    Console.WriteLine("YES, your 2 number is squared from 1 number   ");
}
else
{
     Console.WriteLine("NO, there are no squared numbers here ");
}
