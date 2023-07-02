// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.


Console.WriteLine("Lets check your number  ");
int number = int.Parse(Console.ReadLine());

if (number < 100){
    Console.WriteLine("There is no third digit");
}
else {
while (number > 999)
    {
    number = number / 10;
    
    }
    Console.WriteLine($"Third digit of your number is {number % 10}");
}





