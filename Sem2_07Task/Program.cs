// Программа, которая принимает число (int)
// и выведет на экран количество цифр в этом числе. 
//Число может быть любой разрядности (до int).

Console.WriteLine("Lets check your number  ");
int number = int.Parse(Console.ReadLine());
int index = 1;

    while( number/10 != 0 ){
        number = number/10;
        index++;
        
        }
    Console.WriteLine(index);
