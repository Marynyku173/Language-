﻿void FillArray(int[] collection)
{
    int legth = collection.Length;
    int index = 0;
    while (index < legth)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  
        }
        index++;
    }
    return position;
};
int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[2] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
