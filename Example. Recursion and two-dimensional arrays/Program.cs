/*string [,] table = new string[2, 5];
// String.Empty  -- по умолчанию для строк инициализация произходит через такую константу
// table [0, 0] table [0, 1] table [0, 2] .... table [0, 4] меняет индекс строки
//table [1, 0] table [1, 1]  table [1, 2] .... table [1, 4] меняет индекс столбца
table [1, 2] = " слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/*
void PrintArray(int[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)- это конструкция дает количество строк, где 0 это аргумент отвечающий за количество строк в массиве
{
    for(int j = 0; j < matr.GetLength(1); j++)// matrix.GetLength(1)- это конструкция дает количество столбцов, где 1 это аргумент отвечающий за количество столбцов в массиве
    {
        Console.Write($"{matr[i, j]} ");
    }
  Console.WriteLine();   
}
}



void FillArray(int[,] matr)
{


for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(1, 10);
    }
     }
}

int [,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
*/
/*
int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();   
    }
}

void FillImage(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/
/*//расчет факториала
Double Factorial(int n)
{

    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);

}

for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/// расчет число Фибоначчи
/* а(1)= 1
а(2) = 1
а(n) = a(n -1 ) + a(n - 2)
*/
/*
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci (n - 1) + Fibonacci(n - 2);

}
 for(int i = 1; i < 50; i++)
 {
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
 }
*/



// Собрать строку с числами от a до b, a <= b
/*
string NumbersFor(int a, int b)// метод без рекурсии , с помощью циклов
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)// Метод с рекурсией
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine();
Console.WriteLine(NumbersRec(1, 10));

*/
/*

string NumbersFor(int a, int b)// метод без рекурсии , с помощью циклов
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)// Метод с рекурсией
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}


Console.WriteLine(NumbersFor(10, 1));
Console.WriteLine();
Console.WriteLine(NumbersRec(1, 10));
*/



//Сумма чисел от 1 до n

/*
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}


int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);

}

Console.WriteLine(SumFor(10));
Console.WriteLine();
Console.WriteLine(SumRec(10));
*/

//Факториал числа
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}


Console.WriteLine(FactorialFor(10));
Console.WriteLine();
Console.WriteLine(FactorialRec(10));
*/
// Возвести a в степень n
/*
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
   // if (n == 0) return 1;
   // else return PowerRec(a, n - 1) * a;

}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine();
Console.WriteLine(PowerRec(2, 10));
*/
/*
int PowerRecMath(int a, int n)
{

    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;

}

Console.WriteLine(PowerRecMath(2, 9));
*/

//Перебор слов
//Следующий пример немного сложнее. Пусть у нас будет некоторый алфавит, состоящий из
//четырёх букв, и нас просят показать все возможные слова, состоящие из T букв. Т может
//равняться 1, 2, 3 и так далее.
/*
string path = @"C:/Users/12345/Desktop/Language C#/Examples/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for  (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");

    }
}
string path = @"C:/Users/12345/Desktop/Language C#/Examples";
CatalogInfo(path);
*/

//Игра в пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1 ) Towers (some, on, with, count - 1);
}
Towers();
*/


//Написание задачи(4-2)*(1+3)/10
/*
string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "=", emp, emp, "4", "2", "1", "3" };
//
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.Write(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
*/

/*
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}


decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
Console.ReadLine();

DateTime dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15 }");
    fIte = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine();

 dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();

*/
/*
int i = 0;
void Rec()
{
    System.Console.WriteLine(i++);
    Rec();
}
Rec();
*/


/*
int[,] pic = new int[1000, 1000];
for(int i =0; i < 10; i++)
{
    pic [0,i] = 1;
    pic [i,0] = 1;
    pic [i,9] = 1;
    pic [9,i] = 1;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();   
    }
}

void FillImage(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

*/


int row = 9;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= row; j++)
        {
            triangle[i, j] =
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }

}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
            {
                Console.Write($"{triangle[i, j],cellWidth}");
            }
        }
        Console.WriteLine();
    }
}


void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.WriteLine($"{triangle[i, j],cellWidth}");
             if (triangle[i, j] != 0) Console.WriteLine("*");
            col += cellWidth * 2;

        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
Console.ReadLine();
FillTriangle();
PrintTriangle();
Console.ReadLine();
Magic();
