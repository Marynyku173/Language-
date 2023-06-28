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
int minVal = -100;
int maxVal = 100;

void ParityCheck(int [] arrayDigNum)
{   int count = 0;
    for(int i = 0; i < arrayDigNum.Length; i++)
        if(i % 2 !=0)
        {
            count += arrayDigNum[i];
        }
       Console.WriteLine($"The sum of the elements standing in odd positions is equal to{count}"); 
}

int [] arrayStart = CreatRandomArray( sizeStart, minVal,maxVal );
ShowArray(arrayStart);
Console.WriteLine();

ParityCheck (arrayStart);
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*
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
Console.WriteLine();



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

*/




//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] NumUser = Console.ReadLine().Split().Select(int.Parse).ToArray();

void NumGreatZero()
{
    int score = 0;
    for(int i = 0; i < NumUser.Length; i++)
        if(NumUser [i] > 0)
        score++;
   Console.WriteLine($"Here's how many {score} numbers greater than zero you entered.");     
}

NumGreatZero();

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Set the first coordinate: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Set the second coordinate: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Set the third coordinate: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Set the fourth coordinate: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1*x + b1;

if(k1==k2 || b1 == b2) Console.Write("The given lines do not intersect!");
else Console.WriteLine($"The coordinates of the intersection point of two straight lines are equal [{x}; {y}]. ");
*/




//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] Create2DArray(int row, int column, int minV, int maxV)
{
    double [,] created2Darray = new double[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = Math.Round((new Random().Next(minV, maxV)) + new Random().NextDouble(), 2);

     return created2Darray;
}

void ShowDouble2Darray(double [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

 Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of colums: ");
    int userColums = Convert.ToInt32(Console.ReadLine());
    
    int userMin = -100;
    int userMax = 100;

    double [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
ShowDouble2Darray(createdArray);

*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] Create2DArray(int row, int column, int minV, int maxV)
{
    int [,] created2Darray = new int[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = new Random().Next(minV, maxV);

     return created2Darray;
}

void ShowDouble2Darray(int [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

    
    int userRows = 5;
    int userColums = 7;
    
    int userMin = 0;
    int userMax = 10;

    int [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
    Console.WriteLine();
    ShowDouble2Darray(createdArray);
    Console.WriteLine();



void  PositionNumber( )
{ 

    Console.Write("Enter the row: ");
int posRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter a column: ");
int posColumn = Convert.ToInt32(Console.ReadLine()) - 1;
    
if (posRow<1 || posColumn<1)
{
    Console.WriteLine("Row positions cannot be negative!");
}      
    else if (posRow < 0 | posRow > createdArray.GetLength(0) - 1 | posColumn < 0 | posColumn > createdArray.GetLength(1) - 1)
{
Console.WriteLine("There is no such element!");
}
    else
{
    Console.WriteLine("The value of the array element is = {0}", createdArray[posRow, posColumn]);
}
Console.ReadLine();
}
PositionNumber();
*/
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] Create2DArray(int row, int column, int minV, int maxV)
{
    int [,] created2Darray = new int[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = new Random().Next(minV, maxV);

     return created2Darray;
}

void ShowDouble2Darray(int [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of colums: ");
    int userColums = Convert.ToInt32(Console.ReadLine());
    
    int userMin = 0;
    int userMax = 10;

    int [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
    Console.WriteLine();
    ShowDouble2Darray(createdArray);

    for( int j = 0; j< createdArray.GetLength(1); j++)
    {
        double sum = 0;
        for( int i = 0; i< createdArray.GetLength(0); i++)
        {
            sum += createdArray[i,j];
            
        }
        Console.Write($"{ sum / createdArray.GetLength(0)} ");
        
    }
   
*/

//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Enter the dimension m of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the dimension n of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] RanArray = new int[m,n];

void Array1(int m, int n)
{
    int i,j;
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            RanArray[i,j] = new Random().Next(1, 9);
        }
    }
}

void printArray(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

Array1(m,n);
Console.WriteLine("Source array: ");
printArray(RanArray);


void ArrangeArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

ArrangeArr(RanArray);
Console.WriteLine("Sorted array: ");
printArray(RanArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int height = EnterInt("Enter the number of rows: ");
int width = EnterInt("Enter the number of columns: ");
 
int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
SumInLines(numbers);
 
int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
 
void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-20, 21);
        }
    }
}
 
void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)      
    {
        for (int j = 0; j < numbers.GetLength(1); j++)   
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }    
}
 

 void SumInLines(int[,] numbers)
{
    int[] sumInLines = new int[numbers.GetLength(0)];//создаем массив для подсчета суммы построчно
    Console.Write("Sums of elements in each row: ");
    for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sumInLines[i] += numbers[i, j];
            }
            Console.Write($"{sumInLines[i]} ");
        }
    int minI = 0;
        for (int i = 0; i < sumInLines.Length; i++)
        {
            if (sumInLines[minI] > sumInLines[i]) minI = i;
        }
           
    Console.Write($"Smallest sum of elements: {sumInLines[minI]}, line number with it: {minI + 1}");

}

*/

//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*
Random rnd = new Random();
int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}
void Main(string[] args)
{
    int[,] array2D = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    int[,] matrix = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    PrintMatrix(array2D);
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(DivMatrix(array2D, matrix));
    Console.ReadLine();
}

Main(args);
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.WriteLine($"Enter the size of the array X x Y x Z: ");
int x = InputNumbers("Enter X: ");
int y = InputNumbers("Enter Y: ");
int z = InputNumbers("Enter Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Spiral Array 4 on 4: ");
int[,] matrix = new int[4, 4];
Console.WriteLine(); 

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintMatrix(matrix);
*/
/*
// делает рандом из 8 чисел неповторяющимся числами
Random rnd = new Random(); 
HashSet<int> hs = new HashSet<int>(); 
while (hs.Count < 8) hs.Add(rnd.Next(10)); 
int[] a = hs.ToArray(); 
foreach (int e in a) Console.Write(e + " ");
*/