/*
//Console.WriteLine("Good morning");
Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine(number);
*/

//Задача 1
// Напишите программу, которая на вход принимает число и выдает его квадрат
/*
Console.Write("Input your number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

int result = number_1 * number_1;

//Console.WriteLine (number_1 * number_1);
Console.WriteLine ("Your number is " + number_1 + ". Square of this number is " + result);
Console.WriteLine ($"Your number is {number_1}. Square of this number is {result}");
*/
//Задача 3.
//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.

// a = 5, b = 25 -> no
// a = 25, b = 5 -> yes
/* миниалгоритм
1. запросить два значения ( 11+12 строки) +
2. возвести 2е число в квадрат
3. проверить на равенство первому числу


Console.Write("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_2 * number_2 == number_1)
{
    Console.WriteLine($"Your first number is square of the second one");
}
else 
{
   Console.WriteLine($"Your first number is not square of the second one"); 
}


// Задача 5.
// Напишите программу, которая на вход принимает одно число(N),
// а  на выходе показывает все  целые числа в промежутке от - N до N.

Console.Write("Input number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = number_N * (-1);

while (current_i <= number_N)
{
    Console.Write(current_i + " ");
    current_i ++ ;// current_i += 1; current_i = current_i + 1
}
*/

// Задача 7.
//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

// 1. Ввод числа
// 2. Проверить его на 3х значность (N > 99 + N < 1000) +  отрицательные значения
// 3. Найти последнюю цифру (%10) % - отстаток от деления

//456 % 10 -> 6
// 456 % 100 ->56
//456 / 10 -> 45     / - деление нацело
//456 % 100 -> 4
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

//int positive_number = number ( если number > 0) OR number * (-1)
if (number > 99 && number < 1000) // ||number > -1000 && number < -99  )   // && (или &) - логич оператор И      || - логич оператор ИЛИ
{
    //int dev = number % 10;
    //Console.WriteLine( $"Last digit {number} is {dev}");
    Console.WriteLine( "Last num is: "  + number%10) ;
}
else
{
    Console.WriteLine(" Your number is not 3-digit");
}
*/

//Напишите программу, которая получает на вход
// двузначное число и показывает наибольшую цифру числа.

// тип метода Имя метода (аргументы)

/*
int Digits(int number)
{
// 1. выделить цифры числа
int ed = number % 10;
int dec = number / 10;
//2. сравнить цифры
if (ed>dec)
{
    return ed;
}
else
{
    return dec;
}
//3. сообщить результат

}

*/
/*
void Digit1(int number)                //метод сравнения
{
    int ed = number % 10;
    int dec = number / 10;
    if (ed > dec)
    {
        Console.WriteLine($"The biggest digit is {ed}");
    }
    else if(ed == dec)
    {
        Console.WriteLine($"The digits are equal");
    }
    else
    {
        Console.WriteLine($"The biggest digit is {dec}");
    }
}*/
/*
Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 9 && user_number < 100)
{
    Digit1(user_number);    //вызов метода
   // int res = Digits(user_number);
   // Console.WriteLine($"The biggest digit is {res}");
}
 else
{
    Console.WriteLine("Impossible value! ");
}
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

/* 1.невозвратный метод без аргументов
2. генератор*/
/*
void MaxDigit()         // создали метод невозвратный и безаргументный
{

int minVal = 10;
    int maxVal = 99;
    int randomNum = new Random().Next(minVal, maxVal + 1);         // выполнили генерацию из полуинтервала [10, 100]
    Console.WriteLine($"Your number is {randomNum}"); // вывели пользователю сгенерированные значения
    Digit1(randomNum);     // вызвали метод сравнения разрядов

}

MaxDigit();*/

//Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно одновременно a и b.
/*
void Cratnost (int a, int b, int num) // метод проверки на кратность
{
    if ( num % a == 0 && num % b == 0 )
    {
        Console.WriteLine($"Your number {num} is multiple of {a} and {b} ");
    }
    else
    {
        Console.WriteLine($"Your number {num} is not multiple of {a} and {b} ");
    }
}
*/
//запрос данных у пользователя
/*
Console.WriteLine("Input your number: ");       //запрос самого числа
int new_user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 1st  divider: ");   // запрос 1делителя
int div1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2nd  divider: ");      // запрос 2 делителя
int div2 = Convert.ToInt32(Console.ReadLine());

Cratnost (div1, div2, new_user_num); // вызов метода
*/


//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46, 789 -> 79
/*
int DeletDec()
{
    int randomNumber = new Random().Next(100, 1000);
    Console.WriteLine($"Your number is {randomNumber}");

    int digit1 = randomNumber/ 100; // 456 / 100 -> 4
    int digit2 = randomNumber % 10; // 456 % 10 -> 6
    int new_num = digit1 * 10 + digit2;
    return new_num;
}

Console.WriteLine($"Your number is {DeletDec()}");
*/

// //Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*          |y
            |
            |
  II        |           I
            |
            |
___________________________x 
            |
            |
 III        |         IV
            |
            |
            |       

 I x>0, y>0
 II x<0, y>0
 III x<0, y<0
 IV x>0, y<0   
 */
/*
void Koords(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("This point on 1st quater");
    else if (x < 0 && y > 0)
        Console.WriteLine("This point on 2nd quater");
    else if (x < 0 && y < 0)
        Console.WriteLine("This point on 3rd quater");
    else 
        Console.WriteLine("This point on 4st quater");
}

Console.WriteLine("Enter your X coordinste: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Y coordinste: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord == 0 || yCoord == 0 )
    Console.WriteLine("Its impossible value for this task!");
else 
    Koords(xCoord, yCoord ); 

*/
/*
Console.WriteLine("Enter your X coordinste: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Y coordinste: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int Koords(int x, int y)
{
    if (xCoord == 0 && yCoord == 0 )
        {
            Console.WriteLine("Its impossible value for this task!");
            return 0;
        }
    else 
        {
            int number_quater;
            if (x > 0 && y > 0)
             number_quater = 1;
            else if (x < 0 && y > 0)
            number_quater = 2;
            else if (x < 0 && y < 0)
            number_quater = 3;
            else 
            number_quater = 4;
            return number_quater;
        }
}

int quater = Koords(xCoord, yCoord );
Console.WriteLine(quater);

*/


//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void PossibleValue(int num)
{
    if (num == 1)
        Console.WriteLine("1st quater x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("2nd quater x < 0, y > 0");

    else if (num == 3)
        Console.WriteLine("3rd quater x < 0, y < 0");
    else 
        Console.WriteLine("4st quater x > 0, y < 0 ");
}
Console.WriteLine("Input number of quater: ");
int numQuater = Convert.ToInt32(Console.ReadLine());

if (numQuater >= 1 && numQuater <= 4)
        PossibleValue(numQuater);
else Console.WriteLine("Its not number of quater!");
*/

//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
//A(x1, y1); B(x2, y2)
//Math.Sqrt() - извлечение квадратного корня
/*
  _________________________________________
\/(x1 - x2)(x1 - x2) + (y1 - y2)(y1 - y2)
*/
/*
double LongLine(int x1, int x2, int y1, int y2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
    //double lengthAB1 = Math.Round (lengthAB, 2);// метод округления
    return lengthAB;
}

Console.WriteLine("Input X coordinate of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinate of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine (xCoordA, xCoordB, yCoordA, yCoordB );

Console.WriteLine($"Distance AB is {dist:f3} ");// метод округления номер 2

*/

//Напишите программу, которая принимает на вход число (N) и
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
/*
void SquareFinder()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input degree: ");
    int degree = Convert.ToInt32(Console.ReadLine());

    if(numberN > 0)
    {
        int current = 1;
        while (current <= numberN)
        {
            double res = Math.Pow(current,degree);
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
            int res = current * current;
            Console.Write($"{res}, ");
            current --;
        }
        Console.WriteLine("\b\b.");
   }
}

SquareFinder();

*/
/*
Console.WriteLine("Enter your X coordinste: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Y coordinste: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int Koords(int x, int y)
{
    if (xCoord == 0 && yCoord == 0 )
        {
            Console.WriteLine("Its impossible value for this task!");
            return 0;
        }
    else 
        {
            int number_quater;
            if (x > 0 && y > 0)
             number_quater = 1;
            else if (x < 0 && y > 0)
            number_quater = 2;
            else if (x < 0 && y < 0)
            number_quater = 3;
            else 
            number_quater = 4;
            return number_quater;
        }
}

int quater = Koords(xCoord, yCoord );
Console.WriteLine(quater);
*/

//Напишите программу, которая принимает на вход число(А) и выдает сумму чисел от 1 до А.
/*
void MetFindSum(int a)
{
    int sum = 0;
    for(int current = 1; current <= a; current++)
    {
        sum +=current; //sum = sum + current
    }
    Console.WriteLine($"Sum of elements from 1 to {a} is {sum}");
}
Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num >= 1)
{
    MetFindSum(user_num);
}
else
{
    Console.WriteLine("Impossible val!");
}

*/

// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 789 -> 3
// 95123 -> 5
/*

int CountOfDigits (int number)
{
    int countDigits = 1;
    while(number >= 10)
    {
        number = number / 10;
        countDigits++;
    }
    return countDigits;
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

//Напишите программу, которая прнимает на вход число N и выдаёт произведение чисел от 1 до N
/*
void MultipleFinder(int n)
{
    int multi = 1;
    for(int cur = 1; cur <= n; cur++)
    {
        multi *= cur; // multi = multi * cur
    }
Console.WriteLine($"Product of elements from 1 to {n} is {multi}");
}

Console.WriteLine("Enter number: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    while (number <= 0)
    {
        Console.WriteLine("Enter POSITIVE number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
}

MultipleFinder(number);
*/

// Напишите программу, которая выводит массив из 8 эелементов, заполненный нулями и единицами в случайном порядке.
// [1, 0, 1, 1, 0,1 ,0, 0]
/*
int [] CreatNewArray(int size, int min, int max)//метод создания массива
{
     int[] array = new int [size]; // int(1)тип данных массива, [] -  массив, array -  имя массива, new - выделение памяти, int [размер массива]
     for(int i = 0; i < size;  i++)
     //array[i] - значение элемента в массиве array на позиции i
        array[i] = new Random().Next(min, max + 1) ;
    return array;
     
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)//array.Length - определяет кол-во элементов в уже существующем массиве
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter count of elements: ");
int countOfelem =  Convert.ToInt32(Console.ReadLine());

int minVal = 0;
int maxVal = 1;

int [] array1 = CreatNewArray(countOfelem, minVal, maxVal);
ShowArray(array1);
*/




