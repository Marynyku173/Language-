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

//Задача 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
/*
void Numb( int user_number)
{
    if (user_number > 9999 && user_number < 100000 ||user_number > -100000 && user_number < -9999  )
    {
        int digit1 = user_number / 10000;
        int digit2 = user_number % 10;
        int digit3 = user_number / 1000;
        int digit4 = digit3 % 10; 
        int digit5 = user_number % 100; 
        int digit6 = digit5 / 10;
        if(digit1 == digit2 && digit4 == digit6)
        {
            Console.WriteLine($"Cool! Your number is a palindrome!");
        }
        else
        {
            Console.WriteLine($"It's sad, but your number is not a palindrome.");
        }
    }
    else
    {
        Console.WriteLine($"Oops, your number is not 5-digit...");
    }
}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

Numb(user_number);
 





//Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2) );
    //double lengthAB1 = Math.Round (lengthAB, 2);// метод округления
    return lengthAB;
}

Console.WriteLine("Input X coordinate of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate of A : ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinate of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate of B : ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine (xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB );

Console.WriteLine($"Distance AB is {dist:f2} ");


*/
//Задача 23 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeFinder()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

        if(numberN > 0)
    {
        int current = 1;
        while (current <= numberN)
        {
            double res = Math.Pow(current, 3);
            Console.Write($"{res:f0}, ");
            current ++;
        }
        Console.WriteLine("\b\b.");
    }
    else 
   {
    int current = 1;
     while (current >= numberN)
        {
            double res = Math.Pow(current, 3);
            Console.Write($"{res}, ");
            current --;
        }
        Console.WriteLine("\b\b.");
   }
}

CubeFinder();
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void Exponentiation (int num, int degree)

{
        int result = 1;
        for(int step = 0; step < degree; step++)
        {
            
            result *= num ;
            
        }
        
    Console.WriteLine($"The number {num} raised to a power {degree} is equal to {result}.");
}

Console.WriteLine("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input degree: ");
    int degree = Convert.ToInt32(Console.ReadLine());

Exponentiation(num, degree);
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int CountOfDigits (int number)
{
    int res = 0;
    while(number > 0)
    {
        res += number % 10;
        number = number / 10;
    }
    return res;
    
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int count;

if(user_num >= 0)
{
    count = CountOfDigits(user_num);
}
else
{
    count = CountOfDigits(user_num * (-1));
}
Console.WriteLine(count);

*/




//Задача 29: Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.
/*
int [] CreatNewArray(int size, int min, int max)
{
    int[] array = new int [size]; 
    for(int i = 0; i < size;  i++)
        array[i] = new Random().Next(min, max + 1) ;
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter count of elements: ");
int countOfelem =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum number: ");
int minVal =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum number: ");
int maxVal =  Convert.ToInt32(Console.ReadLine());


if(minVal < maxVal)
{
int [] array1 = CreatNewArray(countOfelem, minVal, maxVal);

ShowArray(array1);

}
else
{
    Console.WriteLine("Attention when entering data, an error occurred: min cannot be greater than max!!");
}
*/

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
int [] CreatRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray [i] = new Random().Next(minVal, maxVal + 1 );
    return newArray;
}

void ShowArray( int[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is{sizeStart}");
Console.WriteLine();
int minPossibVal = 100;
int maxPossibVal = 999;

void ParityCheck(int [] array3DigNum)
{   int count = 0;
    for(int i = 0; i < array3DigNum.Length; i++)
        if(array3DigNum[i] % 2 == 0)
        {
            count++;
        }
    Console.WriteLine($"The number of even numbers in the array is{count}");
    Console.WriteLine();

}

int [] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );
ShowArray(arrayStart);
Console.WriteLine();

ParityCheck (arrayStart);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreatRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray [i] = new Random().Next(minVal, maxVal + 1 );
    return newArray;
}

void ShowArray( int[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is{sizeStart}");
Console.WriteLine();
int minPossibVal = -100;
int maxPossibVal = 100;

void ParityCheck(int [] array3DigNum)
{   int count = 0;
    for(int i = 0; i < array3DigNum.Length; i++)
        if(i % 2 !=0)
        {
            count += array3DigNum[i];
        }
       Console.WriteLine($"The sum of the elements standing in odd positions is equal to{count}"); 
}

int [] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );
ShowArray(arrayStart);
Console.WriteLine();

ParityCheck (arrayStart);
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double [] CreatRandomArray (int size, int minVal, int maxVal)
{
    double [] newArray = new double[size];
    for(int i = 0; i < size; i++)
        newArray[i]  = Math.Round( new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 2);
        
    return newArray;
}

void ShowArray( double[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
        
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is{sizeStart}");
Console.WriteLine();
int minPossibVal = 1;
int maxPossibVal = 100;




double[] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );// создали массив рандомный
ShowArray(arrayStart);// продемонстрировали массив исходный



double FindMin( )
{   double min = arrayStart[0];
    
    int i;
    for( i = 0; i < arrayStart.Length; i++)
    { 
        if(arrayStart[i] < min )
        {
           min = arrayStart[i];
        }    
    }
    return min;
}

double FindMax( )
{   
    double max = 0;
    int i;
    for( i = 0; i < arrayStart.Length; i++)
    { 
        if(arrayStart[i]> max  )
        {
            max = arrayStart[i];
        }
    }
    return max;
}    
    void Result()
    {  double minNum = FindMin();
       double maxNum = FindMax();
    double res =Math.Round( maxNum - minNum, 2);
    Console.WriteLine($"The minimum number is {minNum}");
    Console.WriteLine();
    Console.WriteLine($"The maximum number is {maxNum}");
    Console.WriteLine();
    Console.WriteLine($"The difference between the maximum and minimum elements of the array is {res}");

    }

Result();