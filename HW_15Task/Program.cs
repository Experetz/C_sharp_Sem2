// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Put your week day number  ");
int weekDay = int.Parse(Console.ReadLine());

    if((weekDay < 1) ||(weekDay > 7)){
        Console.WriteLine("Wrong number, this is not a week day ");
}
    else if (weekDay > 5){
    Console.WriteLine("Happy joy, Its weekend!");
    }
    else {
        Console.WriteLine("Early to relax, its work day");
    }
    