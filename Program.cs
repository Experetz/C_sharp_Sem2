//Напишите программу, которая принимает на вход число (>0)
//и выводит все числа от 1 до этого числа 

Console.WriteLine("Put a number    ");
int Aa = int.Parse(Console.ReadLine());
int Bb = 1;

while (Bb <= Aa)
{
 Console.Write($"{Bb} ");
 Bb = Bb + 1;
}
