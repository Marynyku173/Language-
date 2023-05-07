//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    int max = number_1;
     Console.WriteLine($"Your first number {number_1} is the maximum");
    int min = number_2;
    Console.WriteLine($"Your second number {number_2} is the minimum");
}
else
{
    int max = number_2;
     Console.WriteLine($"Your second number {number_2} is the maximum");
    int min = number_1;
    Console.WriteLine($"Your first number {number_1} is the minimum");
}
*/

//Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.


/*
Console.Write("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 3rd number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int number_max = number_1;

if (number_1 > number_2)
{
     number_max = number_1;
     Console.WriteLine($"Your first number {number_1} is the maximum");
}
if(number_2 > number_max)
{
     number_max = number_2;
     Console.WriteLine($"Your second number {number_2} is the maximum");
}
if (number_3 > number_max)
{
     number_max = number_3;
     Console.WriteLine($"Your third number {number_3} is the maximum");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine($"Your number {number} is the even number");
}

else
{
    Console.WriteLine($"Your number {number} is the odd number");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current_i = 1;

while (current_i <= number)
{
    if (current_i % 2 == 0)
    {
        Console.Write(current_i + " ");
        current_i ++;
        }

    else
    {
        current_i ++;
    }
}
*/

//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа


/*
void Numb( int user_number)
{
    if (user_number > 99 && user_number < 1000 ||user_number > -1000 && user_number < -99  )
    {
        int digit1 = user_number % 10;// 456 % 10 -> 6
        int digit2 = user_number / 10;  // 456 / 10 -> 45
        int digit3 = digit2 % 10; //45 % 10 -> 5
        Console.WriteLine($"Your number is {digit3}");
    }

    else
    {
        Console.WriteLine($"Your number is not 3-digit");
    }

}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

Numb(user_number);

*/
//Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
/*
void Numb(int user_number)
{
    if (user_number > 99  ||  user_number < -99)
    {   
        while(user_number > 999 || user_number < -999 )
        {
            user_number /=  10;
        }
            if (user_number > 99)
            {
                int digit1 = user_number % 10;// 456 % 10 -> 6
                Console.WriteLine($"The third digit of this number is {digit1}.");
            }

            else 
            {
                int positive_number = user_number * -1;
                int digit2 = positive_number % 10;// 456 % 10 -> 6
                Console.WriteLine($"The third digit of this number is {digit2}.");
            }
        
    }

    else
    {
        Console.WriteLine($"The given number does not have a third digit.");
    }
    
}
Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

 Numb(user_number);

*/

//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Week(int day_week)
{
if (day_week > 0 && day_week < 8)
{
    if (day_week < 6)
    {
        Console.WriteLine($"It's a working day, we still need to work.");
    }
    else
    {
        Console.WriteLine($"Congratulations! Today is a day off, have a rest!");
    }
}
else 
{
    Console.WriteLine($"Sorry. But this number does not correspond to the number of the week. Try again..");
}
}
Console.WriteLine("Input number: ");
int day_week = Convert.ToInt32(Console.ReadLine());

Week(day_week);

*/